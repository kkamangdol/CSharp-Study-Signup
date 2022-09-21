using System.Runtime.Versioning;

namespace MetroUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mtAdd_Click(object sender, EventArgs e)
        {
            using(frmAddEditStudent frm=new frmAddEditStudent())
            {
                frm.ShowDialog();
            }
        }
    }
}