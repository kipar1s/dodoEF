using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using dodoEF.MyEF.Entities;

namespace dodoEF.OderForm
{
    public partial class OderFormUnit : Form
    {
        private bool is_edit = false;
        private ApplicationDbContext db;
        private Oder item;
        private int item_id = -1;

        // BindingSource для товаров заказа
        private BindingSource orderTovarBindingSource = new BindingSource();

        public OderFormUnit()
        {
            InitializeComponent();
            db = new ApplicationDbContext();

            // Привязка комбобокса статуса – теперь без BindingSource, будем управлять вручную
            // Удаляем старую привязку, если она была добавлена в дизайнере или ранее
            cB_Status.DataBindings.Clear();

            // Навигатор для товаров (опционально)
            BindingNavigator navigator = new BindingNavigator(true);
            navigator.BindingSource = orderTovarBindingSource;
            this.groupBox1.Controls.Add(navigator);
        }

        public void EditItem(int item_id)
        {
            is_edit = true;
            this.item_id = item_id;
            // Загружаем заказ вместе с клиентом, платежом, а также связями OrderTovar и самими товарами
            this.item = db.Oder
                .Include(o => o.client)
                .Include(o => o.plategs)
                .Include(o => o.personal)
                .Include(o => o.OderTovars)
                    .ThenInclude(ot => ot.Tovar)
                .FirstOrDefault(o => o.Id == item_id);
        }

        private void OderFormUnit_Load(object sender, EventArgs e)
        {
            // Заполняем комбобокс статусов
            var statuses = new List<string> { "Доставлено", "Отменен" };
            cB_Status.DataSource = statuses;

            if (is_edit && item != null)
            {
                // Режим редактирования существующего заказа
                cB_Status.SelectedItem = item.Status;

                // Заполняем поля данными клиента
                if (item.client != null)
                {
                    textBox1.Text = item.client.Id.ToString();          // Id клиента
                    textBox2.Text = item.client.FullName;          // Ник клиента
                    textBox3.Text = item.client.Telefon.ToString(); // Телефон
                    textBox6.Text = item.client.Adress_C;          // Адрес клиента
                }
                // Дата заказа
                textBox4.Text = item.date.ToShortDateString();

                // Привязываем товары
                orderTovarBindingSource.DataSource = item.OderTovars;
                dataGridView1.DataSource = orderTovarBindingSource;
                ConfigureTovarGrid();
            }
            else
            {
                // Режим создания нового заказа
                cB_Status.SelectedIndex = 0; // значение по умолчанию

                OderSelectionDialog dialog = new OderSelectionDialog();
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    Close();
                    return;
                }

                Client selectedClient = dialog.selected_client;

                item = new Oder
                {
                    client = selectedClient,
                    clientId = selectedClient.Id,
                    Status = "Доставлено",
                    date = DateTime.Now,
                    OderTovars = new List<OderTovar>()
                };

                // Заполняем текстовые поля из выбранного клиента
                textBox1.Text = item.client.Id.ToString();          // Id клиента
                textBox2.Text = item.client.FullName;          // Ник клиента
                textBox3.Text = item.client.Telefon.ToString(); // Телефон
                textBox6.Text = item.client.Adress_C;          // Адрес клиента
                // Устанавливаем текущую дату
                textBox4.Text = DateTime.Now.ToShortDateString();

                cB_Status.SelectedItem = item.Status;
                orderTovarBindingSource.DataSource = item.OderTovars;
                dataGridView1.DataSource = orderTovarBindingSource;
                ConfigureTovarGrid();
            }
        }

        // Настраиваем отображение колонок DataGridView для OrderTovar
        private void ConfigureTovarGrid()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                DataGridViewTextBoxColumn tovarNameCol = new DataGridViewTextBoxColumn
                {
                    Name = "TovarName",
                    HeaderText = "Товар",
                    DataPropertyName = "Tovar.FullName",
                    ReadOnly = true
                };
                DataGridViewTextBoxColumn quantityCol = new DataGridViewTextBoxColumn
                {
                    Name = "Quantity",
                    HeaderText = "Количество",
                    DataPropertyName = "Quantity"
                };
                dataGridView1.Columns.Add(tovarNameCol);
                dataGridView1.Columns.Add(quantityCol);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            // Завершаем редактирование привязки товаров
            orderTovarBindingSource.EndEdit();

            // Обновляем статус из комбобокса
            if (cB_Status.SelectedItem != null)
                item.Status = cB_Status.SelectedItem.ToString();

            if (string.IsNullOrEmpty(item.Status))
            {
                MessageBox.Show("Выберите статус заказа");
                return;
            }

            // Обновляем клиента из текстовых полей (если пользователь их менял)
            if (item.client != null)
            {
                item.client.FullName = textBox1.Text;
                if (int.TryParse(textBox2.Text, out int telefon))
                    item.client.Telefon = telefon;
                item.client.Adress_C = textBox6.Text;
            }

            // Обновляем дату заказа, если пользователь её изменил
            if (DateTime.TryParse(textBox4.Text, out DateTime newDate))
                item.date = newDate;

            // Сохраняем заказ
            if (!is_edit)
                db.Oder.Add(item);
            else
                db.Oder.Update(item);

            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }
    }
}