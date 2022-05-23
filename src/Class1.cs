using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerToys.Launcher.Plugin.Dictionary
{
    internal class Class1
    {
        static void Main()
        {
            JsonConvert.DeserializeObject<Settings>("");
            Console.ReadKey();
        }
    }
}
