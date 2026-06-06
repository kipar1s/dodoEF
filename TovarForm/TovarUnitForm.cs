using dodoEF.MyEF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodoEF.TovarForm
{
    public partial class TovarUnitForm : Form
    {
        private ApplicationDbContext db;
        private Tovar item;
        private bool is_edit = false;
        private int item_id = -1;

        public TovarUnitForm()
        {
            InitializeComponent();

            db = new ApplicationDbContext();
        }

        public void EditItem(int id)
        {
            is_edit = true;
            item_id = id;
            item = db.Tovar.Find(id);
        }

        private void TovarUnitForm_Load(object sender, EventArgs e)
        {
            if (is_edit && item != null)
            {
                // Режим редактирования
                textBoxFullName.Text = item.FullName;
                textBoxPrice.Text = item.Price.ToString();
                textBoxCatifori.Text = item.Catifori_T;
                textBoxCallory.Text = item.Callory.ToString();

                this.Text = "Редактирование товара";
            }
            else
            {
                // СОЗДАНИЕ — создаём объект и ОЧИЩАЕМ текстбоксы
                item = new Tovar();

                textBoxFullName.Clear();
                textBoxPrice.Clear();
                textBoxCatifori.Clear();
                textBoxCallory.Clear();

                this.Text = "Новый товар";
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Валидация
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Введите название товара!");
                textBoxFullName.Focus();
                return;
            }

            // В btnOK_Click:
            if (!int.TryParse(textBoxPrice.Text, out int price))
            {
                MessageBox.Show("Введите корректную цену!");
                return;
            }
            item.FullName = textBoxFullName.Text.Trim();
            item.Price = price;
            item.Catifori_T = textBoxCatifori.Text.Trim();
            

            if (!int.TryParse(textBoxCallory.Text, out int callory))
            {
                MessageBox.Show("Введите корректные калории!");
                return;
            }
            item.Callory = callory;
            // Диагностика (можно убрать после отладки)
            string debug = $"Сохранение товара:\n" +
                         $"Id: {item.Id}\n" +
                         $"Название: {item.FullName}\n" +
                         $"Цена: {item.Price}\n" +
                         $"Категория: {item.Catifori_T}\n" +
                         $"Калории: {item.Callory}";
            MessageBox.Show(debug, "Диагностика", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Сохранение
            if (!is_edit)
                db.Tovar.Add(item);
            else
                db.Tovar.Update(item);

            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message + "\n\n" +
                    ex.InnerException?.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnСancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
