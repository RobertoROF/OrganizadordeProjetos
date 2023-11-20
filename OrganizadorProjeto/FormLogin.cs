using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizadorProjeto
{
    public partial class FormLogin : Form
    {
        DataTable dt = new DataTable();//Variave que vai guarda os resuldados do banco de dados
        Thread nt;//Nariavel para abrir um novo forms
        string login; //Armazena o login
        string nomeUser; //Armazeno nome do usuario 

        public FormLogin()
        {
            InitializeComponent();
        }


        private void button_Login_Click(object sender, EventArgs e)
        {
            login = textBox_Login.Text; // Atribui o login do usuario a variavel Login
            string password = textBox_Password.Text; // A tribui a senha a variavel password
            if (login == "" || password == "") // Verifica se tem algum campo vazil
            {
                MessageBox.Show("Senha ou Login invalidos");
                return;
            }

            string sql = "SELECT * FROM BD_User WHERE T_Login = '" + login+ "' AND T_Password ='" + password+"'"; //Endereço da planilha do banco de dados e os dados que tem que ser buscado
            dt = BDUser.VerificationUser(sql); // Execulta a função que verifica os usuarios da classe BDUser_CRUD
            if(dt.Rows.Count == 1 ) //Nerifica se tem teve uma resposta do banco de dados
            {
                
                Global.Username = dt.Rows[0].ItemArray[1].ToString(); //Armazena o nome do usuario
                Global.login = dt.Rows[0].ItemArray[2].ToString(); //Armazena o login do usuariao
                this.Close(); //Frcha o forms de logun
                //Abre o forms principal 
                nt = new Thread(Forms_principal);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Senha ou Login invalidos");
            }
        } //Usa os dados para entra no aplicativo com o login do usuario correto 

        private void Forms_principal()
        {
            
            Application.Run(new FormPrincipal());
        } //Chama o forms principal 

        private void linkLabel_Create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abre o forms para cadastra um novo usuario
            nt = new Thread(Forms_ADDUser);
            nt.SetApartmentState (ApartmentState.STA);
            nt.Start();
        } //Função que abre o forms para cadastra novo usuario 

        private void Forms_ADDUser()
        {
            Application.Run(new FormADDUser());
        } //Chama o forms de criação de usuarios 
    }
}
