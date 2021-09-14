
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Task2dot2
{
   public static class XMLReader
    {
        /// <summary>
        /// Helper - only reads  config XMl file in specific structure
        /// </summary>
        /// <param name="path">  XML config file location </param>
        /// <returns> List of users </returns>
        public static List<User> GetUsersFromConfig(string path)
        {
            XElement xelement = XElement.Load(path);
           return (from element in xelement.Descendants("login")
                               select new User
                               {
                                   Name = element.Attribute("name").Value.ToString(),
                                   WindowsList = (from window in element.Descendants("window")
                                                  select  new Window(window.Attribute("title").Value.ToString(), 
                                                  (int?)window.Element("top"),
                                                 (int?)window.Element("left"),
                                                 (int?)window.Element("width"),
                                                (int?)window.Element("height")
                                                  )).ToList()
                               }).ToList();
            
        }
    }
}
