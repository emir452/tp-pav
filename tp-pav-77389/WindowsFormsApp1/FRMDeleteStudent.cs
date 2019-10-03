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
namespace WindowsFormsApp1
{
    public partial class FRMDeleteStudent : Form
    {
        private ManagerActiviti managerActiviti;
        private Student found;
        public FRMDeleteStudent(ManagerActiviti managerActiviti)
        {
            InitializeComponent();
            this.managerActiviti = managerActiviti;
        }
        private void btnCancel_click(Object sender, EventArgs e)
        {
            this.Parent.Visible = true;
        }
        public void btnSearch_click(Object sender, EventArgs e)
        {
            try
            {
                found = managerActiviti.findStudentById(int.Parse(txtId.Text));
            }
            catch (ObjectNotFoundException )
            {
                MessageBox.Show("estudiante no enconrado", "legajo no bálido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRMDeleteStudent f = new FRMDeleteStudent(managerActiviti);
                f.ShowDialog();
}
            //  dándole bvalores a los controles nuevos que mostrarán algunos datos del estudiante seleccionado 
            lblName = new Label();
            lblName.Text = "nombre";
            lblNameInformation = new Label();
            lblNameInformation.Text = found.name;
            lblSurname = new Label();
            lblSurname.Text = "apellido";
            lblInformationSurname = new Label();
            lblInformationSurname.Text = found.surname;
            lblDni = new Label();
            lblDni.Text = "DNI";
            lblInformationDni = new Label();
            lblInformationDni.Text = found.dni.ToString();
            btnDeleteStudent = new Button();
            btnDeleteStudent.Text = "eliminar estudiante";
            btnDeleteStudent.Click += new EventHandler(btnDeleteStudent_click);
            //  las filas eran 4, pero no eran nesesarias para la búsqueda, como ahora son necesarias, a continuación se le dan los estilos
tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            tlp.Controls.Add(lblName, 0, 0);
            tlp.Controls.Add(lblNameInformation, 1, 0);
            tlp.Controls.Add(lblSurname, 0, 1);
            tlp.Controls.Add(lblInformationSurname, 1, 1);
            tlp.Controls.Add(lblDni, 0, 2);
            tlp.Controls.Add(lblInformationDni, 1, 2);
            tlp.Controls.Add(btnCalcel, 0, 3);
            tlp.Controls.Add(btnDeleteStudent, 1, 3);
        }
        public void btnDeleteStudent_click(Object sender, EventArgs e)
        {
           DialogResult result=  MessageBox.Show("está seguro que desea eliminar este estudiante, la eliminación será permanente", "¿está seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                try
                {
                    managerActiviti.deleteStudent(found.id);
                }
                catch (Exception )
                {
                    MessageBox.Show("no se pudo eliminar el estudiante", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

    }
}
