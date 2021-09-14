
namespace Task2dot2
{
  public class Window
    {
        /// <summary>
        /// creates Window object 
        /// </summary>
        private const int DEFAULT_HEIGHT_VAL = 150;

        private const int DEFAULT_LEFT_VAL = 0;

        private const int DEFAULT_TOP_VAL = 0;

        private const int DEFAULT_WIDTH_VAL = 400;
        public string Title { get; set; }
        public int? Top { get; set; }
        public int? Left { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public Window( string title, int? top, int? left, int? width, int? height )
        {
            Title = title;
            Top = top;
            Left = left;
            Width = width;
            Height = height;
        }
        /// <summary>
        /// if none of selected Window parameter are null
        /// </summary>
        /// <returns> true </returns>
        public bool IsWindowCorrect(  )
        {
            return ( Height != null && Left != null && Top != null && Width != null );
        }

        /// <summary>
        /// takes Window object, checks if selected parameters are null, ir it is, reasigns them, to default constants
        /// </summary>
        /// <param name="window"></param>
        /// <returns> correted Window object </returns>
        public Window GetRepairedWindow(Window window)
        {
           // Window repairedWindow = (window)this.MemberwiseClone();
            if(window.Height == null )
            {
                window.Height = DEFAULT_HEIGHT_VAL;
            }
            if(window.Left == null )
            {
                window.Left = DEFAULT_LEFT_VAL;
            }
            if(window.Top == null )
            {
                window.Top = DEFAULT_TOP_VAL;
            }
            if(window.Width == null )
            {
                window.Width = DEFAULT_WIDTH_VAL;
            }
            return window;
        }
    }
}
