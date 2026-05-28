using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dodoEF.MyEF.Entities;

namespace dodoEF.PersonalForm
{
    public partial class PersonalFormUnit : Form
    {
        public PersonalFormUnit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetDataSouce(Personal personal, List<Categori> categoris)
        {
            this.personalBindingSource.DataSource = personal;
            this.categoriBindingSource.DataSource = categoris;
        }
    }
}
