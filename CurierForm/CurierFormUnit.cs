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
    public partial class CurierFormUnit : Form
    {
        private bool isEdit = false;
        private int curierId = 0;
        private ApplicationDbContext db;
        private Personal personal;

        public CurierFormUnit()
        {
            InitializeComponent();
            db = new ApplicationDbContext();
        }
        public void EditCurier(int id)
        {
            isEdit = true;
            curierId = id;
            personal = db.DbPersonal.Find(id);
        }

        private void CurierFormUnit_Load(object sender, EventArgs e)
        {
            // Загружаем категории (только курьеры — categoriId == 21)
            var categoris = db.Categori
                .AsNoTracking()
                .Where(c => c.Id == 21)
                .ToList();

            categoriBindingSource.DataSource = categoris;

            if (isEdit && personal != null)
            {
                textBoxFullName.Text = personal.FullName;
                textBoxStage.Text = personal.Stage.ToString();
                textBoxLogin.Text = personal.Login;
                textBoxPassword.Text = personal.Password;
                textBoxNumVY.Text = personal.Num_VY.ToString();
                textBoxNumCar.Text = personal.Num_Car.ToString();

                comboBoxCategori.SelectedValue = personal.categoriId;
            }
            else
            {
                // Создание нового курьера
                personal = new Personal();
                personal.categoriId = 21; // курьер по умолчанию

                if (categoris.Count > 0)
                    comboBoxCategori.SelectedValue = 21;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Валидация
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Введите ФИО!");
                return;
            }

            if (!int.TryParse(textBoxStage.Text, out int stage))
            {
                MessageBox.Show("Стаж должен быть числом!");
                return;
            }

            if (!int.TryParse(textBoxNumVY.Text, out int numVY))
            {
                MessageBox.Show("Номер ВУ должен быть числом!");
                return;
            }

            if (!int.TryParse(textBoxNumCar.Text, out int numCar))
            {
                MessageBox.Show("Номер машины должен быть числом!");
                return;
            }

            // Заполняем объект
            personal.FullName = textBoxFullName.Text;
            personal.Stage = stage;
            personal.Login = textBoxLogin.Text;
            personal.Password = textBoxPassword.Text;
            personal.Num_VY = numVY;
            personal.Num_Car = numCar;
            personal.categoriId = 21; ;

            // Сохранение
            if (isEdit)
                db.DbPersonal.Update(personal);

            else
                db.DbPersonal.Add(personal);

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

        private void btnСancel_Click(object sender, EventArgs e)
        {
            db?.Dispose();
        }

        private void CurierFormUnit_FormClosing(object sender, FormClosingEventArgs e)
        {
            db?.Dispose();
        }
    }
}
