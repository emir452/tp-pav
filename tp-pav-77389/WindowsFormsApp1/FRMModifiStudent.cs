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
using domainEntities;
namespace  presentation
{
    public partial class FRMModifiStudent : Form
    {
        private ManagerActiviti managerActiviti;
        private Student found;

        public FRMModifiStudent(ManagerActiviti managerActiviti)
        {
            InitializeComponent();
            this.managerActiviti = managerActiviti;
        }
        private void btnCancel_click(Object sender, EventArgs e)
        {
            this.Parent.Visible = true;
        }
        private void btnSearch_click(Object sender, EventArgs e)
        {
try
            {
                found = managerActiviti.findStudentById(int.Parse(txtId.Text));

            }
catch (ObjectNotFoundException)
            {
                MessageBox.Show("legajo inválido", " eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
        private void showStudent()
        {
            tlp.RowCount = 8;
            tlp.RowStyles.Clear();
            tlp.Controls.Clear();
            for (int i = 0; i < 8; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / 8f)));
}
            lblInformationName = new Label();
            lblInformationName.Text = "nombre";
            txtName = new TextBox();
            txtName.Text = found.personalData.name;
            lblInformationSurname = new Label();
            lblInformationSurname.Text = "apellido";
            txtSurName = new TextBox();
            txtSurName.Text = found.personalData.surname;
            lblInformationDni = new Label();
            lblInformationDni.Text = "DNI";
            txtDni = new TextBox();
            txtDni.Text = found.personalData.dni.ToString();
            lblInformationTelephone = new Label();
            lblInformationTelephone.Text = "teléfono";
            txtTelephone = new TextBox();
            txtTelephone.Text = found.personalData.telephoneNumber.ToString();
            lblInformationVirtDate = new Label();
            lblInformationVirtDate.Text = "fecha de nacimiento";
            pickerVirtDate = new DateTimePicker();
            pickerVirtDate.Value = found.personalData.virtDate;
            lblInformationEmail = new Label();
            lblInformationEmail.Text = "email";
            txtEmail = new TextBox();
            txtEmail.Text = found.personalData.email;
            lblInformationPassword = new Label();
            lblInformationPassword.Text = "contraseña";
            txtPassword = new TextBox();
            txtPassword.Text = found.personalData.password;
            btnCancelUpdating = new Button();
            btnCancelUpdating.Text = "cancelar actualización";
            btnCancel.Click += new EventHandler(btnCancelUpdating_click);
            btnUpdate = new Button();
            btnUpdate.Text = "actualizar";
            btnUpdate.Click += new EventHandler(btnUpdate_click);
            tlp.Controls.Add(lblInformationName, 0, 0);
            tlp.Controls.Add(txtName, 1, 0);
            tlp.Controls.Add(lblInformationSurname, 0, 1);
            tlp.Controls.Add(txtSurName, 1, 1);
            tlp.Controls.Add(lblInformationDni, 0, 2);
            tlp.Controls.Add(txtDni, 1, 2);
            tlp.Controls.Add(lblInformationTelephone, 0, 3);
            tlp.Controls.Add(txtTelephone, 1, 3);
            tlp.Controls.Add(lblInformationVirtDate, 0, 4);
            tlp.Controls.Add(pickerVirtDate, 1, 4);
            tlp.Controls.Add(lblInformationEmail, 0, 5);
            tlp.Controls.Add(txtEmail, 1, 5);
            tlp.Controls.Add(lblInformationPassword, 0, 6);
            tlp.Controls.Add(txtPassword, 1, 6);
            tlp.Controls.Add(btnCancelUpdating, 0, 7);
            tlp.Controls.Add(btnUpdate, 1, 7);  
}
        private void btnCancelUpdating_click(Object sender, EventArgs e)
        {
            FRMModifiStudent f = new FRMModifiStudent(managerActiviti);
            f.ShowDialog();
        }
        private void btnUpdate_click(Object sender, EventArgs e)
        {
            found.personalData.name = txtName.Text;
            found.personalData.surname = txtSurName.Text;
            found.personalData.dni = int.Parse(txtDni.Text);
            found.personalData.virtDate = pickerVirtDate.Value;
            found.personalData.email = txtEmail.Text;
            found.personalData.password = txtPassword.Text;
            try
            {
                managerActiviti.updateStudent(found);
            }
            catch ( ImposibleUpdateException )
            {
                MessageBox.Show("problemas en la actualización", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}
        
    }
}
