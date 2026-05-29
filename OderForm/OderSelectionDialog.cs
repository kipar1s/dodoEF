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
    public partial class OderSelectionDialog : Form
    {
        dodoEF.MyEF.Entities.ApplicationContext db;
        public OderSelectionDialog()
        {
            InitializeComponent();
            db = new dodoEF.MyEF.Entities.ApplicationContext();
            this.clientBindingSource.DataSource = db.Client.ToList();
        }

        public Client selected_client
        {
            get
            {
                return (Client)this.comboBox1.SelectedItem;
            }
        }
    }
}
