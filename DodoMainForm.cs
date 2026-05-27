using dodoEF.MyEF.Entities;
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
    }
}
