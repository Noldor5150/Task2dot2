
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace Task2dot2
{
    /// <summary>
    /// manipulates, reads, corects and saves User list
    /// </summary>
    public class Controller
    {

        public List<User> UserList { get; private set; }
        public Controller (List<User> userList )
        {
            UserList = userList;
        }

        /// <summary>
        /// returns list of users with only incorect windows
        /// </summary>
        /// <param name="usersList"></param>
        /// <returns></returns>
        public List<User> IncorectUsers( List<User> usersList )
        {
            List<User> incorectUsersList = new List<User> { };
            foreach (var user in usersList)
            {
                if (!user.IsLoginCorrect())
                {
                    incorectUsersList.Add(user);
                }
            }
            return incorectUsersList;
        }
        /// <summary>
        /// corrects Windows list in Users list
        /// </summary>
        /// <param name="usersList"></param>
        /// <returns> corrected Users list </returns>
        public List<User> RepairedUsers(List<User> usersList)
        {
            List<User> repairedUsersList = new List<User> { };
            foreach ( var user in usersList )
            {
                foreach ( var window in user.WindowsList )
                {
                    window.GetRepairedWindow(window);
                }
                repairedUsersList.Add(user);
            }
            return repairedUsersList;
        }
        /// <summary>
        /// only correct Users list needs to be saved to json;
        /// </summary>
        /// <param name="usersList"> list to be saved </param>
        /// <param name="path"> where to save it</param>
        public void SaveToJson( List<User> usersList ,string path )
        {
            foreach ( var user in usersList )
            {
                using ( FileStream fs = new FileStream( $"{path}{user.Name}.json", FileMode.OpenOrCreate ))
                {
                    JsonSerializer.SerializeAsync<User>(fs, user);
                }
            }

        }

    }
}
