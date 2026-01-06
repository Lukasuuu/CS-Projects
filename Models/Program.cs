using System;
using System.Windows.Forms;
using AGP.Forms;

namespace AGP.Models
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {   //Application.Run(new FormLixo());
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            //Application.Run(new FormProcessos());
            //Application.Run(new FormLinhasProcesso());
            //Application.Run(new FormPrioridades());
            //Application.Run(new FormCategorias());
            //Application.Run(new FormClientes());
            //Application.Run(new FormEstados());
            //Application.Run(new FormFuncionarios());
        }
    }
}
