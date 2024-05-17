using c_sharp_opps_Shimshon_Kebebde.BankApp;
using c_sharp_opps_Shimshon_Kebebde.DraftApp;
using c_sharp_opps_Shimshon_Kebebde.SportApp;
using c_sharp_opps_Shimshon_Kebebde.TransportationalApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_opps_Shimshon_Kebebde.shared
{
    public class ProcessManager
    {
        public static void RunMainProcess()
        {
            Console.WriteLine("Choose your pick : ");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                switch (num)
                {
                    case 1:
                        BankAppMain.MainEntry();
                        break;
                    case 2:
                        DraftAppMain.MainEntry();
                        break;
                    case 3:
                        SportAppMain.MainEntry();
                        break;
                    case 4:
                        TransportatinalAppMain.MainEntry();
                        break;
                }
                 num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Error");
          
        }
    }
}
