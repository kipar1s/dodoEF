using dodoEF.MyEF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dodoEF.OderForm
{
    public partial class OderFormUnit : Form
    {
        private bool is_edit = false;
        private ApplicationDbContext db;
        private Oder item;
        private int item_id = -1;
        

        private readonly string[] sposoby = { "Наличные", "Картой", "Онлайн", "Сертификат" };
        private readonly string[] statusy = { "Оплачено", "Отменено", "В процессе" };

        public OderFormUnit()
        {
            InitializeComponent();
            db = new ApplicationDbContext();
            cB_Status.DataBindings.Clear();
            SetupListViews();
        }

        // ===== НАСТРОЙКА ListView с CheckBoxes =====
        private void SetupListViews()
        {
            // Способы оплаты
            listViewSposob.View = View.Details;
            listViewSposob.CheckBoxes = true;
            listViewSposob.Columns.Add("Способ оплаты", 150);
            listViewSposob.FullRowSelect = true;
            listViewSposob.MultiSelect = false;

            foreach (var s in sposoby)
                listViewSposob.Items.Add(new ListViewItem(s));

            // Статусы
            listViewStatus.View = View.Details;
            listViewStatus.CheckBoxes = true;
            listViewStatus.Columns.Add("Статус платежа", 150);
            listViewStatus.FullRowSelect = true;
            listViewStatus.MultiSelect = false;

            foreach (var s in statusy)
                listViewStatus.Items.Add(new ListViewItem(s));
        }

        public void EditItem(int item_id)
        {
            is_edit = true;
            this.item_id = item_id;
            this.item = db.Oder
                .Include(o => o.client)
                .Include(o => o.plategs)
                .Include(o => o.OderTovars)
                    .ThenInclude(ot => ot.Tovar)
                .FirstOrDefault(o => o.Id == item_id);
        }

        private void OderFormUnit_Load(object sender, EventArgs e)
        {
            var statuses = new List<string> { "Доставлено", "Отменен" };
            cB_Status.DataSource = statuses;

            if (is_edit && item != null)
            {
                // Режим редактирования
                cB_Status.SelectedItem = item.Status;

                if (item.client != null)
                {
                    textBox1.Text = item.client.Id.ToString();
                    textBox2.Text = item.client.FullName;
                    textBox3.Text = item.client.Telefon.ToString();
                    textBox6.Text = item.client.Adress_C;
                }
                textBox4.Text = item.date.ToShortDateString();

                // Устанавливаем галочки по данным из БД
                SetCheckBox(listViewSposob, item.plategs?.Sposob_PL ?? "Наличные");
                SetCheckBox(listViewStatus, item.plategs?.Status_PL ?? "В процессе");

                // Загружаем оба грида товаров
                LoadOrderTovars();
                LoadAllTovars();
            }
            else
            {
                // Режим создания
                cB_Status.SelectedIndex = 0;

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

                textBox1.Text = item.client.Id.ToString();
                textBox2.Text = item.client.FullName;
                textBox3.Text = item.client.Telefon.ToString();
                textBox5.Text = item.Summa.ToString();
                textBox6.Text = item.client.Adress_C;
                textBox4.Text = DateTime.Now.ToShortDateString();

                // По умолчанию: Наличные + В процессе
                SetCheckBox(listViewSposob, "Наличные");
                SetCheckBox(listViewStatus, "В процессе");

                cB_Status.SelectedItem = item.Status;
                LoadOrderTovars();
                LoadAllTovars();
            }
        }

        // ===== ГРИД 1: Товары в заказе =====
        private void LoadOrderTovars()
        {
            // Создаём список для отображения с данными товара
            var displayList = item.OderTovars.Select(ot => new
            {
                TovarName = ot.Tovar?.FullName ?? "Товар #" + ot.TovarId,
                Quantity = ot.Quantity,
                Price = ot.Tovar?.Price ?? 0,
                Summa = (ot.Tovar?.Price ?? 0) * ot.Quantity
            }).ToList();

            tovarBindingSource.DataSource = displayList;
            dataGridViewTovat.DataSource = tovarBindingSource;
            ConfigureOrderTovarGrid();
        }
        private void LoadAllTovars()
        {
            var allTovars = db.Tovar.AsNoTracking().ToList();
            tovarBindingSource1.DataSource = allTovars;
            dataGridViewAllTovars.DataSource = tovarBindingSource1;
            ConfigureAllTovarsGrid();
        }
        // ===== НАСТРОЙКА ГРИДА: Товары в заказе =====
        private void ConfigureOrderTovarGrid()
        {
            if (dataGridViewTovat.Columns.Count == 0)
            {
                dataGridViewTovat.AutoGenerateColumns = false;
                dataGridViewTovat.Columns.Clear();

                dataGridViewTovat.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TovarName",
                    HeaderText = "Товар",
                    DataPropertyName = "TovarName",
                    ReadOnly = true,
                    Width = 200
                });

                dataGridViewTovat.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Quantity",
                    HeaderText = "Кол-во",
                    DataPropertyName = "Quantity",
                    Width = 80
                });

                dataGridViewTovat.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Price",
                    HeaderText = "Цена",
                    DataPropertyName = "Price",
                    ReadOnly = true,
                    Width = 80
                });

                dataGridViewTovat.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Summa",
                    HeaderText = "Сумма",
                    DataPropertyName = "Summa",
                    ReadOnly = true,
                    Width = 80
                });
            }
        }

        // ===== НАСТРОЙКА ГРИДА: Все товары =====
        private void ConfigureAllTovarsGrid()
        {
            if (dataGridViewAllTovars.Columns.Count == 0)
            {
                dataGridViewAllTovars.AutoGenerateColumns = false;
                dataGridViewAllTovars.Columns.Clear();

                dataGridViewTovat.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TovarId",
                    DataPropertyName = "TovarId",
                    Visible = false
                });

                dataGridViewAllTovars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Id",
                    HeaderText = "ID",
                    DataPropertyName = "Id",
                    ReadOnly = true,
                    Width = 50
                });

                dataGridViewAllTovars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "FullName",
                    HeaderText = "Название",
                    DataPropertyName = "FullName",
                    ReadOnly = true,
                    Width = 200
                });

                dataGridViewAllTovars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Price",
                    HeaderText = "Цена",
                    DataPropertyName = "Price",
                    ReadOnly = true,
                    Width = 80
                });

                dataGridViewAllTovars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Catifori_T",
                    HeaderText = "Категория",
                    DataPropertyName = "Catifori_T",
                    ReadOnly = true,
                    Width = 100
                });
            }
        }

        // ===== КНОПКА: ДОБАВИТЬ ТОВАР В ЗАКАЗ =====
        private void btnAddTovar_Click(object sender, EventArgs e)
        {
            // Останавливаем обработку, если что-то пойдёт не так
            try
            {
                if (dataGridViewAllTovars.CurrentRow == null)
                {
                    MessageBox.Show("Выберите товар!");
                    return;
                }

                int tovarId = Convert.ToInt32(dataGridViewAllTovars.CurrentRow.Cells[0].Value);

                // Проверяем, есть ли уже этот товар в заказе
                var existing = item.OderTovars.FirstOrDefault(ot => ot.TovarId == tovarId);
                if (existing != null)
                {
                    existing.Quantity++;
                }
                else
                {
                    // Загружаем товар из БД
                    var tovar = db.Tovar.AsNoTracking().FirstOrDefault(t => t.Id == tovarId);
                    if (tovar == null)
                    {
                        MessageBox.Show("Товар не найден в базе!");
                        return;
                    }

                    // Создаём OderTovar
                    var newOderTovar = new OderTovar
                    {
                        OderId = item.Id,
                        TovarId = tovarId,
                        Tovar = tovar,
                        Quantity = 1
                    };

                    item.OderTovars.Add(newOderTovar);
                }

                // Обновляем отображение
                RefreshOrderTovarsGrid();
                RecalculateSumma();
                textBox5.Text = item.Summa.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message);
            }
        }

        // ===== ОБНОВЛЕНИЕ ГРИДА товаров заказа =====
        private void RefreshOrderTovarsGrid()
        {
            // В RefreshOrderTovarsGrid добавь скрытую колонку
            var displayList = item.OderTovars.Select(ot => new
            {
                TovarId = ot.TovarId,  // скрытая колонка
                TovarName = ot.Tovar?.FullName ?? "Товар #" + ot.TovarId,
                Quantity = ot.Quantity,
                Price = ot.Tovar?.Price ?? 0,
                Summa = (ot.Tovar?.Price ?? 0) * ot.Quantity
            }).ToList();

            dataGridViewTovat.DataSource = null;  // сбрасываем для обновления
            dataGridViewTovat.DataSource = displayList;

            // Настройка колонок если нужно
            if (dataGridViewTovat.Columns.Count == 0)
            {
                dataGridViewTovat.AutoGenerateColumns = true;
            }
        }

        // ===== ПЕРЕСЧЁТ СУММЫ =====
        private void RecalculateSumma()
        {
            item.Summa = item.OderTovars.Sum(ot => (ot.Tovar?.Price ?? 0) * ot.Quantity);
        }


        // ===== КНОПКА: УДАЛИТЬ ТОВАР ИЗ ЗАКАЗА =====
        private void btnRemoveTovar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTovat.CurrentRow == null) return;

            int tovarId = Convert.ToInt32(dataGridViewTovat.CurrentRow.Cells["TovarId"].Value);

            var oderTovar = item.OderTovars.FirstOrDefault(ot => ot.TovarId == tovarId);
            if (oderTovar != null)
            {
                item.OderTovars.Remove(oderTovar);
                RefreshOrderTovarsGrid();
                RecalculateSumma();
            }
        }


        // ===== УСТАНОВИТЬ ГАЛОЧКУ по тексту =====
        private void SetCheckBox(ListView lv, string text)
        {
            foreach (ListViewItem li in lv.Items)
            {
                li.Checked = (li.Text == text);
            }
        }

        // ===== ЧТЕНИЕ ВЫБРАННОГО =====
        private string GetCheckedText(ListView lv)
        {
            foreach (ListViewItem li in lv.Items)
            {
                if (li.Checked)
                    return li.Text;
            }
            return lv.Items[0].Text; // первый по умолчанию
        }



        private void btn_OK_Click(object sender, EventArgs e)
        {
            tovarBindingSource.EndEdit();

            if (cB_Status.SelectedItem != null)
                item.Status = cB_Status.SelectedItem.ToString();

            if (string.IsNullOrEmpty(item.Status))
            {
                MessageBox.Show("Выберите статус заказа");
                return;
            }

            // Клиент
            if (item.client != null)
            {
                item.client.FullName = textBox2.Text;
                if (int.TryParse(textBox3.Text, out int telefon))
                    item.client.Telefon = telefon;
                item.client.Adress_C = textBox6.Text;
            }

            // Дата
            if (DateTime.TryParse(textBox4.Text, out DateTime newDate))
                item.date = newDate;

            // ===== ПЛАТЁЖ =====
            string sposob = GetCheckedText(listViewSposob);
            string statusPl = GetCheckedText(listViewStatus);

            if (item.plategs == null)
            {
                item.plategs = new Plateg
                {
                    Sposob_PL = sposob,
                    Status_PL = statusPl
                };
            }
            else
            {
                item.plategs.Sposob_PL = sposob;
                item.plategs.Status_PL = statusPl;
            }

            // ===== СОХРАНЕНИЕ =====
            try
            {
                if (!is_edit)
                {
                    // 1. Сохраняем платёж, получаем Id
                    if (item.plategs.Id == 0)
                    {
                        db.Plateg.Add(item.plategs);
                        db.SaveChanges();
                    }

                    // 2. Устанавливаем FK в заказе
                    item.plategid = item.plategs.Id;

                    // 3. Сохраняем заказ (вместе с товарами)
                    db.Oder.Add(item);
                    db.SaveChanges();
                }
                else
                {
                    db.Oder.Update(item);
                    db.SaveChanges();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message + "\n\n" +
                    ex.InnerException?.Message);
            }
        }
    }
}