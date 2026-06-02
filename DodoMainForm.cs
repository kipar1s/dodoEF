using dodoEF.ClientForm;
using dodoEF.EnumForm;
using dodoEF.MyEF.Entities;
using dodoEF.OderForm;
using dodoEF.PersonalForm;
using dodoEF.TovarForm;
namespace dodoEF
{
    public partial class DodoMainForm : Form
    {
        dodoEF.MyEF.Entities.ApplicationDbContext db;
        private User currentUser;

        public DodoMainForm(User user)
        {
            InitializeComponent();
            db = new dodoEF.MyEF.Entities.ApplicationDbContext();
            currentUser = user;
            
            // Отображаем информацию о текущем пользователе
            this.Text = $"Додо Пицца - {currentUser.FullName} ({currentUser.Role})";
            
            // Убеждаемся что меню видимо
            menuStrip1.Visible = true;
            
            // Настраиваем интерфейс в зависимости от прав пользователя после загрузки формы
            this.Load += DodoMainForm_Load;
        }

        private void DodoMainForm_Load(object? sender, EventArgs e)
        {
            ConfigureAccessRights();
            
            // Принудительно показываем оба меню для отладки
            справочникToolStripMenuItem.Visible = true;
            перечисленияToolStripMenuItem.Visible = true;
            
            // Отладочная информация
            var permissions = AccessControl.GetPermissions(currentUser.Role);
            string permissionsList = string.Join(", ", permissions);
            
            MessageBox.Show($"Роль из БД: '{currentUser.Role}'\nКоличество прав: {permissions.Count}\n\nСправочник Visible: {справочникToolStripMenuItem.Visible}\nПеречисления Visible: {перечисленияToolStripMenuItem.Visible}\n\nСотрудники: {сотрудникиToolStripMenuItem.Visible}\nЗаказ: {заказToolStripMenuItem.Visible}\nКлиент: {клиентToolStripMenuItem.Visible}\nТовар: {товарToolStripMenuItem.Visible}", "Отладка меню");
        }

        private void ConfigureAccessRights()
        {
            // Получаем права доступа для текущей роли
            var permissions = AccessControl.GetPermissions(currentUser.Role);

            // Настраиваем видимость пунктов меню
            сотрудникиToolStripMenuItem.Visible = permissions.Contains("PersonalListForm");
            заказToolStripMenuItem.Visible = permissions.Contains("OderListForm");
            клиентToolStripMenuItem.Visible = permissions.Contains("ClientListForm");
            товарToolStripMenuItem.Visible = permissions.Contains("TovarListForm");
            
            категорииToolStripMenuItem.Visible = permissions.Contains("CategoriEnumForm");
            оцениваемостьToolStripMenuItem.Visible = permissions.Contains("EvelobEnumForm");
            ингридиентыToolStripMenuItem.Visible = permissions.Contains("IngrEnumForm");
            платежToolStripMenuItem.Visible = permissions.Contains("PlategEnumForm");

            // ВСЕГДА показываем родительские меню, если есть хотя бы один видимый подпункт
            bool hasVisibleSpravo = сотрудникиToolStripMenuItem.Visible || 
                                     заказToolStripMenuItem.Visible || 
                                     клиентToolStripMenuItem.Visible || 
                                     товарToolStripMenuItem.Visible;
                                     
            bool hasVisiblePerech = категорииToolStripMenuItem.Visible || 
                                     оцениваемостьToolStripMenuItem.Visible || 
                                     ингридиентыToolStripMenuItem.Visible || 
                                     платежToolStripMenuItem.Visible;

            справочникToolStripMenuItem.Visible = hasVisibleSpravo;
            перечисленияToolStripMenuItem.Visible = hasVisiblePerech;
            
            // Принудительно обновляем меню
            menuStrip1.Refresh();
            this.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccessControl.HasAccess(currentUser.Role, "PersonalListForm"))
            {
                PersonalListForm personal_list_form = new PersonalListForm();
                personal_list_form.MdiParent = this;
                personal_list_form.Show();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этой форме!", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccessControl.HasAccess(currentUser.Role, "OderListForm"))
            {
                OderListForm oder_list_form = new OderListForm();
                oder_list_form.MdiParent = this;
                oder_list_form.Show();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этой форме!", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void проверкаБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeedDatabase(db);
        }

        public static void SeedDatabase(ApplicationDbContext db)
        {
            // Очищаем таблицы в порядке обратном зависимостям (чтобы не нарушить внешние ключи)
            db.PersonalEvelobilitile.RemoveRange(db.PersonalEvelobilitile);
            db.OrderTovars.RemoveRange(db.OrderTovars);
            db.TovarIngrs.RemoveRange(db.TovarIngrs);
            db.Oder.RemoveRange(db.Oder);
            db.DbPersonal.RemoveRange(db.DbPersonal);
            db.Tovar.RemoveRange(db.Tovar);
            db.Ingr.RemoveRange(db.Ingr);
            db.Evelobilitile.RemoveRange(db.Evelobilitile);
            db.Categori.RemoveRange(db.Categori);
            db.Plateg.RemoveRange(db.Plateg);
            db.Client.RemoveRange(db.Client);
            db.SaveChanges();

            // 1. Client
            var clients = new List<Client>
    {
        new Client { FullName = "Иванов Иван Иванович", Telefon = 1112233, Adress_C = "г. Москва, ул. Ленина, д.1", Login = "ivanov_ii", Password = "pass123" },
        new Client { FullName = "Петрова Анна Сергеевна", Telefon = 2223344, Adress_C = "г. Москва, ул. Пушкина, д.5", Login = "petrova_as", Password = "qwerty" },
        new Client { FullName = "Сидоров Алексей Петрович", Telefon = 3334455, Adress_C = "г. Москва, пр. Мира, д.10", Login = "sidorov_ap", Password = "123456" },
        new Client { FullName = "Кузнецова Елена Владимировна", Telefon = 4445566, Adress_C = "г. Москва, ул. Садовая, д.8", Login = "kuznetsova_ev", Password = "pass456" },
        new Client { FullName = "Михайлов Дмитрий Олегович", Telefon = 5556677, Adress_C = "г. Москва, ул. Тверская, д.15", Login = "mikhailov_do", Password = "password" }
    };
            db.Client.AddRange(clients);
            db.SaveChanges();
            // Сохраняем Id клиентов
            var clientIds = clients.Select(c => c.Id).ToList(); // Id будут 1,2,3,4,5

            // 2. Plateg
            var plategs = new List<Plateg>
    {
        new Plateg { Sposob_PL = "Наличные", Status_PL = "Оплачен" },
        new Plateg { Sposob_PL = "Карта", Status_PL = "Оплачен" },
        new Plateg { Sposob_PL = "Онлайн", Status_PL = "В обработке" },
        new Plateg { Sposob_PL = "Наличные", Status_PL = "Отменён" },
        new Plateg { Sposob_PL = "Карта", Status_PL = "Отменён" },
        new Plateg { Sposob_PL = "Онлайн", Status_PL = "Оплачен" }
    };
            db.Plateg.AddRange(plategs);
            db.SaveChanges();
            var plategIds = plategs.Select(p => p.Id).ToList(); // 1..6

            // 3. Categori
            var categoris = new List<Categori>
    {
        new Categori { Tatle = "Повар" },
        new Categori { Tatle = "Курьер" },
        new Categori { Tatle = "Администратор" },
        new Categori { Tatle = "Управляющий" }
    };
            db.Categori.AddRange(categoris);
            db.SaveChanges();
            var categoriIds = categoris.Select(c => c.Id).ToList(); // 1..4

            // 4. Evelobilitile (исправленная структура)
            var evelobilitiles = new List<Evelobilitile>
    {
        new Evelobilitile { Pizziria = 1, FullName_P = "Пиццерия №1", Reit_K_D = 5, Enum_Oder = "Доставлено", Enum_Evel = "Высокий", Procent = "10%" },
        new Evelobilitile { Pizziria = 1, FullName_P = "Пиццерия №1", Reit_K_D = 4, Enum_Oder = "В обработке", Enum_Evel = "Средний", Procent = "7%" },
        new Evelobilitile { Pizziria = 2, FullName_P = "Пиццерия №2", Reit_K_D = 5, Enum_Oder = "Доставлено", Enum_Evel = "Высокий", Procent = "12%" },
        new Evelobilitile { Pizziria = 2, FullName_P = "Пиццерия №2", Reit_K_D = 3, Enum_Oder = "Отменен", Enum_Evel = "Низкий", Procent = "5%" },
        new Evelobilitile { Pizziria = 3, FullName_P = "Пиццерия №3", Reit_K_D = 4, Enum_Oder = "Доставлено", Enum_Evel = "Средний", Procent = "8%" },
        new Evelobilitile { Pizziria = 3, FullName_P = "Пиццерия №3", Reit_K_D = 5, Enum_Oder = "В обработке", Enum_Evel = "Высокий", Procent = "11%" }
    };
            db.Evelobilitile.AddRange(evelobilitiles);
            db.SaveChanges();
            var evelobilitileIds = evelobilitiles.Select(e => e.Id).ToList(); // 1..6

            // 5. Tovar
            var tovars = new List<Tovar>
    {
        new Tovar { FullName = "Пепперони фреш", Price = 259, Catifori_T = "Пицца", Callory = 870 },
        new Tovar { FullName = "Гавайская", Price = 279, Catifori_T = "Пицца", Callory = 740 },
        new Tovar { FullName = "Четыре сыра", Price = 299, Catifori_T = "Пицца", Callory = 950 },
        new Tovar { FullName = "Карбонара", Price = 289, Catifori_T = "Пицца", Callory = 890 },
        new Tovar { FullName = "Цезарь с курицей", Price = 219, Catifori_T = "Салат", Callory = 430 },
        new Tovar { FullName = "Картофель фри", Price = 89, Catifori_T = "Гарнир", Callory = 310 }
    };
            db.Tovar.AddRange(tovars);
            db.SaveChanges();
            var tovarIds = tovars.Select(t => t.Id).ToList(); // 1..6

            // 6. Ingr
            var ingrs = new List<Ingr>
    {
        new Ingr { FullName = "Тесто", Cost = 20, date = new DateTime(2025, 6, 1), Quantity = 100 },
        new Ingr { FullName = "Сыр моцарелла", Cost = 50, date = new DateTime(2025, 6, 1), Quantity = 50 },
        new Ingr { FullName = "Пепперони", Cost = 70, date = new DateTime(2025, 6, 1), Quantity = 30 },
        new Ingr { FullName = "Курица", Cost = 60, date = new DateTime(2025, 6, 1), Quantity = 40 },
        new Ingr { FullName = "Ананас", Cost = 40, date = new DateTime(2025, 6, 1), Quantity = 20 },
        new Ingr { FullName = "Соус томатный", Cost = 10, date = new DateTime(2025, 6, 1), Quantity = 80 }
    };
            db.Ingr.AddRange(ingrs);
            db.SaveChanges();
            var ingrIds = ingrs.Select(i => i.Id).ToList(); // 1..6

            // 7. Personal (сотрудники)
            var personals = new List<Personal>
    {
        new Personal { FullName = "Орлов Александр", Stage = 2, Login = "orlov_a", Password = "pass1", categoriId = categoriIds[0] }, // 1
        new Personal { FullName = "Смирнова Мария", Stage = 1, Login = "smirnova_m", Password = "pass2", categoriId = categoriIds[0] }, // 1
        new Personal { FullName = "Козлов Сергей", Stage = 3, Login = "kozlov_s", Password = "pass3", categoriId = categoriIds[1] }, // 2
        new Personal { FullName = "Новикова Ольга", Stage = 0, Login = "novikova_o", Password = "pass4", categoriId = categoriIds[2] }, // 3
        new Personal { FullName = "Морозов Илья", Stage = 5, Login = "morozov_i", Password = "pass5", categoriId = categoriIds[3] } // 4
    };
            db.DbPersonal.AddRange(personals);
            db.SaveChanges();
            var personalIds = personals.Select(p => p.Id).ToList(); // 1..5

            // 8. TovarIngrs (связи товаров и ингредиентов)
            var tovarIngrs = new List<TovarIngr>
    {
        // Пепперони фреш (TovarId = tovarIds[0] -> 1)
        new TovarIngr { TovarId = tovarIds[0], IngrId = ingrIds[0], Quantity = 1 }, // Тесто
        new TovarIngr { TovarId = tovarIds[0], IngrId = ingrIds[1], Quantity = 2 }, // Сыр
        new TovarIngr { TovarId = tovarIds[0], IngrId = ingrIds[2], Quantity = 3 }, // Пепперони
        new TovarIngr { TovarId = tovarIds[0], IngrId = ingrIds[5], Quantity = 1 }, // Соус
        // Гавайская (TovarId = tovarIds[1])
        new TovarIngr { TovarId = tovarIds[1], IngrId = ingrIds[0], Quantity = 1 },
        new TovarIngr { TovarId = tovarIds[1], IngrId = ingrIds[1], Quantity = 2 },
        new TovarIngr { TovarId = tovarIds[1], IngrId = ingrIds[4], Quantity = 2 }, // Ананас
        new TovarIngr { TovarId = tovarIds[1], IngrId = ingrIds[5], Quantity = 1 },
        // Четыре сыра (TovarId = tovarIds[2])
        new TovarIngr { TovarId = tovarIds[2], IngrId = ingrIds[0], Quantity = 1 },
        new TovarIngr { TovarId = tovarIds[2], IngrId = ingrIds[1], Quantity = 3 },
        new TovarIngr { TovarId = tovarIds[2], IngrId = ingrIds[5], Quantity = 1 },
        // Карбонара (TovarId = tovarIds[3])
        new TovarIngr { TovarId = tovarIds[3], IngrId = ingrIds[0], Quantity = 1 },
        new TovarIngr { TovarId = tovarIds[3], IngrId = ingrIds[1], Quantity = 2 },
        new TovarIngr { TovarId = tovarIds[3], IngrId = ingrIds[3], Quantity = 2 }, // Курица
        new TovarIngr { TovarId = tovarIds[3], IngrId = ingrIds[5], Quantity = 1 },
        // Цезарь с курицей (TovarId = tovarIds[4])
        new TovarIngr { TovarId = tovarIds[4], IngrId = ingrIds[3], Quantity = 2 },
        new TovarIngr { TovarId = tovarIds[4], IngrId = ingrIds[1], Quantity = 1 }
    };
            db.TovarIngrs.AddRange(tovarIngrs);
            db.SaveChanges();

            // 9. Oder (используем сохранённые Id клиентов, платежей, сотрудников)
            var oders = new List<Oder>
    {
        new Oder { clientId = clientIds[0], date = new DateTime(2026, 5, 31, 12, 30, 0), Summa = 500, Status = "Доставлено", Adress_d = "г. Москва, ул. Ленина, д.1", plategid = plategIds[0], personalId = personalIds[2] }, // 1 и 3
        new Oder { clientId = clientIds[1], date = new DateTime(2026, 5, 31, 13, 15, 0), Summa = 540, Status = "Отменен", Adress_d = "г. Москва, ул. Пушкина, д.5", plategid = plategIds[3], personalId = personalIds[2] },
        new Oder { clientId = clientIds[2], date = new DateTime(2026, 5, 31, 14, 0, 0), Summa = 300, Status = "Доставлено", Adress_d = "г. Москва, пр. Мира, д.10", plategid = plategIds[1], personalId = personalIds[1] },
        new Oder { clientId = clientIds[3], date = new DateTime(2026, 5, 31, 15, 20, 0), Summa = 200, Status = "Доставлено", Adress_d = "г. Москва, ул. Садовая, д.8", plategid = plategIds[5], personalId = personalIds[0] },
        new Oder { clientId = clientIds[4], date = new DateTime(2026, 5, 31, 16, 45, 0), Summa = 400, Status = "В обработке", Adress_d = "г. Москва, ул. Тверская, д.15", plategid = plategIds[2], personalId = personalIds[3] }
    };
            db.Oder.AddRange(oders);
            db.SaveChanges();
            var oderIds = oders.Select(o => o.Id).ToList(); // 1..5

            // 10. OrderTovars (используем OderId и TovarId)
            var orderTovars = new List<OderTovar>
    {
        new OderTovar { OderId = oderIds[0], TovarId = tovarIds[0], Quantity = 1 },
        new OderTovar { OderId = oderIds[0], TovarId = tovarIds[5], Quantity = 2 },
        new OderTovar { OderId = oderIds[1], TovarId = tovarIds[1], Quantity = 1 },
        new OderTovar { OderId = oderIds[1], TovarId = tovarIds[4], Quantity = 1 },
        new OderTovar { OderId = oderIds[2], TovarId = tovarIds[2], Quantity = 1 },
        new OderTovar { OderId = oderIds[3], TovarId = tovarIds[4], Quantity = 1 },
        new OderTovar { OderId = oderIds[3], TovarId = tovarIds[5], Quantity = 1 },
        new OderTovar { OderId = oderIds[4], TovarId = tovarIds[3], Quantity = 1 },
        new OderTovar { OderId = oderIds[4], TovarId = tovarIds[5], Quantity = 1 }
    };
            db.OrderTovars.AddRange(orderTovars);
            db.SaveChanges();

            // 11. PersonalEvelobilitile
            var personalEvelobilitiles = new List<PersonalEvelobilitile>
    {
        new PersonalEvelobilitile { PersonalId = personalIds[0], EvelobilitileId = evelobilitileIds[1] }, // Орлов - Средний (Id=2)
        new PersonalEvelobilitile { PersonalId = personalIds[0], EvelobilitileId = evelobilitileIds[2] }, // Орлов - Высокий (Id=3)
        new PersonalEvelobilitile { PersonalId = personalIds[1], EvelobilitileId = evelobilitileIds[0] }, // Смирнова - Стажер (Id=1)
        new PersonalEvelobilitile { PersonalId = personalIds[2], EvelobilitileId = evelobilitileIds[2] }, // Козлов - Высокий
        new PersonalEvelobilitile { PersonalId = personalIds[3], EvelobilitileId = evelobilitileIds[0] }, // Новикова - Стажер
        new PersonalEvelobilitile { PersonalId = personalIds[4], EvelobilitileId = evelobilitileIds[4] }  // Морозов - Ведущий (Id=5)
    };
            db.PersonalEvelobilitile.AddRange(personalEvelobilitiles);
            db.SaveChanges();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccessControl.HasAccess(currentUser.Role, "ClientListForm"))
            {
                ClientListForm client_list_form = new ClientListForm();
                client_list_form.MdiParent = this;
                client_list_form.Show();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этой форме!", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void категорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccessControl.HasAccess(currentUser.Role, "CategoriEnumForm"))
            {
                CategoriEnumForm categori_list_form = new CategoriEnumForm();
                categori_list_form.MdiParent = this;
                categori_list_form.Show();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этой форме!", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void оцениваемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccessControl.HasAccess(currentUser.Role, "EvelobEnumForm"))
            {
                EvelobEnumForm evelob_enum_form = new EvelobEnumForm();
                evelob_enum_form.MdiParent = this;
                evelob_enum_form.Show();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этой форме!", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ингридиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccessControl.HasAccess(currentUser.Role, "IngrEnumForm"))
            {
                IngrEnumForm ingr_enum_form = new IngrEnumForm();
                ingr_enum_form.MdiParent = this;
                ingr_enum_form.Show();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этой форме!", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void платежToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccessControl.HasAccess(currentUser.Role, "PlategEnumForm"))
            {
                PlategEnumForm plateg_enum_form = new PlategEnumForm();
                plateg_enum_form.MdiParent = this;
                plateg_enum_form.Show();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этой форме!", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccessControl.HasAccess(currentUser.Role, "TovarListForm"))
            {
                TovarListForm tovar_list_form = new TovarListForm();
                tovar_list_form.MdiParent = this;
                tovar_list_form.Show();
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этой форме!", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}