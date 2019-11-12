using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domainEntities;
using visnes;
namespace WindowsFormsApp1
{
    public partial class FRMRegisterTeacher : Form
    {
        private ManagerActiviti managerActiviti; 
        public FRMRegisterTeacher( ManagerActiviti managerActiviti)
        {
            InitializeComponent();
            this.managerActiviti = managerActiviti;
        }
        private void btnRegisterTeacher_click(Object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.name = txtName.Text;
            teacher.surname = txtSurName.Text;
            teacher.dni = int.Parse(txtDni.Text.ToString());
            teacher.virtDate = pickerVirDate.Value;
            teacher.telephoneNumber = int.Parse(txtTelephone.Text);
            teacher.password = txtPassword.Text;
            try
            {
                managerActiviti.registerTeacher(teacher);
                }
            catch (Exception)
            {
                MessageBox.Show("uvo algún tipo de error con el registro del profesor, por favor, inténtelo de nuevo", "error  en el registro del profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnCancel_click(Object sender, EventArgs e)
        {
            Parent.Visible = true;      

        }
    }
}
