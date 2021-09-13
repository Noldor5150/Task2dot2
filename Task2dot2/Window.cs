using System;
using System.ComponentModel;

namespace Task2dot2
{
  public class Window
    {
        private const int DEFAULT_HEIGHT_VAL = 150;

        private const int DEFAULT_LEFT_VAL = 0;

        private const int DEFAULT_TOP_VAL = 0;

        private const int DEFAULT_WIDTH_VAL = 400;
        public string Title { get; set; }
        public int? Top { get; set; }
        public int? Left { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public Window()
        {

        }
        public Window( string title, int? top, int? left, int? width, int? height )
        {
            Title = title;
            Top = top;
            Left = left;
            Width = width;
            Height = height;
        }
        public bool IsWindowCorrect( Window window )
        {
            return ( window.Height != null && window.Left != null && window.Top != null && window.Width != null );
        }
        public Window RepairWindow( Window window )
        {
            if( window.Height == null )
            {
                window.Height = DEFAULT_HEIGHT_VAL;
            }
            if( window.Left == null )
            {
                window.Left = DEFAULT_LEFT_VAL;
            }
            if( window.Top == null )
            {
                window.Top = DEFAULT_TOP_VAL;
            }
            if( window.Width == null )
            {
                window.Width = DEFAULT_WIDTH_VAL;
            }
            return window;
        }
    }
}
