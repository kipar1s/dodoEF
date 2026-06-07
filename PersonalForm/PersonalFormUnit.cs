using dodoEF.MyEF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dodoEF.PersonalForm
{
    public partial class PersonalFormUnit : Form
    {
        private bool isEdit = false;
        private int personalId = 0;

        private ApplicationDbContext db;

        public PersonalFormUnit()
        {
            InitializeComponent();

            db = new ApplicationDbContext();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetDataSouce(Personal personal, List<Categori> categoris)
        {
            this.isEdit = (personal.Id != 0);
            this.personalId = personal.Id;

            this.personalBindingSource.DataSource = personal;
            this.categoriBindingSource.DataSource = categoris;

            // Загружаем заказы этого сотрудника
            LoadOdersForPersonal();
            LoadFreeOders();
        }
        // ===== ЗАГРУЗКА ЗАКАЗОВ СОТРУДНИКА =====
        private void LoadOdersForPersonal()
        {
            if (personalId == 0)
            {
                // Новый сотрудник — пустой список
                oderBindingSource.DataSource = new List<Oder>();
                return;
            }

            var oders = db.Oder
                .AsNoTracking()
                .Include(o => o.client)
                .Where(o => o.personalId == personalId)
                .ToList();

            oderBindingSource.DataSource = oders;

            // Заполняем имя клиента вручную
            foreach (DataGridViewRow row in dataGridViewOders.Rows)
            {
                if (row.DataBoundItem is Oder oder && oder.client != null)
                {
                    // Если есть колонка ClientName
                    if (dataGridViewOders.Columns["ClientName"] != null)
                        row.Cells["ClientName"].Value = oder.client.FullName;
                }
            }
        }

        private void LoadFreeOders()
        {
            var freeOders = db.Oder
                .AsNoTracking()
                .Include(o => o.client)
                .Where(o => o.personalId == null)
                .ToList();

            freeOderBindingSource.DataSource = freeOders;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            personalBindingSource.EndEdit();

            var personal = (Personal)personalBindingSource.Current;

            try
            {
                if (!isEdit)
                    db.DbPersonal.Add(personal);
                else
                    db.DbPersonal.Update(personal);

                db.SaveChanges();
                this.personalId = personal.Id;
                this.isEdit = true;

                MessageBox.Show("Сохранено!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void PersonalFormUnit_FormClosing(object sender, FormClosingEventArgs e)
        {
            db?.Dispose();
        }

        private void btnAddOder_Click(object sender, EventArgs e)
        {
            if (!isEdit || personalId == 0)
            {
                MessageBox.Show("Сначала сохраните сотрудника (нажмите OK)!");
                return;
            }

            if (dataGridViewFreeOders.CurrentRow == null)
            {
                MessageBox.Show("Выберите свободный заказ!");
                return;
            }

            int oderId = (int)dataGridViewFreeOders.CurrentRow.Cells[0].Value;

            // Назначаем заказ сотруднику
            var oder = db.Oder.Find(oderId);
            if (oder != null)
            {
                oder.personalId = personalId;
                db.Oder.Update(oder);
                db.SaveChanges();

                // Обновляем оба грида
                LoadOdersForPersonal();
                LoadFreeOders();
            }
        }

        private void btnRemoveOder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOders.CurrentRow == null)
            {
                MessageBox.Show("Выберите заказ для удаления!");
                return;
            }

            int oderId = (int)dataGridViewOders.CurrentRow.Cells[0].Value;

            if (MessageBox.Show(
                $"Отвязать заказ №{oderId} от сотрудника?",
                "Подтверждение",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var oder = db.Oder.Find(oderId);
            if (oder != null)
            {
                oder.personalId = 0;
                db.Oder.Update(oder);
                db.SaveChanges();

                LoadOdersForPersonal();
                LoadFreeOders();
            }
        }
    }
}
