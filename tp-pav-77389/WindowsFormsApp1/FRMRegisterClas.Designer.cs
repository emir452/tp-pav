using System.Windows.Forms;
namespace WindowsFormsApp1
{
    partial class FRMRegisterClas
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
            this.Text = "registrar clase ";
            view = new ListBox();
            view.Dock = DockStyle.Fill;
            txtIdStudent = new TextBox();
            txtIdStudent.KeyPress += new KeyPressEventHandler(txtIdStudent_keyPress);
            txtCalification = new TextBox();
            txtCalification.KeyPress += new KeyPressEventHandler(txtCalification_keyPress);
            txtObservations = new TextBox();
            txtObservations.MaxLength = 200;
            cboTeme = new ComboBox();
            btnRegisterClass = new Button();
            btnRegisterClass.Text = "egistrar clase";
            btnRegisterClass.Click += new System.EventHandler(btnRegisterClass_click);
            view.Controls.Add(txtIdStudent);
            view.Controls.Add(txtCalification);
            view.Controls.Add(txtObservations);
            this.Controls.Add(view);
            // termina 
        }

        #endregion
        private ListBox view;

        private TextBox  txtIdStudent;
        private ComboBox cboTeme;
        private TextBox txtCalification;
        private TextBox txtObservations;
        private Button btnRegisterClass;
    }
}