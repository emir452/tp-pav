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
using domainEntities;
namespace  presentation 
{
    public partial class FRMRegisterStudent : Form
    {
        private ManagerActiviti ManagerActiviti;
        public FRMRegisterStudent(ManagerActiviti managerActiviti)
        {
            InitializeComponent();
            this.ManagerActiviti = managerActiviti;
        }
        public void btnRegisterStudent_click(object sender, EventArgs e)
        {   
            Student student = new Student();
            student.personalData.name = txtName.Text;
            student.personalData.surname = txtSurName.Text;
            student.personalData.dni = int.Parse(txtDni.Text);
            student.personalData.telephoneNumber= int.Parse(txtTelephone.Text);
            student.personalData.virtDate = DateTime.Parse(date.Text);
            student.personalData.email = txtEmail.Text;
            student.personalData.password = txtPassword.Text;
            ManagerActiviti.registerStudent(student);

        }
        public void btnCancel_click(Object sender, EventArgs e)
        {
            this.Parent.Visible = true;  


        }
    }
}
