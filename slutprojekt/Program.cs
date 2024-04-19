// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

class Program
{

    static void Main(){

    Raylib.InitWindow(1980, 1080, "shuno");
Raylib.ToggleFullscreen();
Raylib.SetTargetFPS(60);

Wallg wall = new Wallg();


    Player player = new Player();
    Program program = new Program();
    Rectangle playerRect = new Rectangle(player.position, player.size);
    Boolean right = false;
    Boolean left = false;
    Boolean up = false;
    int groundlevel = 1000;
    static void ground(int groundlevel)
    {
        Raylib.DrawRectangle(0, groundlevel, 5000, 500, Color.Green);
    }

    bool collision = false;
    bool jump = false;
    wall.wall1();
while (!Raylib.WindowShouldClose())
{


    float gravity = 0.35f;

    playerRect.Position = player.position;

    player.movement.X = 0;

    //5ground(groundlevel);

    // player.DrawRectangle(player, 50, 50, 50, 50, Color.Green);

    



  

      

    //    collision = Raylib.CheckCollisionRecs(playerRect,player.rect);
    //    if (collision == true){
    //     if (player.movement.X >=1 ){
    //         right = true;
    //         player.movement.X = 0;
    //     }
    //     if (player.movement.X <=-1 ){
    //         left = true;
    //         player.movement.X = 0;
    //     }
    //     if (player.movement.Y >=-1 ){
    //         up = true;
    //         player.movement.Y = 0;
    //         jump = true;
    //         gravity = 0;
    //     }
    //    }

    if (Raylib.IsKeyDown(KeyboardKey.A) & collision == true)
{
    left = true;
}

if (collision == false)
{
    if (Raylib.IsKeyDown(KeyboardKey.D))
    {
        player.movement.X = 10;
        //  right = true;
    }
}

if (Raylib.IsKeyUp(KeyboardKey.D))
{
    //  right = false;
}

if (Raylib.IsKeyDown(KeyboardKey.A) & left == false)
{

    player.movement.X = -10;
    // left = true;

}
if (Raylib.IsKeyUp(KeyboardKey.A))
{

    left = false;

}




// if (player.position.Y > groundlevel - 50)
// {
//     player.position.Y = groundlevel - 50;
//     gravity = 0;
//     jump = true;

// }

//collision = Raylib.CheckCollisionRecs(playerRect,ground);

// Vector2.Normalize(player.movement);
player.position += player.movement;
player.movement.Y += gravity;



Raylib.BeginDrawing();

Raylib.ClearBackground(Color.DarkGray);

//player.Draw();
// player.Update();

wall.wall2();
Collision.collision(wall, player, playerRect);
player.Update();


Raylib.DrawRectangleRec(playerRect, Color.Magenta);



Raylib.EndDrawing();

}


    }
}