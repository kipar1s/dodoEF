using dodoEF.MyEF.Entities;
using dodoEF.OderForm;
using dodoEF.PersonalForm;
namespace dodoEF
{
    public partial class DodoMainForm : Form
    {
        dodoEF.MyEF.Entities.ApplicationContext db;
        public DodoMainForm()
        {
            InitializeComponent();
            db = new dodoEF.MyEF.Entities.ApplicationContext();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalListForm personal_list_form = new PersonalListForm();
            personal_list_form.MdiParent = this;
            personal_list_form.Show();
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OderListForm oder_list_form = new OderListForm();
            oder_list_form.MdiParent = this;
            oder_list_form.Show();
        }
    }
}
