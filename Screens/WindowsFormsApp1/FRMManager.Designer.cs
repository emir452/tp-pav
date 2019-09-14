using System.Windows.Forms;
namespace WindowsFormsApp1
{
    partial class FRMManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FRMManager";
            menuContainer = new MenuStrip();
             teachersMenu= new MenuStrip();
            registerTeacher = new MenuItem();
            registerTeacher.Text = "registrar profesor";
            modifiTeacher = new MenuItem();
            modifiTeacher.Text = "modificar profesor";
            deleteTeacher = new MenuItem();
            deleteTeacher.Text = "eliminar profesor";
          
            students = new MenuStrip();
            students.Text = "estudiantes";
                registerStudent= new MenuItem();
            registerStudent.Text = "registrar estudiantes";
            modifiStudent = new MenuItem();
            modifiStudent.Text = "modificar estudiante";
            deleteStudent = new MenuItem();
            deleteStudent.Text = "eliminar estudiante";
            managers = new MenuStrip();
            registerManager = new MenuItem();
            registerManager.Text = "registrar administradores";
            modifiManager = new MenuItem();
            modifiManager.Text = "modificar administrador";
            deleteManager.Text = "eliminar administrador";

            this.Controls.Add(tlp);
            this.PerformLayout();
        }
        #endregion
        private TableLayoutPanel tlp;
        private MenuStrip menuContainer;
        private MenuStrip teachersMenu;
        private MenuItem registerTeacher;
        private MenuItem modifiTeacher;
        private MenuItem deleteTeacher;
        private MenuStrip students;
        private MenuItem registerStudent;
        private MenuItem modifiStudent;
        private MenuItem deleteStudent;
        private MenuStrip managers;
        private MenuItem registerManager;
        private MenuItem modifiManager;
        private MenuItem deleteManager;

    }
}