using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace Task2dot2
{
    class Program
    {
        
                                         
        static void Main(string[] args)
        {
           // List<Window> windowsList = new List<Window> { };
           string FILE_PATH = @"C:\Users\PauliusRuikis\Desktop/config.xml";
            /*   XDocument doc = XDocument.Load(FILE_PATH);
               var query = doc.Root.Elements("config")
                   .Select(login => login.Element("login").Value);
               foreach (string name in query)
                   Console.WriteLine(name);

               XDocument doc1 = XDocument.Load(FILE_PATH);
               var result = doc1.Elements("login")
                               .Elements("window")
                               .Where(x => x.Elements("Firstname")
                                            .Where(c => c.Attribute("Value").Value == "someguy")
                                            .Any())
                               .ToList();*/

            //  return _booksList.SelectMany(book => book.AuthorsList).GroupBy(author => author).Select(g => new Tuple<Author, int>(g.Key, g.Count())).ToList();

            /*var log =
                from login in
                    XDocument.Load(FILE_PATH).Descendants("login")
                select new User
                {
                    Name = login.Attribute("name").ToString(),
                    WindowsList = (from window in element)
                  Top = (window.Element("top") != null) ? Int32.Parse(window.Element("top").Value): null,  
                }
            */

           XElement xelement = XElement.Load(FILE_PATH);
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
       

          /*  XDocument doc = XDocument.Load(FILE_PATH);
            List<User> list = (
                from login in doc.Root.Element("config").Elements("login")
                select new User()
                {
                    Name = (string)login.Attribute("name"),
                    WindowsList = ((List<Window>)(from window in doc.Root.Element("config").Elements("login").Elements("window")
                                                  select new Window
                                                  {
                                                      Title = (string)window.Attribute("title"),
                                                      Top = (int?)window.Element("top"),
                                                      Left = (int?)window.Element("left"),
                                                      Width = (int?)window.Element("width"),
                                                      Height = (int?)window.Element("height"),
                                                  }).ToList())



                   
                }).ToList();
          */
        }

        
    }
}
