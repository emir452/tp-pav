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
using visnes.exceptions;
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
            Role r;
            ItemCombo item = (ItemCombo)this.selectRol.SelectedItem;
            while (item == null)
            {
                MessageBox.Show("debe seleccionar un rol", "seleccione rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                item = (ItemCombo)this.selectRol.SelectedItem;
}
            if (item.role.Equals(Role.Roles.MANAGER))
            {
                r = new LoggerManager();
                try
                {
                    r.login(int.Parse(txtUser.Text), txtPasword.Text);
                    new FRMManager();
                }
                catch(ObjectNotFoundException )
                {
                    MessageBox.Show("problema con el inicio de sesiòn", "fayo en el inicio d sesiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
}

            if (item.role.Equals(Role.Roles.TEACHER))
            {
                r = new LoggerManager();
                try
                { 
                    r.login(int.Parse(txtUser.Text), txtPasword.Text);
                new FRMTeacher();
}
            catch (ObjectNotFoundException )
                {
                    MessageBox.Show("problema con el incio de sesión", "fayo de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                r = new LoggerStudent();
                try
                {
                    r.login(int.Parse(txtUser.Text), txtPasword.Text);
                    new FRMStudent();
                }
                catch(ObjectNotFoundException )
                {
                    MessageBox.Show("problema con el inicio de sesión", "fayo en el inicio de sesìón", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
}

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