using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace OrganizadorProjeto
{
    internal class BDUser
    {
        private static SQLiteConnection conn; //Variavel que vai contrala a conecção do banco de dasdos

        private static SQLiteConnection ConmBanco()
        {
            conn = new SQLiteConnection("Data Source = D:\\Documentos\\CODIGOS\\OrganizadorProjeto\\OrganizadorProjeto\\BD\\BD_Project.db ");
            conn.Open();
            return conn;
        } //Função que localiza o banco de dados 

        public static DataTable VerificationUser(string sql)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConmBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    adapter = new SQLiteDataAdapter(cmd.CommandText, ConmBanco());
                    adapter.Fill(dt);
                    ConmBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConmBanco().Close();
                throw ex;
            }

        } //Verifica se o usuario esta valido

        public static void CreateUser (User user)
        {
            if (VerificationLogin(user))
            {
                MessageBox.Show("Login ja existe"); //Verifica se ja existe um login igual
                return;
            }
            try
            {
                var cmd = ConmBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO BD_User (T_Name, T_Login, T_Password) VALUES (@nome, @login, @senha)";
                cmd.Parameters.AddWithValue("@nome", user.Name);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@senha", user.Password);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario criado");
                ConmBanco().Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!");
                ConmBanco().Close();
            }

        }  //cria um novo usuario

        public static bool VerificationLogin(User user)
        {
            bool res;
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            var cmd = ConmBanco().CreateCommand();
            cmd.CommandText = "SELECT T_Login FROM BD_User WHERE T_Login ='"+user.Login+"'";
            adapter = new SQLiteDataAdapter(cmd.CommandText, ConmBanco());
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }   //Verifica se o login esta valido
    }
}
