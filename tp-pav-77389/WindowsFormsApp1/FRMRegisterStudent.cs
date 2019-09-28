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
namespace WindowsFormsApp1
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
            student.name = txtName.Text;
            student.surname = txtSurName.Text;
            student.dni = int.Parse(txtDni.Text);
            student.telephoneNmber = int.Parse(txtTelephone.Text);
            student.virtDate = DateTime.Parse(date.Text);
            student.email = txtEmail.Text;
            student.password = txtPassword.Text;
            ManagerActiviti.registerStudent(student);

        }
        public void btnCancel_click(Object sender, EventArgs e)
        {
           

        }
    }
}
