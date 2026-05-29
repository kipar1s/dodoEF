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
    public partial class OderListForm : Form
    {
        dodoEF.MyEF.Entities.ApplicationContext db;
        List<Oder> oders;
        public OderListForm()
        {
            InitializeComponent();
            db = new dodoEF.MyEF.Entities.ApplicationContext();
            RefreshOderGrid();

        }

        public void RefreshOderGrid()
        {
            oders = db.Oder.Include(u => u.client).ToList();
            this.oderBindingSource.DataSource = oders;
        }

        private void tsB_Create_Click(object sender, EventArgs e)
        {

        }
        

        private void tsB_Edit_Click(object sender, EventArgs e)
        {
            int item_id = ((Oder)this.oderBindingSource.Current).Id;
            OderFormUnit oderFormUnit = new OderFormUnit();
            oderFormUnit.EditItem(item_id);
            oderFormUnit.ShowDialog();
             RefreshOderGrid();
        }

        private void tsB_Delite_Click(object sender, EventArgs e)
        {

        }
    }
}
