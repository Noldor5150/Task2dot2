

namespace Task2dot2
{
    class Program
    {
        
                                         
        static void Main(string[] args)
        {
            string path = @"C:\Users\PauliusRuikis\Desktop/config.xml";
            var data = XMLReader.GetUsersFromConfig(path);
            Controller controller = new Controller(data);
            var repairedData = controller.RepairedUsers(data);
            controller.SaveToJson(repairedData,path);

        }
    }
}
