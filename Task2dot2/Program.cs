using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Task2dot2
{
    class Program
    {
        
                                         
        static void Main(string[] args)
        {
            var data = XMLReader.CreateReadableData();
            Controler controler = new Controler(data);
            var repairedData = controler.RepairedUsersList(data);
            controler.CreateJsonFiles(repairedData);

        }
    }
}
