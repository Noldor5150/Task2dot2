using System;


namespace Task2dot2
{
    class Window
    {
        public string Title { get; set; }
        public int? Top { get; set; }
        public int? Left { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public Window()
        {

        }

        public Window(string title, int? top, int? left, int? width, int? height)
        {
            Title = title;
            Top = top;
            Left = left;
            Width = width;
            Height = height;
        }

    }
}
