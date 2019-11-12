using System.Windows.Forms;
namespace  WindowsFormsApp1 
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
            this.Text = "";
            tlp = new TableLayoutPanel();
            menuContainer = new MenuStrip();
            students = new ToolStrip();
            students.Text = "estudiantes";
            students.Items.Add("registrar estudiante", null, new System.EventHandler(itemRegisterStudent_click));
            students.Items.Add("modificar estudiante", null, new System.EventHandler(itemModifiStudent_click));
            students.Items.Add("eliminar estudiante", null, new System.EventHandler(itemDeleteStudent_click));
            teachers = new ToolStrip();
            teachers.Text = "profesores";
            teachers.Items.Add("registrar profesor", null, new System.EventHandler(itemRegisterTeacher_click));
            teachers.Items.Add("modificar profesor", null, new System.EventHandler(itemModifiTeacher_click));
            teachers.Items.Add("eliminar profesor", null, new System.EventHandler(itemDeleteTeacher_Click));
            temes = new ToolStrip();
            temes.Text = "temas";
            temes.Items.Add("registrar tema", null, new System.EventHandler(itemRegisterTeme_click));
            menuContainer.Container.Add(teachers);
            menuContainer.Container.Add(students);
            menuContainer.Container.Add(temes);
            this.Controls.Add(menuContainer);

             }

        #endregion
        private TableLayoutPanel tlp;
        private MenuStrip menuContainer;
        private ToolStrip students;
        private ToolStrip teachers;
        private ToolStrip temes;
        // finaliza código 
    }
}