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
namespace WindowsFormsApp1
{
    public partial class FRMlogin : Form
    {
        public FRMlogin()
        {
            InitializeComponent();
        }
        private void btnInit_clik(object sender, EventArgs e)
        {
            UserManager u = new UserManager();
            ItemCombo item = (ItemCombo)this.selectRol.SelectedItem;
            while (item == null)
            {
                MessageBox.Show("debe seleccionar un rol", "seleccione rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                item = (ItemCombo)this.selectRol.SelectedItem;

            }
            u.login(  int.Parse(this.txtUser.Text), this.txtPasword.Text, item.role);
        }
        private void btnExit_clik(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void FRMlogin_load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
        private void fillCombo()
        {
            selectRol.Text = "seleccione rol";
            selectRol.Items.Add(new ItemCombo(new LoggerManager(), "administrador"));
            selectRol.Items.Add(new ItemCombo(new LoggerStudent(), "estudiante"));
            selectRol.Items.Add(new ItemCombo(new LoggerTeacher(), "profesor"));
}
}
}