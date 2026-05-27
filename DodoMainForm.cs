using dodoEF.MyEF.Entities;
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
    }
}
