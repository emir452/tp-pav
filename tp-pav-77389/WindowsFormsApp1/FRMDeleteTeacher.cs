using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using visnes;
namespace  presentation
{
    public partial class FRMDeleteTeacher : Form
    {
        private ManagerActiviti managerActiviti;

        public FRMDeleteTeacher( ManagerActiviti managerActiviti)
        {
            InitializeComponent();
            this.managerActiviti = managerActiviti;
        }
        private void FRMDeleteTeacher_load(object sender, EventArgs e)
        {
            if ( MessageBox.Show("está seguro que desea eliminar?, se eliminará de forma permanente", "¿está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                TextBox txtId = new TextBox();
                this.Controls.Add(txtId);
                try
                {
                    managerActiviti.deleteTeacher(int.Parse(txtId.Text));
                }
                catch(Exception )
                {
                    MessageBox.Show("error al eliminar, por favor, inténtelo de nuevo", "eror al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
