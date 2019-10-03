using System.Windows.Forms;
namespace WindowsFormsApp1
{
    partial class FRMModifiStudent
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
            this.Text = "FRMModifiStudent";
            tlp = new TableLayoutPanel();
            tlp.RowCount = 2;
            tlp.ColumnCount = 2;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75f));
            lblId = new Label();
            lblId.Text = "ingrese el legajo";
            txtId = new TextBox();
            btnCancel = new Button();
            btnCancel.Text = "cancelar";
            btnCancel.Click += new System.EventHandler(btnCancel_click);
            btnSearch = new Button();
            btnSearch.Text = "buscar";
            btnSearch.Click += new System.EventHandler(btnSearch_click);
            tlp.Controls.Add(lblId, 0, 0);
            tlp.Controls.Add(txtId, 1, 0);
            tlp.Controls.Add(btnCancel, 0, 1);
            tlp.Controls.Add(btnSearch, 1, 1);
            this.Controls.Add(tlp);
            this.ResumeLayout();
        }
        #endregion
        private TableLayoutPanel tlp;
        private Label lblId;
        private TextBox txtId;
        private Button btnCancel;
        private Button btnSearch;
    }
   
}