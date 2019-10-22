using System.Windows.Forms;
namespace WindowsFormsApp1
{
    partial class FRMRegisterTeacher
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
            this.Text = "FRMRegisterTeacher";
            lblInformationName= new Label();
            lblInformationName.Text = "ingrese nombre";
            txtName = new TextBox();
            lblInformationSurName= new Label();
            lblInformationSurName.Text = "ingrese apellido";
            txtSurName = new TextBox();
            lblInformationDni= new Label();
            lblInformationDni.Text = "ingrese el dni";
            txtDni = new TextBox();
            lblVirDate= new Label();
            lblVirDate.Text = "inrese fecha de nacimiento";
            pickerVirDate  = new DateTimePicker();
            lblInformationTelephone = new Label();
            lblInformationTelephone.Text = "ingrese telefono";
            txtTelephone = new TextBox();
            lblInformationEmail = new Label();
            lblInformationEmail.Text = "ingrese email";
            txtEmail = new TextBox();
            lblInformationPassword = new Label();
            lblInformationPassword.Text = "ingrese contraseña";
            txtPassword = new TextBox();
            btnRegisterTeacher = new Button();
            btnRegisterTeacher.Text = "registrar profesor";
            btnRegisterTeacher.Click += new System.EventHandler(btnRegisterTeacher_click);
            btnCancel = new Button();
            btnCancel.Text = "cancelar";
            btnCancel.Click += new System.EventHandler(btnCancel_click);
            // organizando los controles en la ventana 
            tlp = new TableLayoutPanel();
            tlp.ColumnCount = 2;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75f));
            tlp.RowCount = 8;
            for (int i=0; i<8; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / 8)));
}
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlp.Controls.Add(lblInformationName, 0, 0);
            tlp.Controls.Add(txtName, 1, 0);
            tlp.Controls.Add(lblInformationSurName, 0, 1);
            tlp.Controls.Add(txtSurName,1,1);
            tlp.Controls.Add(lblInformationDni, 0, 2);
            tlp.Controls.Add(txtDni, 1, 2);
            tlp.Controls.Add(lblVirDate, 0, 3);
            tlp.Controls.Add(pickerVirDate, 1, 3);
            tlp.Controls.Add(lblInformationTelephone, 0, 4);
            tlp.Controls.Add(txtTelephone, 1, 4);
            tlp.Controls.Add(lblInformationEmail, 0, 5);
            tlp.Controls.Add(txtEmail, 1, 5);
            tlp.Controls.Add(lblInformationPassword, 0, 6);
            tlp.Controls.Add(txtPassword,1,6);
            tlp.Controls.Add(btnCancel,0,7);
            tlp.Controls.Add(btnRegisterTeacher, 1, 6);


            // 
        }

        #endregion
        private TableLayoutPanel tlp;

        private Label lblInformationName;
        private TextBox txtName;
        private Label lblInformationSurName;
        private TextBox txtSurName;
        private Label lblInformationDni;
        private TextBox txtDni;
        private Label lblVirDate;
        private DateTimePicker pickerVirDate;
        private Label lblInformationTelephone;
        private TextBox txtTelephone;
        private Label lblInformationEmail;
        private TextBox txtEmail;
        private Label lblInformationPassword;
        private TextBox txtPassword;
        private Button btnRegisterTeacher;
        private Button btnCancel;
        


    }
}