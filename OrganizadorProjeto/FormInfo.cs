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
    public partial class FormInfo : Form
    {
        string logi = Global.login; //Login que vai identifiar os projetos 
        string nome; //Nome do projeto
        DataTable dtproject = new DataTable(); //Datatable que vai organizar os dados do projeto
        public FormInfo(string nome)
        {
            InitializeComponent();
            this.nome = nome;
        }  

        private void FormInfo_Load(object sender, EventArgs e)
        {
            dtproject = BDProject_CRUD.ReadDataProject(logi, nome);
            label_Name.Text = nome;
            label_Budget.Text = "R$ "+dtproject.Rows[0]["N_StartBudget"].ToString();
            label_StartData.Text = dtproject.Rows[0]["T_StartData"].ToString();
            label_ExpectedDay.Text = dtproject.Rows[0]["T_ExpectedDay"].ToString();
            label_Summary.Text = dtproject.Rows[0]["T_Summary"].ToString();
        } //Mostra informaçoes sobre o projeto em andamento
    }
}
