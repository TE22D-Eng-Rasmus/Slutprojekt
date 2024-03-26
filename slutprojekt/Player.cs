// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security;
using Raylib_cs;

class Player
{

    public int speed = 0;

    public Rectangle rect = new(1250,800,100,1000);
    public Rectangle ground = new();

    public Vector2 movement = new(0, 0);

    public Vector2 position = new(Raylib.GetScreenWidth() / 8, 1000);

    public Vector2 size = new(50, 50);

    public float gravity = 0.35f;

    public void Update()
    {

    }

    //     public void DrawRectangle(Player p, int posX,
    // int posY,
    // int width,
    // int height,
    // System.Drawing.Color color)
    // {
    //     if (p.position.Y > posY)
    //     {
    //         p.position.Y = posY;
    //         float gravity = 0;
    //     }
    // }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.Green);


    }
}

class cube
{
    public Vector2 positionC = new(50, 50);

    public int speed = 0;

    public Vector2 movement = new(0, 0);


    public Vector2 size = new(50, 50);

    public float gravity = 0.35f;
}