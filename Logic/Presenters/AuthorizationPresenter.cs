using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorgovoPosredFirma.View.Interfaces;
using Npgsql;

namespace TorgovoPosredFirma.Logic.Presenters
{
    public class AuthorizationPresenter
    {
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
                else if (loginPass[1] == "")
                {
                    throw new ArgumentNullException("Поле 'Пароль' пустое!");
                }
                string _con = "Host = localhost;Port = 5432;Username = " + loginPass[0] + ";Password = " + loginPass[1] + "; Database = postgres;";
                var con = new NpgsqlConnection(_con);
                con.Open();
                var cm = new NpgsqlCommand("SELECT * FROM tbProducts", con);
                var reader = cm.ExecuteReader();
                string testtext = "";
                while (reader.Read())
                {
                    testtext += reader.GetString(1) + "\n";
                }
                _view.Message(testtext);
                con.Close();
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
    }
}
