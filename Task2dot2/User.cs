using System;
using System.Collections.Generic;


namespace Task2dot2
{
    class User
    {
        public const string FILE_PATH = @"‪C:\Users\PauliusRuikis\Desktop\config.xml";
        public string Name { get; set; }
        public List<Window> WindowsList { get; set; }

        public User()
        {

        }
        public User(string name, List<Window> windowsList)
        {
            if (windowsList != null)
            {
                Name = name;
                WindowsList = windowsList.ConvertAll(window => new Window(window.Title, window.Top, window.Left, window.Width, window.Height));
            }
            else
            {
                throw new ArgumentException("something went wrong!!!");
            }
        }
    }
}
