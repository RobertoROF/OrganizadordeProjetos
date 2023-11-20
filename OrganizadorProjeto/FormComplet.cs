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
    public partial class FormComplet : Form
    {
        string login = Global.login; //Login que vai identificar os dados do usuario 
        Thread nt;
        string nome;
        public FormComplet()
        {
            InitializeComponent();
            this.ControlBox = false; //Tira todas as opçoes da trakbar 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Deseja fecha o aplicativo?", "EXIT", MessageBoxButtons.YesNo); //Messsgem perguntando se quer mesmo fechar o forms
            if (results == DialogResult.Yes) // Se a resposta for sim
            {
                this.Close();
            }
        } //Fecha o aplicativo

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(Form_Principal);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        } //Volta para pagina principal

        private void Form_Principal()
        {
            Application.Run(new FormPrincipal());
        } //Chama o forms principal

        private void aDDProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(FormADD);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        } //Abre o forms para criar projetos

        private void FormADD()
        {
            Application.Run(new FormADDProject());
        }

        private void FormComplet_Load(object sender, EventArgs e)
        {
            bool status = false;
            dataGridView_Preview.DataSource = BDProject_CRUD.ReadProject(login, status); //Mosta os projetos em andamento no datagridviwe de acordo com que é o usuario
        } //Separa todos os programas que estão concluidos 
        private void dataGridView_Preview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = (DataGridView)sender;
            nome = data.SelectedRows[0].Cells[0].Value.ToString();
            nt = new Thread(form_Dosssie);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        } //Quando clica em um projeto abre o dosssie

        private void form_Dosssie()
        {
            Application.Run(new FormDossie(nome));
        }
    }
}
