using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizadorProjeto
{
    public partial class FormADDUser : Form
    {
        public FormADDUser()
        {
            InitializeComponent();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            
            if(textBox_Name.Text != "" && textBox_Login.Text != "" && textBox_Password.Text != "" && textBox_Confirm.Text != "")// Verifica se ainda tem algum campo vazio
            {
                if( textBox_Confirm.Text == textBox_Password.Text ) // Verifica se as senhas estão iguais
                {
                    // Transfere todos os parametros digitados para o objeto "User"
                    User user = new User();
                    user.Name = textBox_Name.Text;
                    user.Login = textBox_Login.Text;
                    user.Password = textBox_Password.Text;
                    BDUser.CreateUser(user);
                    textBox_Confirm.Clear();
                    textBox_Password.Clear();
                }
                else
                {
                    MessageBox.Show("Senha não condisentes");
                }
            }
            else
            {
                MessageBox.Show("Dados incompletos");
            }
        } //Usa dos dados digitados para criar um novo funcionario 

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Verifica se Checkbox foi selecionada
        {
            if (textBox_Password.UseSystemPasswordChar) // se a senha tiver ocuta ele fica visivel
            {
                textBox_Password.UseSystemPasswordChar = false;
                textBox_Confirm.UseSystemPasswordChar=false;
            }
            else // se não fica oculta 
            {
                textBox_Confirm.UseSystemPasswordChar = true;
                textBox_Password.UseSystemPasswordChar = true;
            }
        }
    }
}
