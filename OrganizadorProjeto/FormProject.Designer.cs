namespace OrganizadorProjeto
{
    partial class FormProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Day = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Budget = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Control = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Record = new System.Windows.Forms.Button();
            this.textBox_Record = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Stopwatch = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.aDDProjectToolStripMenuItem,
            this.completedToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
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
            this.aDDProjectToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aDDProjectToolStripMenuItem.Text = "Delete";
            this.aDDProjectToolStripMenuItem.Click += new System.EventHandler(this.aDDProjectToolStripMenuItem_Click);
            // 
            // completedToolStripMenuItem
            // 
            this.completedToolStripMenuItem.Name = "completedToolStripMenuItem";
            this.completedToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.completedToolStripMenuItem.Text = "Completed";
            this.completedToolStripMenuItem.Click += new System.EventHandler(this.completedToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
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
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dias: ";
            // 
            // label_Day
            // 
            this.label_Day.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Day.Location = new System.Drawing.Point(50, 34);
            this.label_Day.Name = "label_Day";
            this.label_Day.Size = new System.Drawing.Size(40, 23);
            this.label_Day.TabIndex = 5;
            this.label_Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Time
            // 
            this.label_Time.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Time.Location = new System.Drawing.Point(137, 34);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(85, 23);
            this.label_Time.TabIndex = 7;
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horas:";
            // 
            // label_Budget
            // 
            this.label_Budget.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Budget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Budget.Location = new System.Drawing.Point(293, 34);
            this.label_Budget.Name = "label_Budget";
            this.label_Budget.Size = new System.Drawing.Size(64, 23);
            this.label_Budget.TabIndex = 9;
            this.label_Budget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Orçamento:";
            // 
            // button_Control
            // 
            this.button_Control.Location = new System.Drawing.Point(15, 234);
            this.button_Control.Name = "button_Control";
            this.button_Control.Size = new System.Drawing.Size(75, 23);
            this.button_Control.TabIndex = 10;
            this.button_Control.Text = "INICIAR";
            this.button_Control.UseVisualStyleBackColor = true;
            this.button_Control.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "FINALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Record
            // 
            this.button_Record.Location = new System.Drawing.Point(282, 234);
            this.button_Record.Name = "button_Record";
            this.button_Record.Size = new System.Drawing.Size(75, 23);
            this.button_Record.TabIndex = 12;
            this.button_Record.Text = "Registra";
            this.button_Record.UseVisualStyleBackColor = true;
            this.button_Record.Click += new System.EventHandler(this.button_Record_Click);
            // 
            // textBox_Record
            // 
            this.textBox_Record.Location = new System.Drawing.Point(282, 208);
            this.textBox_Record.Name = "textBox_Record";
            this.textBox_Record.Size = new System.Drawing.Size(75, 20);
            this.textBox_Record.TabIndex = 13;
            this.textBox_Record.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Stopwatch
            // 
            this.label_Stopwatch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Stopwatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Stopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stopwatch.Location = new System.Drawing.Point(15, 87);
            this.label_Stopwatch.Name = "label_Stopwatch";
            this.label_Stopwatch.Size = new System.Drawing.Size(342, 109);
            this.label_Stopwatch.TabIndex = 14;
            this.label_Stopwatch.Text = "00:00:00";
            this.label_Stopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 267);
            this.Controls.Add(this.label_Stopwatch);
            this.Controls.Add(this.textBox_Record);
            this.Controls.Add(this.button_Record);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Control);
            this.Controls.Add(this.label_Budget);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormProject";
            this.ShowIcon = false;
            this.Tag = "";
            this.Text = "FormPreject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProject_FormClosing);
            this.Load += new System.EventHandler(this.FormProject_Load);
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
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Day;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Budget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Control;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Record;
        private System.Windows.Forms.TextBox textBox_Record;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Stopwatch;
    }
}