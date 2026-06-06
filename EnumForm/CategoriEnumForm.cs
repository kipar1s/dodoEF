using dodoEF.MyEF.Entities;
using Microsoft.EntityFrameworkCore;  // ← ВОТ ЭТО
using System;
using System.Linq;
using System.Windows.Forms;

namespace dodoEF.EnumForm
{
    public partial class CategoriEnumForm : Form
    {
        private ApplicationDbContext db;
        private BindingSource bindingSource;

        public CategoriEnumForm()
        {
            InitializeComponent();
            db = new ApplicationDbContext();
            bindingSource = new BindingSource();
        }

        private void CategoriEnumForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SetupGrid();
        }

        private void LoadData()
        {
            var categoris = db.Categori
                .AsNoTracking()
                .ToList();

            bindingSource.DataSource = categoris;
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
                Name = "Tatle",
                HeaderText = "Название категории",
                DataPropertyName = "Tatle",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newName = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите название новой категории:",
                "Добавление категории",
                "");

            if (string.IsNullOrWhiteSpace(newName))
                return;

            var categori = new Categori { Tatle = newName };
            db.Categori.Add(categori);
            db.SaveChanges();

            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null)
            {
                MessageBox.Show("Выберите категорию для редактирования");
                return;
            }

            var current = (Categori)bindingSource.Current;
            string newName = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите новое название:",
                "Редактирование категории",
                current.Tatle);

            if (string.IsNullOrWhiteSpace(newName))
                return;

            var categori = db.Categori.Find(current.Id);
            if (categori != null)
            {
                categori.Tatle = newName;
                db.SaveChanges();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null)
            {
                MessageBox.Show("Выберите категорию для удаления");
                return;
            }

            var current = (Categori)bindingSource.Current;

            if (MessageBox.Show(
                $"Удалить категорию '{current.Tatle}'?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            bool hasPersonal = db.DbPersonal.Any(p => p.categoriId == current.Id);
            if (hasPersonal)
            {
                MessageBox.Show("Нельзя удалить — есть сотрудники с этой категорией!");
                return;
            }

            var categori = db.Categori.Find(current.Id);
            if (categori != null)
            {
                db.Categori.Remove(categori);
                db.SaveChanges();
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CategoriEnumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db?.Dispose();
        }
    }
}