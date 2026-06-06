using dodoEF.MyEF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dodoEF.TovarForm
{
    public partial class TovarListForm : Form
    {
        private ApplicationDbContext db;
        public TovarListForm()
        {
            InitializeComponent();
            db = new ApplicationDbContext();
        }

        private void tsB_Create_Click(object sender, EventArgs e)
        {
            var form = new TovarUnitForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTovars();
            }
        }

        private void ConfigureGrid()
        {
            // Отключаем авто-генерацию и чистим всё
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // ID
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50,
                ReadOnly = true
            });

            // Название
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Название",
                DataPropertyName = "FullName",
                Width = 200,
                ReadOnly = true
            });

            // Цена
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Цена",
                DataPropertyName = "Price",
                Width = 80,
                ReadOnly = true
            });

            // Категория
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Catifori_T",
                HeaderText = "Категория",
                DataPropertyName = "Catifori_T",
                Width = 120,
                ReadOnly = true
            });

            // Калории
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Callory",
                HeaderText = "Калории",
                DataPropertyName = "Callory",
                Width = 80,
                ReadOnly = true
            });

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void tsB_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите товар для редактирования!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            var form = new TovarUnitForm();
            form.EditItem(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTovars();
            }
        }

        private void tsB_Delite_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите товар для удаления!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            var tovar = db.Tovar.Find(id);

            if (tovar == null)
            {
                MessageBox.Show("Товар не найден!");
                return;
            }

            if (MessageBox.Show($"Удалить товар \"{tovar.FullName}\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                db.Tovar.Remove(tovar);
                db.SaveChanges();
                LoadTovars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message + "\n\n" +
                    "Возможно, товар используется в заказах.");
            }
        }


        private void TovarListForm_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadTovars();


        }

        private void LoadTovars()
        {
            var tovars = db.Tovar.AsNoTracking().ToList();
            dataGridView1.DataSource = null;        // сброс
            dataGridView1.DataSource = tovars;
        }
    }
}
