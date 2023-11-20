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
    public partial class FormADDProject : Form
    {
        Thread nt; //Variavel para abrir novos formis
        string login = Global.login; //Login que vai identificar os projetos 

        public FormADDProject()
        {
            InitializeComponent();
            this.ControlBox = false; //Tira todas as opçoes da trakbar 
            textBox_Date.Text = string.Format("{0:dd\\-MM\\-yyyy}", DateTime.Now); //Dis a data de hj
        }

        private void textBox_Budget_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNuber(e);
        } //Não permite que letras sejam digitadas 

        private void checkBox_Budget_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox_Budget.Enabled)
            {
                textBox_Budget.Text = "00";
                textBox_Budget.Enabled = false;
            }
            else
            {
                textBox_Budget.Text = "";
                textBox_Budget.Enabled = true;
            }
        } //Verifica se checkbox esta marcado e sinaliza o projeto como sem orçamento

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Deseja sair do aplicativo?", "Exit", MessageBoxButtons.YesNo); //Messsgem perguntando se quer mesmo fechar o forms
            if (result == DialogResult.Yes) // Se a resposta for sim
            {
                this.Close(); //Fecha o forms
            }
        } //Fecha o aplicaivo

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox_Budget.Text != ""  || textBox_Name.Text != "" || textBox_Summary.Text != "") //Verifica se algum dados ja foi digitado
            {
                DialogResult results = MessageBox.Show("Tocar de Formulario? As alterações feitas não seram salvas", "", MessageBoxButtons.YesNo); //Messsgem perguntando se quer mesmo fechar o forms
                if (results == DialogResult.Yes) // Se a resposta for sim
                {
                    this.Close();
                    nt = new Thread(Form_Principal);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                }
            }
            else
            {
                this.Close();
                nt = new Thread(Form_Principal);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            
        } //Volta para pagina principal

        private void Form_Principal()
        {
            Application.Run(new FormPrincipal());
        } //Funsão que chama o forms principal

        private void completedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox_Budget.Text != ""  || textBox_Name.Text != "" || textBox_Summary.Text != "") //Verifica se algum dado ja foi digitado
            {
                DialogResult results = MessageBox.Show("Tocar de Formulario? As alterações feitas não seram salvas", "", MessageBoxButtons.YesNo); //Messsgem perguntando se quer mesmo fechar o forms
                if (results == DialogResult.Yes) // Se a resposta for sim
                {
                    this.Close();
                    nt = new Thread(Form_Complet);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();

                }
            }
            else
            {
                this.Close();
                nt = new Thread(Form_Complet);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        } //Abre o forms com os projetos compelto

        private void Form_Complet()
        {
           Application.Run(new FormComplet());
        } //Funsão que chama o forms dos projetos complertos

        private void button_Create_Click(object sender, EventArgs e)
        {
            if (textBox_Budget.Text != "" && textBox_Date.Text != "" && textBox_Name.Text != "" && textBox_Summary.Text != "") //Verifica se tem algum campo em branco
            {
                if (dateTimePicker_ExpectedDay.Value < DateTime.Now) //Verifica a data de entrega do projeto
                {
                    MessageBox.Show("Data invalidas");
                    return;

                }
                Project project = new Project();
                project.name = textBox_Name.Text;
                project.summary = textBox_Summary.Text;
                project.status = true;
                project.startBudget = (Math.Round(double.Parse(textBox_Budget.Text), 2));
                project.expectedDate = string.Format("{0:dd\\-MM\\-yyyy}", dateTimePicker_ExpectedDay.Value.Date);
                project.startData = textBox_Date.Text;
                project.nameUser = login;

                BDProject_CRUD.CreateProject(project);
                FormADDProject_Load(sender, e);
                
            }
            else
            {
                MessageBox.Show("Confira os dados prencidos");
            }
        }  //Salva dos dados digitados como um novo projeto

        private void FormADDProject_Load(object sender, EventArgs e)
        {
            dateTimePicker_ExpectedDay.Value = DateTime.Now;
            textBox_Name.Clear();
        }
    }
}
