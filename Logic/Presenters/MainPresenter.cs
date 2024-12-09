using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TorgovoPosredFirma.View.Interfaces;

namespace TorgovoPosredFirma.Logic.Presenters
{
    public class MainPresenter
    {
        public IConnectionStringConsumer _connectionStringConsumer;
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
            _view.AddClick += AddClick;
            _view.UpdateClick += UpdateClick;
            _view.DeleteClick += DeleteClick;
        }
        public void SendConnectionString(object sender, EventArgs e)
        {
            _view.SendConnectionString(_connectionString);
        }
        public void AddClick(object sender, string currentDll)
        {
            _view.OpenForm(currentDll,"Add");
        }
        public void UpdateClick(object sender, string currentDll)
        {
            _view.OpenForm(currentDll,"Edit");
        }
        public void DeleteClick(object sender, string currentDll)
        {
            _view.OpenForm(currentDll, "Delete");
        }
        public void FullGrant(object sender, EventArgs e)
        {
            try
            {
                string grantQuery = "SELECT id, id_parent, menuitem_name, dll_name, function_name, sequence_number, ismethodtakeable FROM public.tbmodules ORDER BY id_parent, sequence_number;";
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    var modules = new List<SharedModels.Module>();
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
                                modules.Add(new SharedModels.Module
                                {
                                    Id = reader.GetInt64(0),
                                    IdParent = reader.GetInt32(1),
                                    MenuItemName = reader.GetString(2),
                                    DllName = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    FunctionName = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    SequenceNumber = reader.GetInt32(5),
                                    IsMethodTakeable = reader.GetBoolean(6)
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
                // Список ролей пользователя
                List<Role> userRoles = new List<Role>();

                string rolesQuery = "SELECT id_menuitem, allow_read, allow_write, allow_edit, allow_delete FROM tbRoles WHERE id_user = @UserId;";
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand(rolesQuery, connection))
                    {
                        command.Parameters.AddWithValue("UserId", _user.Id);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                userRoles.Add(new Role
                                {
                                    MenuItemId = reader.GetInt64(0),
                                    AllowRead = reader.GetBoolean(1),
                                    AllowWrite = reader.GetBoolean(2),
                                    AllowEdit = reader.GetBoolean(3),
                                    AllowDelete = reader.GetBoolean(4)
                                });
                            }
                        }
                    }
                }

                // Список модулей (пунктов меню)
                string grantQuery = @"
            SELECT m.id, m.id_parent, m.menuitem_name, m.dll_name, m.function_name, m.sequence_number, 
                   COALESCE(r.allow_read, false) AS allow_read, m.isnecessary, ismethodtakeable
            FROM public.tbmodules m
            LEFT JOIN public.tbroles r 
            ON m.id = r.id_menuitem AND r.id_user = @UserId
            ORDER BY m.id_parent, m.sequence_number;";

                var modules = new List<SharedModels.Module>();
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand(grantQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", _user.Id);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                modules.Add(new SharedModels.Module
                                {
                                    Id = reader.GetInt64(0),
                                    IdParent = reader.IsDBNull(1) ? 0 : reader.GetInt64(1),
                                    MenuItemName = reader.GetString(2),
                                    DllName = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    FunctionName = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    SequenceNumber = reader.GetInt32(5),
                                    AllowRead = reader.GetBoolean(6),
                                    IsNecessary = reader.GetBoolean(7),
                                    IsMethodTakeable = reader.GetBoolean(8)
                                });
                            }
                        }
                    }
                }

                _view.BuildMenu(modules, userRoles);
            }
            catch (Exception ex)
            {
                _view.Message("Критическая ошибка! Сообщите подробности Вашему техническому специалисту! " + ex.Message);
            }
        }
    }
}
