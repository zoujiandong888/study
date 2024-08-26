using UnityEngine;

public class OperatorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(100, 99);
        Point p3 = p1 + p2;// (101, 100)
        Point p4 = p1 + 10;// (11, 1)
        Point p5 = p1 - p2;// (-99, -98)
        Point p6 = p1 - 10;// (-9, 1)

        Debug.Log($"({p3.x}, {p3.y})");
        Debug.Log($"({p4.x}, {p4.y})");
        Debug.Log($"({p5.x}, {p5.y})");
        Debug.Log($"({p6.x}, {p6.y})");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class PointA : Point
{
    public PointA() : base(10, 20)
    {
    }
}

public class Point
{
    public float x;
    public float y;

    public Point(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.x + p2.x, p1.y + p2.y);
    }

    // 加号运算符参数个数不能超过2个，且有一个必须为Point对象
    public static Point operator +(Point p, float x)
    {
        return new Point(p.x + x, p.y);
    }

    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.x - p2.x, p1.y - p2.y);
    }

    public static PointA operator -(Point p, float x)
    {
        return new PointA();
    }

    public static Point operator *(Point p1, Point p2)
    {
        return null;
    }

    public static Point operator /(Point p1, Point p2)
    {
        return null;
    }

    public static Point operator %(Point p1, Point p2)
    {
        return null;
    }

    public static Point operator --(Point p)
    {
        return null;
    }

    public static bool operator !(Point p)
    {
        return false;
    }

    public static Point operator |(Point p1, Point p2)
    {
        return null;
    }

    public static Point operator &(Point p1, Point p2)
    {
        return null;
    }

    public static Point operator ^(Point p1, Point p2)
    {
        return null;
    }

    public static Point operator ~(Point p1)
    {
        return null;
    }

    public static bool operator >(Point p1, Point p2)
    {
        return true;
    }


    public static bool operator <(Point p1, Point p2)
    {
        return true;
    }
}
