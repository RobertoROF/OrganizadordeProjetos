using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizadorProjeto
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
        public static void IntNuber(KeyPressEventArgs e)//Comtrola oq pode ser escrito no textBox
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 = delete e 44 = virgula
            {
                e.Handled = true;
            }
        }
    }
}
