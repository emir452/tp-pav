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
            lblUser.Text = "ingrese legajo";
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPasword = new System.Windows.Forms.Label();
            lblPasword.Text = "ingrese contraseña";
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.lblCombo = new System.Windows.Forms.Label();
            lblCombo.Text = "seleccione rol";
            this.selectRol = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            btnExit.Text = "salir";
            btnExit.Click += new System.EventHandler(btnExit_clik);
            this.btnInit = new System.Windows.Forms.Button();
            btnInit.Text = "iniciar sesión";
            this.btnInit.Click += new System.EventHandler(this.btnInit_clik);

            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp.RowCount = 4;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.Controls.Add(this.lblUser, 0, 0);
            this.tlp.Controls.Add(this.txtUser, 1, 0);
            tlp.Controls.Add(lblPasword, 0, 1);
            this.tlp.Controls.Add(this.txtPasword, 1, 1);
            this.tlp.Controls.Add(this.lblCombo, 0, 2);
            this.tlp.Controls.Add(this.selectRol, 1, 2);
            this.tlp.Controls.Add(this.btnExit, 0, 3);
            this.tlp.Controls.Add(this.btnInit, 1, 3);

            this.Controls.Add(this.tlp);
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

