using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    public delegate void pageHandler(String pageName);
     
    public static class EvenNotifier
    {
        public static event pageHandler PageChanged;

        public static void RaisePageChanged(string pageName)
       {
            if(PageChanged != null)
            {
                PageChanged(pageName);
            }
           
        }
    }

    
}
