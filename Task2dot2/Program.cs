

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
