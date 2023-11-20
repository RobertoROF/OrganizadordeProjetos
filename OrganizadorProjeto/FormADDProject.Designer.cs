namespace OrganizadorProjeto
{
    partial class FormADDProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Budget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Budget = new System.Windows.Forms.CheckBox();
            this.textBox_Summary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.dateTimePicker_ExpectedDay = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.aDDProjectToolStripMenuItem,
            this.completedToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // aDDProjectToolStripMenuItem
            // 
            this.aDDProjectToolStripMenuItem.Name = "aDDProjectToolStripMenuItem";
            this.aDDProjectToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.aDDProjectToolStripMenuItem.Text = "ADD Project";
            // 
            // completedToolStripMenuItem
            // 
            this.completedToolStripMenuItem.Name = "completedToolStripMenuItem";
            this.completedToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.completedToolStripMenuItem.Text = "Completed";
            this.completedToolStripMenuItem.Click += new System.EventHandler(this.completedToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(12, 53);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(111, 20);
            this.textBox_Name.TabIndex = 5;
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(138, 53);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(111, 20);
            this.textBox_Date.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data:";
            // 
            // textBox_Budget
            // 
            this.textBox_Budget.Location = new System.Drawing.Point(138, 101);
            this.textBox_Budget.Name = "textBox_Budget";
            this.textBox_Budget.Size = new System.Drawing.Size(111, 20);
            this.textBox_Budget.TabIndex = 11;
            this.textBox_Budget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Budget_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Orçamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Praso:";
            // 
            // checkBox_Budget
            // 
            this.checkBox_Budget.AutoSize = true;
            this.checkBox_Budget.Location = new System.Drawing.Point(138, 124);
            this.checkBox_Budget.Name = "checkBox_Budget";
            this.checkBox_Budget.Size = new System.Drawing.Size(100, 17);
            this.checkBox_Budget.TabIndex = 12;
            this.checkBox_Budget.Text = "Sem orçamento";
            this.checkBox_Budget.UseVisualStyleBackColor = true;
            this.checkBox_Budget.CheckedChanged += new System.EventHandler(this.checkBox_Budget_CheckedChanged);
            // 
            // textBox_Summary
            // 
            this.textBox_Summary.Location = new System.Drawing.Point(12, 147);
            this.textBox_Summary.MaxLength = 690;
            this.textBox_Summary.Multiline = true;
            this.textBox_Summary.Name = "textBox_Summary";
            this.textBox_Summary.Size = new System.Drawing.Size(237, 123);
            this.textBox_Summary.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Resumo";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(174, 276);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 15;
            this.button_Create.Text = "Salvar";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // dateTimePicker_ExpectedDay
            // 
            this.dateTimePicker_ExpectedDay.Location = new System.Drawing.Point(12, 100);
            this.dateTimePicker_ExpectedDay.Name = "dateTimePicker_ExpectedDay";
            this.dateTimePicker_ExpectedDay.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker_ExpectedDay.TabIndex = 16;
            this.dateTimePicker_ExpectedDay.Value = new System.DateTime(2023, 10, 25, 19, 45, 10, 0);
            // 
            // FormADDProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 303);
            this.Controls.Add(this.dateTimePicker_ExpectedDay);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textBox_Summary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_Budget);
            this.Controls.Add(this.textBox_Budget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormADDProject";
            this.Text = "FormADDProjet";
            this.Load += new System.EventHandler(this.FormADDProject_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Budget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Budget;
        private System.Windows.Forms.TextBox textBox_Summary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ExpectedDay;
    }
}