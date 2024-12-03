using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorgovoPosredFirma.View.Interfaces;
using Npgsql;
using System.Security.Cryptography;
using TorgovoPosredFirma.Model.Classes;

namespace TorgovoPosredFirma.Logic.Presenters
{
    public class AuthorizationPresenter
    {
        string _connectionString = "Host = localhost;Username = postgres;Password = admin;Port = 5432;Database = postgres;";
        private readonly IAuth _view;
        public AuthorizationPresenter(IAuth view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.LoginAttempt += this.LoginAttempt;
        }
        public void LoginAttempt(object sender, EventArgs e)
        {
            List<string> loginPass = _view.GetLoginPassword();
            try
            {
                if (loginPass[0] == "")
                {
                    throw new ArgumentNullException("Поле 'Имя пользователя' пустое!");
                }
                if (loginPass[1] == "")
                {
                    throw new ArgumentNullException("Поле 'Пароль' пустое!");
                }
                string checkQuery = "SELECT count(*) FROM tbUsers";
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var checkCommand = new NpgsqlCommand(checkQuery, connection))
                    {
                        long userCount = (long) checkCommand.ExecuteScalar();
                        if (userCount == 0)
                        {
                            //регистрация
                            _view.Message("Попытка регистрации успешна!");
                        }
                        else
                        {
                            string query = "SELECT username, password_hash FROM tbUsers WHERE username = @Username";
                            using (var command = new NpgsqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("Username", loginPass[0]);
                                using (var reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        var user = new User
                                        {
                                            Username = reader.GetString(0),
                                            PasswordHash = reader.GetString(1),
                                            Role = reader.GetString(2)
                                        };
                                        if (VerifyPassword(loginPass[1], user.PasswordHash))
                                        {
                                            _view.Message($"Попытка авторизации успешна! Роль: {user.Role}");
                                        }
                                        else
                                        {
                                            throw new UnauthorizedAccessException("Неправильный пароль! Доступ запрещён!");
                                        }
                                    }
                                    else
                                    {
                                        throw new UnauthorizedAccessException("Данное имя пользователя не зарегистрировано!");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                _view.Message("Ошибка! " + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                _view.Message("Ошибка! " + ex.Message);
            }
            catch (Exception ex)
            {
                _view.Message("Непредвиденная ошибка! \n" + ex.Message);
            }
        }
        public static bool VerifyPassword(string unknownPassword, string knownPasswordHash)
        {
            string unknownPasswordHash = User.HashPassword(unknownPassword);
            if (unknownPasswordHash != knownPasswordHash)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
