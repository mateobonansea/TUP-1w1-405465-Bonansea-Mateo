using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            party val = party.Medio;
            switch (val)
            {
                case party.Malo:
                    Console.WriteLine("Nivel bajo");
                    break;
                case party.Medio:
                    Console.WriteLine("Nivel medio");
                    break;
                case party.Alto:
                    Console.WriteLine("Nivel alto");
                    break;
            }
        }



               enum party

        {
            Malo,
            Medio,
            Alto
        }
        
        
           
            }
        }
   

