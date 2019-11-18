using System.Windows.Forms;
namespace presentation
{
    partial class FRMDeleteStudent
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
            this.Text = "FRMDeleteStudent";
            tlp = new TableLayoutPanel();
            tlp.RowCount = 4;
            tlp.ColumnCount = 2;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
            lblId = new Label();
            lblId.Text = "ingrese el legajo  del estudiante que desea modificar";
            txtId = new TextBox();
            btnCalcel = new Button();
            btnCalcel.Text = "cancelar";
            btnCalcel.Click += new System.EventHandler(btnCancel_click);
            btnSearch = new Button();
            btnSearch.Text = "buscar";
            btnSearch.Click += new System.EventHandler(btnSearch_click);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tlp;
        private Label lblId;
        private TextBox txtId;
        private Button btnCalcel;
        private Button btnSearch;
        private Label lblName;
        private Label lblNameInformation;
        private Label lblSurname;
        private Label lblInformationSurname;
        private Label lblDni;
        private Label lblInformationDni;
        private Button btnDeleteStudent;

    }
}