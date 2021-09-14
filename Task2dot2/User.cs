using System;
using System.Collections.Generic;


namespace Task2dot2
{
   public class User
    {
        /// <summary>
        /// Creats User object with Windows list inside
        /// </summary>
        public string Name { get; set; }
        public List<Window> WindowsList { get; set; }

        /// <summary>
        /// Used only for reading config
        /// </summary>
        public User()
        {

        }
        public User( string name, List<Window> windowsList )
        {
            if (windowsList != null)
            {
                Name = name;
                WindowsList = windowsList.ConvertAll( window => new Window( window.Title, window.Top, window.Left, window.Width, window.Height ) );
            }
            else
            {
                throw new ArgumentException("something went wrong!!!");
            }
        }
        /// <summary>
        /// checks specific parameters of Window objects in the list 
        /// </summary>
        /// <returns> true </returns>
        public bool IsLoginCorrect()
        {
            return ( !(WindowsList.Exists( window => window.Title == "main" ) ) || ( WindowsList.Exists( window => window.Title == "main" && window.IsWindowCorrect()) && WindowsList.Count == 1 ) );
        }
    }
}
