using dodoEF.MyEF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodoEF.CurierForm
{
    public partial class CurierListForm : Form
    {
        private ApplicationDbContext db;
        private BindingSource bindingSource;  

        public CurierListForm()
        {
            InitializeComponent();
            db = new ApplicationDbContext();
            bindingSource = new BindingSource();
        }

        private void CurierListForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SetupGrid();
        }
        private void LoadData()
        {
            // ВРЕМЕННО: проверим, есть ли колонка PersonalType
            try
            {
                var test = db.DbPersonal.FirstOrDefault();
                MessageBox.Show($"Таблица DbPersonal загружена. Записей: {db.DbPersonal.Count()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки DbPersonal: " + ex.Message);
                return;
            }

            
            // Фильтруем в памяти (где есть Num_VY > 0 — это курьеры)
            var curiers = db.DbPersonal
                .AsNoTracking()
                .Include(p => p.categori)
                .Where(p => p.categoriId == 21)
                .ToList();
                        
            

            bindingSource.DataSource = curiers;
            dataGridView1.DataSource = bindingSource;
        }

        private void SetupGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                ReadOnly = true,
                Width = 50
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "ФИО",
                DataPropertyName = "FullName",
                Width = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Stage",
                HeaderText = "Стаж",
                DataPropertyName = "Stage",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoriName",
                HeaderText = "Категория",
                ReadOnly = true,
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Num_VY",
                HeaderText = "Номер ВУ",
                DataPropertyName = "Num_VY",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Num_Car",
                HeaderText = "Номер машины",
                DataPropertyName = "Num_Car",
                Width = 120
            });

            // Заполняем категорию вручную
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "CategoriName" && e.RowIndex >= 0)
            {
                var personal = dataGridView1.Rows[e.RowIndex].DataBoundItem as Personal;
                e.Value = personal?.categori?.Tatle ?? "";
                e.FormattingApplied = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var form = new CurierFormUnit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            var personal = (Personal)bindingSource.Current;
            var form = new CurierFormUnit();
            form.EditCurier(personal.Id);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var personal = (Personal)bindingSource.Current;

            if (MessageBox.Show($"Удалить курьера {personal.FullName}?",
                "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            // Проверяем заказы через db
            bool hasOrders = db.Oder.Any(o => o.personalId == personal.Id);
            if (hasOrders)
            {
                MessageBox.Show("Нельзя удалить — у курьера есть заказы!");
                return;
            }

            var toDelete = db.DbPersonal.Find(personal.Id);
            if (toDelete != null)
            {
                db.DbPersonal.Remove(toDelete);
                db.SaveChanges();
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CurierListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db?.Dispose();
        }
    }
}
