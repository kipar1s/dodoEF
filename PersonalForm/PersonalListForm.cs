using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
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
            personals = db.DbPersonal.Include(u => u.categori).ToList();
            this.personalBindingSource.DataSource = personals;

        }

        private void tsB_Create_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            PersonalFormUnit personal_form_unit = new PersonalFormUnit();
            personal_form_unit.SetDataSouce(
                personal,
                db.Categori.ToList());
            if (personal_form_unit.ShowDialog() == DialogResult.OK)
            {
                db.DbPersonal.Add(personal);
                db.SaveChanges();
                RefreshPersonalGrid();
            }
            ;

        }

        private void tsB_Edit_Click(object sender, EventArgs e)
        {
            Personal personal = (Personal)this.personalBindingSource.Current;
            PersonalFormUnit personal_form_unit = new PersonalFormUnit();
            personal_form_unit.SetDataSouce(
                personal,
                db.Categori.ToList());
            if (personal_form_unit.ShowDialog() == DialogResult.OK)
            {
                db.DbPersonal.Update(personal);
                db.SaveChanges();
                RefreshPersonalGrid();
            }
            ;
        }

        private void tsB_Delite_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "Действительно удалить?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Personal personal = (Personal)this.personalBindingSource.Current;
                db.DbPersonal.Remove(personal);
                db.SaveChanges();
                RefreshPersonalGrid();
            }
        }

        private void PersonalListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.DbPersonal.UpdateRange(personals);
            db.SaveChanges();
        }
    }
}
