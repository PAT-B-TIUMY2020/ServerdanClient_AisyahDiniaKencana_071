using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Forms;
using ServiceMtk_P1_20180140071;

namespace Server_AisyahDiniaKencana_071
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public class ServerHidup
        {
            public void OnSer()
            {
                ServiceHost hostObj = null;
                try
                {
                    hostObj = new ServiceHost(typeof(Matematika));
                    hostObj.Open();
                    Console.WriteLine("Server is Ready!!!");
                    Console.ReadLine();
                    hostObj.Close();
                }
                catch (Exception ex)
                {
                    hostObj = null;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }

            public void OffSer()
            {
                ServiceHost hostObj = null;
                try
                {
                    hostObj = new ServiceHost(typeof(Matematika));
                    hostObj.Close();
                    Console.WriteLine("Server is Ready!!!");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    hostObj = null;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}
