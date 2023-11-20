namespace OrganizadorProjeto
{
    partial class FormInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Budget = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_ExpectedDay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_StartData = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Summary = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Name.Location = new System.Drawing.Point(86, 13);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(128, 19);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Nome:";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Budget
            // 
            this.label_Budget.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Budget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Budget.Location = new System.Drawing.Point(294, 13);
            this.label_Budget.Name = "label_Budget";
            this.label_Budget.Size = new System.Drawing.Size(128, 19);
            this.label_Budget.TabIndex = 3;
            this.label_Budget.Text = "Nome:";
            this.label_Budget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Orçamento:";
            // 
            // label_ExpectedDay
            // 
            this.label_ExpectedDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ExpectedDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ExpectedDay.Location = new System.Drawing.Point(294, 47);
            this.label_ExpectedDay.Name = "label_ExpectedDay";
            this.label_ExpectedDay.Size = new System.Drawing.Size(128, 19);
            this.label_ExpectedDay.TabIndex = 7;
            this.label_ExpectedDay.Text = "Nome:";
            this.label_ExpectedDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Previsão:";
            // 
            // label_StartData
            // 
            this.label_StartData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_StartData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_StartData.Location = new System.Drawing.Point(86, 47);
            this.label_StartData.Name = "label_StartData";
            this.label_StartData.Size = new System.Drawing.Size(128, 19);
            this.label_StartData.TabIndex = 5;
            this.label_StartData.Text = "Nome:";
            this.label_StartData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Data de inicio:";
            // 
            // label_Summary
            // 
            this.label_Summary.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Summary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Summary.Location = new System.Drawing.Point(8, 85);
            this.label_Summary.Name = "label_Summary";
            this.label_Summary.Size = new System.Drawing.Size(414, 108);
            this.label_Summary.TabIndex = 9;
            this.label_Summary.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Resumo do projeto:";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 203);
            this.Controls.Add(this.label_Summary);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_ExpectedDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_StartData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_Budget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label1);
            this.Name = "FormInfo";
            this.ShowIcon = false;
            this.Text = "FormInfo";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Budget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_ExpectedDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_StartData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Summary;
        private System.Windows.Forms.Label label12;
    }
}