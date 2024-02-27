
static Vector3 GetInfoFromDB()
{
    return new Vector3(2, 3, 4);
}
var vector3 = GetInfoFromDB();
SizeConsoleWindow((Vector2)vector3);

static void SizeConsoleWindow(Vector2 vector2)
{
    Console.WriteLine(vector2.X);
}

class Vector2
{
    public float X { get; set; }
    public float Y { get; set; }
    public Vector2(float x, float y)
    {
        X = x; Y = y;
    }
    public static implicit operator Vector3(Vector2 other)
    {
        return new Vector3(other.X, other.Y, 0);
    }
}

class Vector3(float x, float y, float z)
{
    public float X { get; set; } = x;
    public float Y { get; set; } = y;
    public float Z { get; set; } = z;

    public static explicit operator Vector2(Vector3 other)
    {
        return new Vector2(other.X, other.Y);
    }
    public static implicit operator Vector3(Vector2 other)
    {
        return new Vector3(other.X, other.Y, 0);
    }
}