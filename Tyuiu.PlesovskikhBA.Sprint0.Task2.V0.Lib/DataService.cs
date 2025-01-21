using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PlesovskikhBA.Sprint0.Task2.V0.Lib
{
    public class DataService
    {
        public static string GetMessage(string name)
        {
            return $"Привет..., {name}";
        }
    }
}
    