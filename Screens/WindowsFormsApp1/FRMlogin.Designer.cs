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
            lblUser.Text = "INGRESE NOMBRE DE USUARIO";
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPasword = new System.Windows.Forms.Label();
            lblPasword.Text = "INGRESE CONTRASEÑA";
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            btnExit.Text = "salir";
            btnExit.Click += new System.EventHandler(btnExit_clik);
            this.btnInit = new System.Windows.Forms.Button();
            btnInit.Text = "iniciar sesión";
            btnInit.Click += new System.EventHandler(btnInit_clik);
            this.tlp.Dock = DockStyle.Fill;

            this.selectRol = new System.Windows.Forms.ComboBox();
            this.fillCombo();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp.RowCount = 4;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.TabIndex = 0;

            this.tlp.Controls.Add(this.lblUser, 0, 0);
            this.tlp.Controls.Add(this.txtUser, 1, 0);
            this.tlp.Controls.Add(this.lblPasword, 0, 1);
            this.tlp.Controls.Add(this.txtPasword, 1, 1);
            lblCombo = new Label();
            lblCombo.Text = "seleccione rol";
            this.tlp.Controls.Add(lblCombo, 0, 2);
            this.tlp.Controls.Add(selectRol, 1,2);
            this.tlp.Controls.Add(this.btnExit, 0, 3);
            this.tlp.Controls.Add(this.btnInit, 1, 3);
            
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 100F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

