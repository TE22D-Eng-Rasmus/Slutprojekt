// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;



Raylib.InitWindow(1980, 1080, "shuno");
Raylib.ToggleFullscreen();
Raylib.SetTargetFPS(60);

player player = new player();
Rectangle playerRect = new Rectangle(player.position, player.size);

while (!Raylib.WindowShouldClose())
{

 float gravity = 0.35f;

    playerRect.Position = player.position;

    player.movement.X = 0;

    

    if (Raylib.IsKeyPressed(KeyboardKey.W))
    {
        player.movement.Y = -10;
        // gravity += 1;

    }
    
    
    if (Raylib.IsKeyDown(KeyboardKey.D))
    {
        player.movement.X = 10;
    }
    if (Raylib.IsKeyDown(KeyboardKey.A))
    {
        player.movement.X = -10;
    }




    


   // Vector2.Normalize(player.movement);
    player.position += player.movement;
    


    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.DarkGray);

    Raylib.DrawRectangle(0,1000,5000,500, Color.Green);

    Raylib.DrawRectangleRec(playerRect, Color.Magenta);



    Raylib.EndDrawing();

}
