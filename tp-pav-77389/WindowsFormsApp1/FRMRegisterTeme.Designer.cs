using System.Windows.Forms;
namespace WindowsFormsApp1
{
    partial class FRMRegisterTeme
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
            this.Text = "registrar tema ";
            txtName = new TextBox();
            txtDescription = new TextBox();
            tlpButtons = new TableLayoutPanel();
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.ColumnCount = 2;
            tlpButtons.RowCount = 1;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            btnCancel = new Button();
            btnCancel.Text = "cancelar";
            btnCancel.Click += new System.EventHandler(btnCancel_click);
            btnRegisterTeme = new Button();
            btnRegisterTeme.Text = "registrar tema";
            btnRegisterTeme.Click += new System.EventHandler(btnRegisterTeme_click);
            tlpButtons.Controls.Add(btnCancel, 0, 0);
            tlpButtons.Controls.Add(btnRegisterTeme, 1, 0);
            view = new ListBox();
            view.Dock = DockStyle.Fill;
            view.Controls.Add(txtName);
            view.Controls.Add(txtDescription);
            view.Controls.Add(tlpButtons);
        }

        #endregion
        private ListBox view ;
        private TextBox txtName;
        private TextBox txtDescription;
        private TableLayoutPanel tlpButtons;
        private Button btnRegisterTeme;
        private Button btnCancel;

    }
}