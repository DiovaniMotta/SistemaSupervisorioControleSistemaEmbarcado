using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaSupervisorio
{
    /* @autor Diovani Bernardi da Motta
     *
     * Classe responsavel por executar o fluxo principal do programa 
     * **/

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles(); // habilitação dos efeitos graficos usados pelo form
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioPrincipal()); // inicialização da janela de execução
        }
    }
}
