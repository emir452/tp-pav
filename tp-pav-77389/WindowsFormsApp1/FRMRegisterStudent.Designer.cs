using System.Windows.Forms;
namespace WindowsFormsApp1
{
    partial class FRMRegisterStudent
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
            this.Text = "registrar estudiante";
            lblName = new Label();
            lblName.Text = "ingrese nombre";
            txtName = new TextBox();
            lblSurName = new Label();
            lblSurName.Text = "ingrese apellido";
            lblDni = new Label();
            lblDni.Text = "ingrese edni";
            txtDni = new TextBox();
            lblTelephone = new Label();
            lblTelephone.Text = "ingrese telefono";
            txtTelephone = new TextBox();
            lblDate = new Label();
            lblDate.Text = "inrese fecha de nacimiento";
            date = new DateTimePicker();
            lblEmail = new Label();
            lblEmail.Text = "ingrese email";
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblPassword.Text = "ingrese contraseña";
            txtPassword = new TextBox();
            register = new Button();
            register.Text = "registrar estudiante";
            register.Click += new System.EventHandler(btnRegisterStudent_click); 
            cancel = new Button();
            cancel.Text = "cncelar";

            // organizando los controles en la ventana 
            tlp = new TableLayoutPanel();
            tlp.ColumnCount = 2;
            tlp.RowCount = 8;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent,(100/8)));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / 8)));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / 8)));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / 8)));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / 8)));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / 8)));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / 8)));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / 8)));
tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75f));
            tlp.Controls.Add(lblName, 0, 0);
            tlp.Controls.Add(txtName, 1, 0);
            tlp.Controls.Add(lblSurName, 0, 1);
            tlp.Controls.Add(txtSurName, 1, 1);
            tlp.Controls.Add(lblDni, 0, 2);
                tlp.Controls.Add(txtDni, 1, 2);
            tlp.Controls.Add(lblTelephone, 0, 3);
            tlp.Controls.Add(txtTelephone, 1, 3);
            tlp.Controls.Add(lblDate, 0, 4);
            tlp.Controls.Add(date, 1, 4);
            tlp.Controls.Add(lblEmail, 0, 5);
            tlp.Controls.Add(txtEmail, 1, 5);
            tlp.Controls.Add(lblPassword, 0, 6);
            tlp.Controls.Add(txtPassword, 1, 6);
            tlp.Controls.Add(cancel, 0, 7);
            tlp.Controls.Add(register, 1, 7);
            this.Controls.Add(tlp);

             
            this.PerformLayout();

        }

        #endregion
        private TableLayoutPanel tlp;
        private Label lblName;
        private TextBox txtName;
        private Label lblSurName;
        private TextBox txtSurName;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblTelephone;
        private TextBox txtTelephone;
        private Label lblDate;
        private DateTimePicker date;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button register;
        private Button cancel;

    }
}