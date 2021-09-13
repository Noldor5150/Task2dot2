using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;

namespace Task2dot2
{
    public class Controler
    {
        public List<User> UserList { get; private set; }
        public Controler (List<User> userList )
        {
            UserList = userList;
        }
        public List<User> IncorectUsersList( List<User> usersList )
        {
            List<User> incorectUsersList = new List<User> { };
            foreach (var user in usersList)
            {
                if (!user.IsLoginCorrect(user))
                {
                    incorectUsersList.Add(user);
                }
            }
            return incorectUsersList;
        }
        public List<User> RepairedUsersList(List<User> usersList)
        {
            List<User> repairedUsersList = new List<User> { };
            foreach ( var user in usersList )
            {
                foreach ( var window in user.WindowsList )
                {
                    window.RepairWindow(window);
                }
                repairedUsersList.Add(user);
            }
            return repairedUsersList;
        }
        public void CreateJsonFiles( List<User> usersList )
        {
            foreach ( var user in usersList )
            {
                using ( FileStream fs = new FileStream( $@"C:\Users\PauliusRuikis\Desktop/{user.Name}.json", FileMode.OpenOrCreate ))
                {
                    JsonSerializer.SerializeAsync<User>(fs, user);
                    Console.WriteLine("Data has been saved to file");
                }
            }

        }

    }
}
