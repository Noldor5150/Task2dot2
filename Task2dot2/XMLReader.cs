
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Task2dot2
{
   public static class XMLReader
    {
        private const string READING_FILE_PATH = @"C:\Users\PauliusRuikis\Desktop/config.xml";
        public static List<User> CreateReadableData()
        {
            XElement xelement = XElement.Load(READING_FILE_PATH);
            List<User> UserList = (from element in xelement.Descendants("login")
                               select new User
                               {
                                   Name = element.Attribute("name").Value.ToString(),
                                   WindowsList = (from window in element.Descendants("window")
                                                  select new Window
                                                  {
                                                      Title = window.Attribute("title").Value.ToString(),
                                                      Top = (int?)window.Element("top"),
                                                      Left = (int?)window.Element("left"),
                                                      Width = (int?)window.Element("width"),
                                                      Height = (int?)window.Element("height"),
                                                  }).ToList()
                               }).ToList();
            return UserList;
        }
    }
}
