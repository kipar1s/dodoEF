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
        dodoEF.MyEF.Entities.ApplicationContext db;
        Oder oder;
        int item_id = -1;

        public OderFormUnit()
        {
            InitializeComponent();

            db = new dodoEF.MyEF.Entities.ApplicationContext();          


            BindingNavigator navigator = new BindingNavigator(true);
            navigator.BindingSource = tovarBindingSource;
            this.groupBox1.Controls.Add(navigator);
        }
        public void EditItem(int item_id)
        {
            this.item_id = item_id;
            this.oder = db.Oder
                .Include(u => u.client)
                .Include(u => u.tovars)
                .FirstOrDefault(u => u.Id == item_id);
            this.oderBindingSource.DataSource = this.oder;
        }


    }
}
