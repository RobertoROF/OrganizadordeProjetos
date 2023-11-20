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
    public partial class FormPrincipal : Form
    {
        string login;
        string nomeUser;
        Thread nt;
        string nome;
        public FormPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false; //Tira todas as opçoes da trakbar 
            this.login = Global.login; //Login que identica os projetos de cada 
            this.nomeUser = Global.Username; //Nome do usuaria que vai ser usado para as boas vindas
            label2.Text = nomeUser; //Mosta o nome do usuario
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do aplicativo?", "Exit", MessageBoxButtons.YesNo); //Messsgem perguntando se quer mesmo fechar o forms
            if (result == DialogResult.Yes) // Se a resposta for sim
            {
                this.Close(); //Fecha o forms
            }
        } //Fecha o formilario

        private void aDDProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //Abre o forms para cadastra um novo projeto
            nt = new Thread(FormADD);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        } // Abre o formularia que cadastra novos 

        private void FormADD()
        {
            Application.Run(new FormADDProject());
        } //Funça que chama o formADDProject

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            bool status = true;
            dataGridView_Preview.DataSource = BDProject_CRUD.ReadProject(login, status); //Mosta os projetos em andamento no datagridviwe de acordo com que é o usuario
        } //Função rodada quando abre a fomrs

        private void dataGridView_Preview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = (DataGridView)sender;
            nome = data.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
            nt = new Thread(Form_Project);
            nt.SetApartmentState (ApartmentState.STA);
            nt.Start();
        } //Quando seleciona uma celular abre o forms do projeto com as informçoes

        private void Form_Project()
        {
            Application.Run(new FormProject(nome));
        }

        private void completedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(FormComp);
            nt.SetApartmentState (ApartmentState.STA);
            nt.Start();
        } //Abre o forms de projetos completos

        private void FormComp()
        {
            Application.Run(new FormComplet());
        } //Função qua chama o formComplet
    }
}
