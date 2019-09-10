using System.Windows.Forms;
namespace WindowsFormsApp1
{
    partial class FRMManager
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
            this.Text = "FRMManager";
            menuContainer = new MenuStrip();
            teachersMenu = new MenuStrip();
            studens = new MenuStrip();
            managers = new MenuStrip();
            this.PerformLayout();
        }
        #endregion
        private TableLayoutPanel tlp;
        private MenuStrip menuContainer;
        private MenuStrip teachersMenu;
        private MenuStrip studens;
        private MenuStrip managers;
    }
}