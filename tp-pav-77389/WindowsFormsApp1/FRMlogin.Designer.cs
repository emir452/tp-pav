namespace WindowsFormsApp1
{
    using System.Windows.Forms;
    partial class FRMlogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPasword = new System.Windows.Forms.Label();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.lblCombo = new System.Windows.Forms.Label();
            this.selectRol = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp.Controls.Add(this.lblUser, 0, 0);
            this.tlp.Controls.Add(this.txtUser, 1, 0);
            this.tlp.Controls.Add(this.lblPasword, 0, 1);
            this.tlp.Controls.Add(this.txtPasword, 1, 1);
            this.tlp.Controls.Add(this.lblCombo, 0, 2);
            this.tlp.Controls.Add(this.selectRol, 1, 2);
            this.tlp.Controls.Add(this.btnExit, 0, 3);
            this.tlp.Controls.Add(this.btnInit, 1, 3);
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 4;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.Size = new System.Drawing.Size(200, 100);
            this.tlp.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(3, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(44, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "ingrese legajo";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(53, 3);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblPasword
            // 
            this.lblPasword.Location = new System.Drawing.Point(3, 25);
            this.lblPasword.Name = "lblPasword";
            this.lblPasword.Size = new System.Drawing.Size(44, 23);
            this.lblPasword.TabIndex = 2;
            this.lblPasword.Text = "ingrese contraseña";
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(53, 28);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(100, 20);
            this.txtPasword.TabIndex = 3;
            // 
            // lblCombo
            // 
            this.lblCombo.Location = new System.Drawing.Point(3, 50);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(44, 23);
            this.lblCombo.TabIndex = 4;
            this.lblCombo.Text = "seleccione rol";
            // 
            // selectRol
            // 
            this.selectRol.Location = new System.Drawing.Point(53, 53);
            this.selectRol.Name = "selectRol";
            this.selectRol.Size = new System.Drawing.Size(121, 21);
            this.selectRol.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(3, 78);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 19);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "salir";
            this.btnExit.Click += new System.EventHandler(this.btnExit_clik);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(53, 78);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 19);
            this.btnInit.TabIndex = 7;
            this.btnInit.Text = "iniciar sesión";
            this.btnInit.Click += new System.EventHandler(this.btnInit_clik);
            // 
            // FRMlogin
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tlp);
            this.Name = "FRMlogin";
            this.Text = "iniciar seción";
            this.Load += new System.EventHandler(this.FRMlogin_load);
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private TableLayoutPanel tlp;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblPasword;
        private TextBox txtPasword;
        private Label lblCombo;
        private ComboBox selectRol;
        private Button btnInit;
        private Button btnExit;


        
    }
    
}

