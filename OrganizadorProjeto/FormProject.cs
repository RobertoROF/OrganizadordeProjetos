using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace OrganizadorProjeto
{
    public partial class FormProject : Form
    {
        private Stopwatch stopwatch = new Stopwatch(); //Variavel referente ao cronometro
        Thread nt; //Variavel para abrir novos forms
        int time; //variavel para registra o tempo 
        double money; //Variavel para registra o gasto
        string date; //Dia quem o forms foi fechado
        string login = Global.login; //Login do usuario
        string nome; //Nome do projeto
        DataTable dtProject = new DataTable(); //Datatable que organiza os dados do projeto
        bool status = true; //Status do projeto
        double ValorTemp; //Armasenar temporariamente o valor do orçamento restante
        public FormProject(string nome)
        {
            this.nome = nome;
            InitializeComponent();
            this.ControlBox = false; //Tira todas as opçoes da trakbar 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                stopwatch.Start();
                button_Control.Text = "PAUZAR";
            }
            else
            {
                timer1.Enabled = false;
                stopwatch.Stop();
                button_Control.Text = "Iniciar";
            }
        } //Contorla o cronometro pauzando ou iniciando 

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label_Stopwatch.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
            time++;
        } //Registra a passagem do tempo

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do aplicativo?", "Exit", MessageBoxButtons.YesNo); //Messsgem perguntando se quer mesmo fechar o forms
            if (result == DialogResult.Yes) // Se a resposta for sim
            {
                this.Close(); //Fecha o forms
            }
        } //Sai do aplicativo

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(Form_Principal);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        } //Volta para pagina inicial

        private void Form_Principal()
        {
            Application.Run(new FormPrincipal());
        }

        private void completedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(FormComp);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        } //Vai para aba de projetos completos

        private void FormComp()
        {
            Application.Run(new FormComplet());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNuber(e);
        } //Não deixa escrever numeros no textbox

        private void button_Record_Click(object sender, EventArgs e)
        {
            money += double.Parse(textBox_Record.Text) ;
            label_Budget.Text = "R$ "+( ValorTemp - money).ToString() ;
            textBox_Record.Clear();
        } //Regista o gastosdo projeto

        private void FormProject_Load(object sender, EventArgs e)
        {
            dtProject = BDProject_CRUD.ReadDataProject(login, nome);
            if (dtProject.Rows[0]["N_StartBudget"].ToString() == "0") //Verifica se o projeto tem orçamento
            {
                textBox_Record.Enabled = false;
                button_Record.Enabled = false;
                
            }
            ValorTemp = double.Parse(dtProject.Rows[0]["N_StartBudget"].ToString()) - double.Parse(dtProject.Rows[0]["N_EndBudget"].ToString());
            label_Budget.Text ="R$ "+ (ValorTemp).ToString();
            label_Day.Text = dtProject.Rows[0]["N_Day"].ToString();
            TimeConversion(dtProject.Rows[0]["N_Time"].ToString());            
        }  //Organiza os dados do projeto nas labels 

        private void FormProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( time > 0 )
            {
                date = string.Format("{0:dd\\-MM\\-yyyy}", DateTime.Now);
                Project project = new Project();
                if (dtProject.Rows[0]["T_EndData"].ToString() != date)
                {
                    project.day = int.Parse(dtProject.Rows[0]["N_Day"].ToString()) + 1;
                }
                else
                {
                    project.day = int.Parse(dtProject.Rows[0]["N_Day"].ToString());
                }
                project.time = int.Parse(dtProject.Rows[0]["N_Time"].ToString()) + time;
                project.endBudget = double.Parse(dtProject.Rows[0]["N_EndBudget"].ToString()) + money;
                project.status = status;
                project.endData = date;
                project.name = nome;
                BDProject_CRUD.UpdateProject(login, project);
            }
            
        } //Salva todas as alteraçoes feitas no avanço do projeto

        private void TimeConversion(string time)
        {
            int totalSegundo = int.Parse(time);

            TimeSpan tempo = TimeSpan.FromSeconds(totalSegundo);
            label_Time.Text = string.Format("{0:D2}h:{1:D2}m:{2:D2}s", tempo.Hours, tempo.Minutes, tempo.Seconds);
        } //Converte os segundos trabalhados em horas

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja finalizar esse projeto?", "", MessageBoxButtons.YesNo); //Messsgem perguntando se quer mesmo fechar o forms
            if (result == DialogResult.Yes) // Se a resposta for sim
            {
                status = false;
                homeToolStripMenuItem_Click(sender, e);
            }
        } //Finaliza o projeto 

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            nt = new Thread(Form_info);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        } //Abre a aba com mais informaçoes do projeto

        private void Form_info()
        {
            Application.Run( new FormInfo(nome) );
        }

        private void aDDProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja deletar esse projeto?", "", MessageBoxButtons.YesNo); //Messsgem perguntando se quer mesmo fechar o forms
            if (result == DialogResult.Yes) // Se a resposta for sim
            {
                DialogResult results = MessageBox.Show("Qunado o projeto for deledo, não podera ser recuperado", "", MessageBoxButtons.YesNo); //Messsgem perguntando se quer mesmo fechar o forms
                if (result == DialogResult.Yes) // Se a resposta for sim
                {
                    BDProject_CRUD.DeleteProject(login, nome);
                    homeToolStripMenuItem_Click(sender, e );
                }
            }
        } //Delata o projeto permanentemente
    }
}
