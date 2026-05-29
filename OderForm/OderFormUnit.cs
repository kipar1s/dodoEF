using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.EntityFrameworkCore;
using dodoEF.MyEF.Entities;


namespace dodoEF.OderForm
{
    public partial class OderFormUnit : Form
    {
        bool is_edit = false;
        dodoEF.MyEF.Entities.ApplicationContext db;
        Oder item;
        int item_id = -1;

        public OderFormUnit()
        {
            InitializeComponent();
            db = new dodoEF.MyEF.Entities.ApplicationContext();

            // Привязка комбобокса к источнику данных
            cB_Status.DataBindings.Add("SelectedItem", oderBindingSource, "Status", true, DataSourceUpdateMode.OnPropertyChanged);

            BindingNavigator navigator = new BindingNavigator(true);
            navigator.BindingSource = tovarBindingSource;
            this.groupBox1.Controls.Add(navigator);
        }

        public void EditItem(int item_id)
        {
            is_edit = true;
            this.item_id = item_id;
            this.item = db.Oder
                .Include(u => u.client)
                .Include(u => u.tovars)
                .FirstOrDefault(u => u.Id == item_id);
            this.oderBindingSource.DataSource = this.item;
        }

        private void OderFormUnit_Load(object sender, EventArgs e)
        {
            // Заполняем комбобокс
            var statuses = new List<string> { "Доставлено", "Отменен" };
            cB_Status.DataSource = statuses;   // теперь Items заполнятся автоматически

            // Выбираем текущий статус
            if (is_edit && item != null)
            {
                cB_Status.SelectedItem = item.Status; // или cB_Status.Text = item.Status
            }
            else
            {
                cB_Status.SelectedIndex = 0; // значение по умолчанию
                OderSelectionDialog oderSelectionDialog = new OderSelectionDialog();
                if (oderSelectionDialog.ShowDialog() != DialogResult.OK)
                {
                    Close();
                    return;
                }

                item = new Oder
                {
                    client = oderSelectionDialog.selected_client,
                    tovars = new List<Tovar>(),
                    Status = "Доставлено"   // значение по умолчанию
                };
            }

           

            

            cB_Status.SelectedItem = item.Status;
            this.oderBindingSource.DataSource = item;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            // Привязка уже обновит item.Status автоматически
            // Но на всякий случай проверим
            if (string.IsNullOrEmpty(item.Status))
            {
                MessageBox.Show("Выберите статус заказа");
                return;
            }

            db.Oder.Update(item);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
