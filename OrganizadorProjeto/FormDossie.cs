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
    public partial class FormDossie : Form
    {
        string login = Global.login; //Login que vai identificar os projetos 
        string nomeProject; //Nome do projeto
        DataTable dtProject = new DataTable(); //Datatable que vai organizar os dados do projeto selecionados 
        public FormDossie(string nomeProject)
        {
            InitializeComponent();
            this.nomeProject = nomeProject;
        }

        private void FormDossie_Load(object sender, EventArgs e)
        {
            dtProject = BDProject_CRUD.ReadDataProject(login, nomeProject);
            label_Name.Text = dtProject.Rows[0]["T_Name"].ToString();
            TimeConversion(dtProject.Rows[0]["N_Time"].ToString());
            label_Day.Text = dtProject.Rows[0]["N_Day"].ToString();
            label_BudgetEnd.Text = "R$ "+dtProject.Rows[0]["N_EndBudget"].ToString();
            label_BudgetStart.Text = "R$ " + dtProject.Rows[0]["N_StartBudget"].ToString();
            label_DeliveryEnd.Text = dtProject.Rows[0]["T_EndData"].ToString();
            label_DeliveryStart.Text = dtProject.Rows[0]["T_ExpectedDay"].ToString();
            label_Summary.Text = dtProject.Rows[0]["T_Summary"].ToString();

        } //Chama a função que chema os dados do projeto e organiza nas labels

        private void TimeConversion (string time)
        {
            int totalSegundo = int.Parse(time);

            TimeSpan tempo = TimeSpan.FromSeconds(totalSegundo);
            label_Hour.Text = string.Format("{0:D2}h:{1:D2}m:{2:D2}s", tempo.Hours, tempo.Minutes, tempo.Seconds);
        } //Converte o tempo em segundos para horas
    }
}
