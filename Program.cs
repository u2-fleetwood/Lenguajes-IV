using System;
using System.Windows.Forms;

namespace ConversorMonedas
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Inicia Form1 como ventana principal
        }
    }
}