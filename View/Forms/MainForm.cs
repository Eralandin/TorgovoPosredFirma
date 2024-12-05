using SharedModels;
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
using TorgovoPosredFirma.Model.DataHelpers;
using TorgovoPosredFirma.View.Interfaces;

namespace TorgovoPosredFirma.View.Forms
{
    public partial class MainForm : Form, IMain
    {
        private readonly MainPresenter _presenter;
        private string _connectionString;
        private string _currentDll;
        public string CurrentDll
        {
            get => _currentDll;
            private set => _currentDll = value;
        }
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
        public event EventHandler<string> AddClick;
        public event EventHandler<string> UpdateClick;
        public event EventHandler<string> DeleteClick;

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
        public void BuildMenu(List<SharedModels.Module> modules)
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
                            _currentDll = module.DllName;
                            string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, module.DllName);
                            var assembly = Assembly.LoadFrom(dllPath);

                            var type = assembly.GetTypes().FirstOrDefault(t => t.GetMethod(module.FunctionName) != null);
                            if (type != null)
                            {
                                GetConnectionString?.Invoke(this, EventArgs.Empty);
                                var instance = Activator.CreateInstance(type, new object[] { _connectionString });
                                var method = type.GetMethod(module.FunctionName);
                                if (method != null)
                                {
                                    var result = method.Invoke(instance, null);
                                    if (result != null)
                                    {
                                        var dataTable = DataTableAdapter.AdaptToDataTable(result as IEnumerable<object>);
                                        ShowDataInGrid(dataTable);
                                    }
                                    else
                                    {
                                        throw new Exception("Метод сработал, однако данные не были возвращены.");
                                    }
                                }
                                else
                                {
                                    throw new Exception($"Метод {module.FunctionName} не найден в классе UserService.");
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
            MainDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            MainDGV.AutoSize = true;
            MainDGV.DataSource = dataTable;
            MainDGV.Refresh();
        }
        public void BuildMenu(List<SharedModels.Module> modules, User user)
        {
            var menuItems = new Dictionary<long, ToolStripMenuItem>();
            foreach (var module in modules)
            {
                var menuItem = new ToolStripMenuItem(module.MenuItemName);
                menuItem.Tag = module;

                if (!module.AllowRead)
                {
                    continue;
                }

                if (module.DllName != null && module.FunctionName != null)
                {
                    menuItem.Click += (s, e) =>
                    {
                        // функция или dll
                        try
                        {
                            _currentDll = module.DllName;
                            string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, module.DllName);
                            var assembly = Assembly.LoadFrom(dllPath);

                            var type = assembly.GetTypes().FirstOrDefault(t => t.GetMethod(module.FunctionName) != null);
                            if (type != null)
                            {
                                GetConnectionString?.Invoke(this, EventArgs.Empty);
                                var instance = Activator.CreateInstance(type, new object[] { _connectionString });
                                var method = type.GetMethod(module.FunctionName);
                                if (method != null)
                                {
                                    var result = method.Invoke(instance, null);
                                    if (result != null)
                                    {
                                        var dataTable = DataTableAdapter.AdaptToDataTable(result as IEnumerable<object>);
                                        ShowDataInGrid(dataTable);
                                    }
                                    else
                                    {
                                        throw new Exception("Метод сработал, однако данные не были возвращены.");
                                    }
                                }
                                else
                                {
                                    throw new Exception($"Метод {module.FunctionName} не найден в DLL {module.DllName}.");
                                }
                            }
                            else
                            {
                                throw new Exception($"Метод {module.FunctionName} не найден в DLL {module.DllName}.");
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
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentDll))
            {
                Message("Не выбран пункт меню для добавления записи.");
                return;
            }
            AddClick?.Invoke(this, _currentDll);
            MainDGV.Refresh();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentDll))
            {
                Message("Не выбран пункт меню для изменения записи.");
                return;
            }
            UpdateClick?.Invoke(this, _currentDll);
            MainDGV.Refresh();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentDll))
            {
                Message("Не выбран пункт меню для удаления записи.");
                return;
            }
            DeleteClick?.Invoke(this, _currentDll);
            MainDGV.Refresh();
        }
        public void OpenForm(string currentDll)
        {
            try
            {
                string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, currentDll);

                var assembly = Assembly.LoadFrom(dllPath);

                var formType = assembly.GetTypes().FirstOrDefault(t => t.IsSubclassOf(typeof(Form)));
                if (formType == null)
                {
                    throw new Exception($"В DLL {currentDll} не найден класс, унаследованный от Form.");
                }
                // экземпляр
                var formInstance = Activator.CreateInstance(formType);
                //закинули строку подключения
                if (formInstance is IConnectionStringConsumer consumer)
                {
                    consumer.SetConnectionString(_connectionString);
                }

                if (formInstance is Form form)
                {
                    form.ShowDialog(); 
                }
                else
                {
                    throw new Exception($"Класс {formType.Name} не является допустимой формой.");
                }
            }
            catch (Exception ex)
            {
                Message($"Ошибка открытия формы: {ex.Message}");
            }
        }
    }
}
