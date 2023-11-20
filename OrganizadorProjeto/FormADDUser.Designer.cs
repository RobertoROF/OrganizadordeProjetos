namespace OrganizadorProjeto
{
    partial class FormADDUser
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Confirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.checkBox_Display = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(12, 29);
            this.textBox_Name.MaxLength = 30;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(155, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(12, 74);
            this.textBox_Login.MaxLength = 15;
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(155, 20);
            this.textBox_Login.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(12, 117);
            this.textBox_Password.MaxLength = 10;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(155, 20);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(9, 101);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(41, 13);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Senha:";
            // 
            // textBox_Confirm
            // 
            this.textBox_Confirm.Location = new System.Drawing.Point(12, 162);
            this.textBox_Confirm.MaxLength = 10;
            this.textBox_Confirm.Name = "textBox_Confirm";
            this.textBox_Confirm.Size = new System.Drawing.Size(155, 20);
            this.textBox_Confirm.TabIndex = 7;
            this.textBox_Confirm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirme a senha:";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(103, 188);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(61, 27);
            this.button_Create.TabIndex = 8;
            this.button_Create.Text = "Criar";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // checkBox_Display
            // 
            this.checkBox_Display.AutoSize = true;
            this.checkBox_Display.Location = new System.Drawing.Point(12, 188);
            this.checkBox_Display.Name = "checkBox_Display";
            this.checkBox_Display.Size = new System.Drawing.Size(83, 17);
            this.checkBox_Display.TabIndex = 9;
            this.checkBox_Display.Text = "Exibir senha";
            this.checkBox_Display.UseVisualStyleBackColor = true;
            this.checkBox_Display.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormADDUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 220);
            this.Controls.Add(this.checkBox_Display);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textBox_Confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormADDUser";
            this.ShowIcon = false;
            this.Text = "FormADDUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Confirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.CheckBox checkBox_Display;
    }
}