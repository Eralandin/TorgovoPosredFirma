using Employees.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorgovoPosredFirma.Logic.Presenters;
using TorgovoPosredFirma.Model.Classes;
using TorgovoPosredFirma.View.Interfaces;

namespace TorgovoPosredFirma.View.Forms
{
    public partial class MainForm : Form, IMain
    {
        private readonly MainPresenter _presenter;
        private string _connectionString;
        public MainForm(User user)
        {
            InitializeComponent();
            _presenter = new MainPresenter(this, user);
            if (user.Role == "Администратор")
            {
                fullGrant?.Invoke(this, new EventArgs());
            }
            else
            {
                userAccessGrant?.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler fullGrant;
        public event EventHandler userAccessGrant;
        public event EventHandler GetConnectionString;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            YesNoForm yesNoForm = new YesNoForm("Вы уверены, что хотите закрыть это окно?");
            if (yesNoForm.ShowDialog() == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        public void SendConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Message(string message)
        {
            MessageForm messageForm = new MessageForm(message);
            messageForm.ShowDialog();
        }
        public bool YesNoForm(string message)
        {
            YesNoForm yesNoForm = new YesNoForm(message);
            if (yesNoForm.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void BuildMenu(List<TorgovoPosredFirma.Model.Classes.Module> modules)
        {
            var menuItems = new Dictionary<long, ToolStripMenuItem>();
            foreach (var module in modules)
            {
                var menuItem = new ToolStripMenuItem(module.MenuItemName);
                menuItem.Tag = module;

                if (module.DllName != null && module.FunctionName != null)
                {
                    menuItem.Click += (s, e) =>
                    {
                        // функция или dll
                        try
                        {
                            string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, module.DllName);
                            var assembly = Assembly.LoadFrom(dllPath);

                            var type = assembly.GetTypes().FirstOrDefault(t => t.GetMethod(module.FunctionName) != null);
                            if (type != null)
                            {
                                GetConnectionString?.Invoke(this, EventArgs.Empty);
                                var instance = Activator.CreateInstance(type, new object[] {_connectionString});
                                var method = type.GetMethod(module.FunctionName);
                                if (method != null)
                                {
                                    var result = method.Invoke(instance, null);

                                    if (result is List<Employees.Models.User> users)
                                    {
                                        var dataTable = DataTableAdapter.DataTableAdaptUsers(users);
                                        ShowDataInGrid(dataTable);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Метод выполнен, но данные не возвращены.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"Метод {module.FunctionName} не найден в классе UserService.");
                                }
                            }
                            else
                            {
                                throw new Exception($"Класс {module.FunctionName} не найден в DLL {module.DllName}.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Message("Ошибка вызова функции: " + ex.ToString());
                        }
                    };
                }
                menuItems[module.Id] = menuItem;
                if (module.IdParent == 0) // высшая иерархия элемент
                {
                    menuItem.ForeColor = Color.White;
                    MainMenu.Items.Add(menuItem);
                }
                else if (menuItems.TryGetValue(module.IdParent, out var parentMenuItem))
                {
                    parentMenuItem.DropDownItems.Add(menuItem);
                }
            }
        }
        private void ShowDataInGrid(DataTable dataTable)
        {
            MainDGV.DataSource = dataTable;
            MainDGV.Refresh();
        }
        public void BuildMenu(List<TorgovoPosredFirma.Model.Classes.Module> modules, User user)
        {
            var menuItems = new Dictionary<long, ToolStripMenuItem>();
            foreach (var module in modules)
            {
                if (!module.AllowRead)
                {
                    continue;
                }
                var menuItem = new ToolStripMenuItem(module.MenuItemName);
                menuItem.Tag = module;

                if (module.DllName != null && module.FunctionName != null)
                {
                    menuItem.Click += (s, e) =>
                    {
                        // функция или dll
                        Message($"Попытка вызова: {module.FunctionName} in {module.DllName}");
                    };
                }
                menuItems[module.Id] = menuItem;

                if (module.IdParent == 0) // высшая иерархия элемент
                {
                    menuItem.ForeColor = Color.White;
                    MainMenu.Items.Add(menuItem);
                }
                else if (menuItems.TryGetValue(module.IdParent, out var parentMenuItem))
                {
                    parentMenuItem.DropDownItems.Add(menuItem);
                }
            }
        }
    }
}
