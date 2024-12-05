﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorgovoPosredFirma.Model.Classes;
using TorgovoPosredFirma.View.Interfaces;

namespace TorgovoPosredFirma.Logic.Presenters
{
    public class MainPresenter
    {
        string _connectionString = "Host = localhost;Username = postgres;Password = admin;Port = 5432;Database = postgres;";
        private readonly IMain _view;
        private User _user;
        public MainPresenter(IMain view, User user) 
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _user = user ?? throw new ArgumentNullException(nameof(user));
            _view.fullGrant += FullGrant;
            _view.userAccessGrant += UserAccessGrant;
            _view.GetConnectionString += SendConnectionString;
        }
        public void SendConnectionString(object sender, EventArgs e)
        {
            _view.SendConnectionString(_connectionString);
        }
        
        public void FullGrant(object sender, EventArgs e)
        {
            try
            {
                string grantQuery = "SELECT id, id_parent, menuitem_name, dll_name, function_name, sequence_number FROM public.tbmodules ORDER BY id_parent, sequence_number;";
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    var modules = new List<Module>();
                    connection.Open();
                    using (var command = new NpgsqlCommand(grantQuery,connection))
                    {
                        using (var reader  = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(2) == "Главное меню")
                                {
                                    continue;
                                }
                                modules.Add(new Module
                                {
                                    Id = reader.GetInt64(0),
                                    IdParent = reader.GetInt32(1),
                                    MenuItemName = reader.GetString(2),
                                    DllName = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    FunctionName = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    SequenceNumber = reader.GetInt32(5)
                                });
                            }
                            _view.BuildMenu(modules);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                _view.Message("Критическая ошибка! Сообщите подробности Вашему техническому специалисту! " + ex.Message);
            }
        }
        public void UserAccessGrant(object sender, EventArgs e)
        {
            try
            {
                string grantQuery = "SELECT m.id, m.id_parent, m.menuitem_name, m.dll_name, m.function_name, m.sequence_number, r.allow_read FROM public.tbmodules m LEFT JOIN public.tbroles r ON m.id = r.id_menuitem AND r.id_user = @UserId WHERE r.allow_read = true OR m.id_parent = 0 ORDER BY m.id_parent, m.sequence_number;";
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    var modules = new List<Module>();
                    connection.Open();
                    using (var command = new NpgsqlCommand(grantQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId",_user.Id);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(2) == "Главное меню")
                                {
                                    continue;
                                }
                                modules.Add(new Module
                                {
                                    Id = reader.GetInt64(0),
                                    IdParent = reader.GetInt32(1),
                                    MenuItemName = reader.GetString(2),
                                    DllName = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    FunctionName = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    SequenceNumber = reader.GetInt32(5)
                                });
                            }
                            _view.BuildMenu(modules,_user);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                _view.Message("Критическая ошибка! Сообщите подробности Вашему техническому специалисту! " + ex.Message);
            }
        }
    }
}
