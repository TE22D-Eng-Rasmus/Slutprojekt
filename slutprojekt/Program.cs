// See https://aka.ms/new-console-template for more information
using System.Numerics;
using Raylib_cs;



Raylib.InitWindow(1980, 1080, "shuno");
Raylib.ToggleFullscreen();
Raylib.SetTargetFPS(60);

player player = new player();

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.DarkGray);

    Raylib.DrawRectangle(100,100,50,50,Color.Magenta);



    Raylib.EndDrawing();

}

class player
{


}