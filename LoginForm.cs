using dodoEF.MyEF.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dodoEF
{
    public partial class LoginForm : Form
    {
        private ApplicationDbContext db;

        public LoginForm()
        {
            InitializeComponent();
            
            // Создаем таблицу Users если её нет
            try
            {
                DatabaseHelper.CreateUsersTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании таблицы Users: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            db = new ApplicationDbContext();
            
            // Создаем тестовых пользователей при первом запуске
            InitializeUsers();
        }

        private void InitializeUsers()
        {
            try
            {
                // Проверяем, есть ли уже пользователи
                var userCount = db.Users.Count();
                
                if (userCount == 0)
                {
                    var users = new[]
                    {
                        new User { Username = "admin", PasswordHash = User.HashPassword("admin"), Role = UserRoles.Admin, FullName = "Администратор", IsActive = true, CreatedAt = DateTime.Now },
                        new User { Username = "manager", PasswordHash = User.HashPassword("manager"), Role = UserRoles.Manager, FullName = "Управляющий", IsActive = true, CreatedAt = DateTime.Now },
                        new User { Username = "deputy", PasswordHash = User.HashPassword("deputy"), Role = UserRoles.DeputyManager, FullName = "Зам. Управляющего", IsActive = true, CreatedAt = DateTime.Now },
                        new User { Username = "sales", PasswordHash = User.HashPassword("sales"), Role = UserRoles.SalesManager, FullName = "Менеджер", IsActive = true, CreatedAt = DateTime.Now },
                        new User { Username = "kitchen", PasswordHash = User.HashPassword("kitchen"), Role = UserRoles.KitchenStaff, FullName = "Сотрудник Кухни", IsActive = true, CreatedAt = DateTime.Now },
                        new User { Username = "courier", PasswordHash = User.HashPassword("courier"), Role = UserRoles.Courier, FullName = "Курьер", IsActive = true, CreatedAt = DateTime.Now },
                        new User { Username = "intern", PasswordHash = User.HashPassword("intern"), Role = UserRoles.Intern, FullName = "Стажер", IsActive = true, CreatedAt = DateTime.Now }
                    };

                    db.Users.AddRange(users);
                    db.SaveChanges();
                    
                    MessageBox.Show($"Создано {users.Length} тестовых пользователей", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании пользователей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = db.Users.FirstOrDefault(u => u.Username == username && u.IsActive);

                if (user != null)
                {
                    if (user.VerifyPassword(password))
                    {
                        // Успешная аутентификация
                        this.DialogResult = DialogResult.OK;
                        
                        // Открываем главную форму с правами пользователя
                        DodoMainForm mainForm = new DodoMainForm(user);
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show($"Пользователь '{username}' не найден или неактивен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при входе: {ex.Message}\n\n{ex.StackTrace}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
