using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorgovoPosredFirma.View.Interfaces;

namespace TorgovoPosredFirma.Logic.Presenters
{
    public class RegistrationPresenter
    {
        string _connectionString = "Host = localhost;Username = postgres;Password = admin;Port = 5432;Database = postgres;";
        private readonly IRegister _view;

        public RegistrationPresenter(IRegister view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.RegistrationAttempt += this.RegistrationAttempt;
        }
        public void RegistrationAttempt(object sender, EventArgs e)
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
                if (loginPass[1].Length > 50)
                {
                    throw new ArgumentException("Пароль не может быть длиннее 50 символов!");
                }
                if (loginPass[2] != loginPass[1])
                {
                    throw new ArgumentException("Введённые пароли не совпадают!");
                }
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    User newUser = new User
                    {
                        Username = loginPass[0],
                        PasswordHash = loginPass[1],
                        Role = "Администратор",
                        IsAdmin = true
                    };
                    string hashedPass = User.HashPassword(newUser.PasswordHash);
                    string query = "INSERT INTO tbUsers (username,password_hash,user_role, isadmin) VALUES (@Username, @PasswordHash, @Role, @IsAdmin)";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("Username",newUser.Username);
                        command.Parameters.AddWithValue("PasswordHash", hashedPass);
                        command.Parameters.AddWithValue("Role",newUser.Role);
                        command.Parameters.AddWithValue("IsAdmin", newUser.IsAdmin);
                        command.ExecuteNonQuery();
                    }
                    _view.Message("Первичный пользователь успешно зарегистрирован, как администратор!");
                    _view.CloseForm();
                }
            }
            catch(Exception ex)
            {
                _view.Message("Непредвиденная ошибка! "+ex.Message);
            }
        }
    }
}
