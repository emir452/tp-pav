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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "iniciar seción";
        tlp =new TableLayoutPanel();
            tlp.RowCount = 3;
            tlp.ColumnCount = 2;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            lblUser = new Label();
            lblUser.Text = "nomre de usuario usuario";
            txtUser = new TextBox();
            lblPasword = new Label();
            lblPasword.Text = "contraseña";
            txtPasword = new TextBox();
            btnInit = new Button();
            btnInit.Text = "iniciar sesión";
            btnInit.Click += new System.EventHandler(this.btnInit_clik);
            btnExit = new Button();
            btnExit.Text = "salir";
            this.Load += new System.EventHandler(FRMlogin_load);
            this.ResumeLayout(true);
        }


        #endregion
        private TableLayoutPanel tlp;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblPasword;
        private TextBox txtPasword;
        private Button btnInit;
        private Button btnExit;

        
    }
    
}

