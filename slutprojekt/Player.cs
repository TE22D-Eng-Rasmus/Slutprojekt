// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security;
using Raylib_cs;

class Player
{


    public int speed = 0;

    
    public Rectangle ground = new();

    public Vector2 movement = new(0, 0);  // hastighet av spelaren

    public Vector2 position = new(Raylib.GetScreenWidth() / 8, 800);  // vart spelaren startar

    public Vector2 size = new(50, 50);    // storlek av spelaren

    public float gravity = 0.35f;   // float som anvämnds för att spelarn ska ha någon form av tyngdkraft




    public void Update()  // så man kan hoppa och om spelaren klickar en resetar gubben position
    {
        if (Collision.jumpt == true)
        {

            if (Raylib.IsKeyPressed(KeyboardKey.W))
            {
                movement.Y = -10;
                Collision.jumpt = false;
            }
            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                movement.Y = -10;
                Collision.jumpt = false;
            }
        }

        if (Raylib.IsKeyPressed(KeyboardKey.R))
        {
            position = new(Raylib.GetScreenWidth() / 8, 800);
        }





    }





    public void Draw() // används ej
    {
       



    }
}

class cube    // ingen funktion nu
{
    public Vector2 positionC = new(50, 50);

    public int speed = 0;

    public Vector2 movement = new(0, 0);


    public Vector2 size = new(50, 50);

    public float gravity = 0.35f;
}