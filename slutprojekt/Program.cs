// See https://aka.ms/new-console-template for more information
using System.Numerics;
using Raylib_cs;



Raylib.InitWindow(1980, 1080, "shuno");
Raylib.ToggleFullscreen();
Raylib.SetTargetFPS(60);

player player = new player();
Rectangle playerRect = new Rectangle(player.position,player.size);

while (!Raylib.WindowShouldClose())
{

playerRect.Position = player.position;

player.movement.X = 0;

player.movement.Y = 0;

if (Raylib.IsKeyDown(KeyboardKey.W)){
    player.movement.Y = -10;
}
if (Raylib.IsKeyDown(KeyboardKey.S)){
    player.movement.Y = 10;
}
if (Raylib.IsKeyDown(KeyboardKey.D)){
    player.movement.X = 10;
}
if (Raylib.IsKeyDown(KeyboardKey.A)){
    player.movement.X = -10;
}


Vector2.Normalize(player.movement);
player.position +=player.movement;


    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.DarkGray);

    Raylib.DrawRectangleRec(playerRect, Color.Magenta);



    Raylib.EndDrawing();

}
