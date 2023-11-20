using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizadorProjeto
{
    internal class BDProject_CRUD
    {
        private static SQLiteConnection conn; //Variavel que vai contrala a conecção do banco de dasdos

        private static SQLiteConnection ConmBanco()
        {
            conn = new SQLiteConnection("Data Source = D:\\Documentos\\CODIGOS\\OrganizadorProjeto\\OrganizadorProjeto\\BD\\BD_Project.db "); //Loaclização do banco de dados
            conn.Open();
            return conn;
        } //Função que localiza o banco de dados e 

        public static void CreateProject(Project project)
        {
            if (VerificationLogin(project)) //Verifica se ja existe um projeto com mesmo nome
            {
                MessageBox.Show("Ja exixte um projeto com esse nome");
                return;
            }
            try
            {
                var cmd = ConmBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO BD_DataProject (T_Name, T_StartData, T_Summary, N_StartBudget, T_ExpectedDay, B_Status, T_ID, N_Day, N_Time, N_EndBudget) VALUES (@nome, @datai, @resumo, @orcamento, @praso, @status, @login, @dia, @tempo, @gasto)"; //Referencia quais parametos vão ser acresentados e seus nomes de identificação
                //Todos parametros para prenechido pelo ususario 
                cmd.Parameters.AddWithValue("@nome", project.name);
                cmd.Parameters.AddWithValue("@datai", project.startData);
                cmd.Parameters.AddWithValue("@resumo", project.summary);
                cmd.Parameters.AddWithValue("@orcamento", project.startBudget);
                cmd.Parameters.AddWithValue("@praso", project.expectedDate);
                cmd.Parameters.AddWithValue("@status", project.status);
                cmd.Parameters.AddWithValue("@login", project.nameUser);
                //Para colocados para não serem nulos
                cmd.Parameters.AddWithValue("@dia", 0);
                cmd.Parameters.AddWithValue("@tempo", 0);
                cmd.Parameters.AddWithValue("@gasto", 0);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Projeto criado");
                ConmBanco().Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO!" + ex);
                ConmBanco().Close();
            }
        } //Função que cria novos projetos 

        public static bool VerificationLogin(Project project)
        {
            bool res;
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            var cmd = ConmBanco().CreateCommand();
            cmd.CommandText = "SELECT T_Name FROM BD_DataProject WHERE T_Name ='" + project.name + "'"; //Verifica o nome do projeto
            adapter = new SQLiteDataAdapter(cmd.CommandText, ConmBanco());
            adapter.Fill(dt);
            if (dt.Rows.Count > 0) //Se tiver algum retorno
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        } //Verifica se ja existe um projeto com mesmo nome

        public static DataTable ReadProject(string login, bool status)
        {
            
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConmBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT T_Name as 'Nome', T_StartData as 'Data de inicil', N_Time as 'Tempo trabalhado', T_ExpectedDay as 'Dia de entrega' FROM BD_DataProject  WHERE  T_ID = '"+ login +"' AND B_Status = " + status; //seleciona quais parametos quer como retorno e verifica o status do projeto
                    adapter = new SQLiteDataAdapter(cmd.CommandText, ConmBanco());
                    adapter.Fill(dt);
                    ConmBanco().Close();
                    
                }
            }
            catch (Exception ex)
            {
                ConmBanco().Close();
                MessageBox.Show("Erro"+ex);
                
            }
            return dt;
        } //Ler quais projetos estão em andamento ou finalizados
                
        public static DataTable ReadDataProject(string login, string name)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConmBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT T_Name,T_StartData, N_Day, N_Time, T_EndData, N_StartBudget, N_EndBudget, T_Summary, T_ExpectedDay FROM BD_DataProject  WHERE  T_ID = '" + login + "' AND T_Name = '" + name+"'";
                    adapter = new SQLiteDataAdapter(cmd.CommandText, ConmBanco());
                    adapter.Fill(dt);
                    ConmBanco().Close();

                }
            }
            catch (Exception ex)
            {
                ConmBanco().Close();
                MessageBox.Show("Erro" + ex);

            }
            return dt;
        } //Ler todos os dados de um projeto

        public static void UpdateProject(string login, Project p)
        {

            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConmBanco().CreateCommand())
                {
                    cmd.CommandText = "UPDATE BD_DataProject SET N_Day = "+p.day+ ",  N_Time = "+p.time+",  N_EndBudget = "+p.endBudget+",  B_Status= "+p.status+ ",T_EndData = '"+p.endData+"'   WHERE  T_ID = '" + login + "' AND T_Name = '" + p.name+"'";
                    adapter = new SQLiteDataAdapter(cmd.CommandText, ConmBanco());
                    cmd.ExecuteNonQuery();
                    ConmBanco().Close();

                }
            }
            catch (Exception ex)
            {
                ConmBanco().Close();
                MessageBox.Show("Erro" + ex);

            }
            
        } //faz atualizaçoes em projetos selecionados 

        public static void DeleteProject(string login, string name)
        {

            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConmBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM BD_DataProject WHERE  T_ID = '" + login + "' AND T_Name = '" + name + "'";
                    adapter = new SQLiteDataAdapter(cmd.CommandText, ConmBanco());
                    cmd.ExecuteNonQuery();
                    ConmBanco().Close();

                }
            }
            catch (Exception ex)
            {
                ConmBanco().Close();
                MessageBox.Show("Erro" + ex);

            }

        } //Deleta algum projeto que o usuario queira 
    }



   
}

