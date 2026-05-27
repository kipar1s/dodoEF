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
    public partial class PersonalListForm : Form
    {
        dodoEF.MyEF.Entities.ApplicationContext db;
        List<Personal> personals;
        public PersonalListForm()
        {
            InitializeComponent();
            db = new dodoEF.MyEF.Entities.ApplicationContext();
            RefreshPersonalGrid();
        }

        public void RefreshPersonalGrid()
        {
            personals = db.DbPersonal.ToList();
            this.personalBindingSource.DataSource = personals;

        }

        private void tsB_Create_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            PersonalFormUnit personal_form_unit = new PersonalFormUnit();
            personal_form_unit.SetDataSouce(personal);
            if (personal_form_unit.ShowDialog() == DialogResult.OK) {
                db.DbPersonal.Add(personal);
                db.SaveChanges();
                RefreshPersonalGrid();
            }
            ;

        }
    }
}
