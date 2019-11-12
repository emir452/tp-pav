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
    public partial class FRMRegisterClas : Form
    {
        private TeacherActiviti teacherActiviti;
        public FRMRegisterClas(TeacherActiviti teacherActiviti)
        {
            InitializeComponent();
            this.teacherActiviti = teacherActiviti;
        }
        private void txtIdStudent_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
}
}
        private void txtCalification_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
}
}
        private void btnRegisterClass_click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.personalData = teacherActiviti.sesion.user.personalData;

            Class c = new Class(t, teacherActiviti.findStudentById(int.Parse(txtIdStudent.Text)));
            c.teme = new TemeService().findById(int.Parse(cboTeme.SelectedValue.ToString()));
            
           
            
        }

}
}
