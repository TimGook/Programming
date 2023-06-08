
internal class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        var _rectangles = new List<Rectangle>();
        var _currentRectangle = new Rectangle();

        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            _currentRectangle = new Rectangle(rnd.Next(10,100));
            _rectangles.Add(_currentRectangle);
        }

        Console.WriteLine("Unsorted");

        for (int i = 0; i < _rectangles.Count; i++)
        {
            Rectangle _rectangle = _rectangles[i];
            Console.WriteLine(_rectangle.Area);
        }

        _rectangles.Sort(CompareByArea);


        Console.WriteLine("Sorted");

        for (int i = 0; i < _rectangles.Count; i++)
        {
            Console.WriteLine(_rectangles[i].Area);
        }

        Console.ReadLine();
    }

    static int CompareByArea(Rectangle x, Rectangle y)
    {
        if (x.Area > y.Area)
        {
            return 1;
        }
        else 
        { 
            return -1; 
        }
    }
}

class Rectangle
{
    public int Area{ get; set; }

    public Rectangle(int area)
    {
        Area = area;
    }

    public Rectangle()
    {

    }
}