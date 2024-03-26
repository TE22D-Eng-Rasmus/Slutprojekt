// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;



Raylib.InitWindow(1980, 1080, "shuno");
Raylib.ToggleFullscreen();
Raylib.SetTargetFPS(60);


Player player = new Player();
Rectangle playerRect = new Rectangle(player.position, player.size);
int groundlevel = 1000;
static void ground(int groundlevel)
{
    Raylib.DrawRectangle(0, groundlevel, 5000, 500, Color.Green);
}

bool collision = false;
bool jump = true;

while (!Raylib.WindowShouldClose())
{

    float gravity = 0.35f;

    playerRect.Position = player.position;

    player.movement.X = 0;

    ground(groundlevel);

    // player.DrawRectangle(player, 50, 50, 50, 50, Color.Green);

    player.Update();

    if (jump == true)
    {

        if (Raylib.IsKeyPressed(KeyboardKey.W))
        {
            player.movement.Y = -10;
            jump = false;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            player.movement.Y = -10;
            jump = false;
        }
    }

       collision = Raylib.CheckCollisionRecs(playerRect,player.rect);
       if (collision == true){
        if (player.movement.X >=1 ){
            Boolean right = true;
        }
       }

    if (collision == false){
    if (Raylib.IsKeyDown(KeyboardKey.D))
    {
        player.movement.X = 10;
    }
    }

    if (Raylib.IsKeyDown(KeyboardKey.A))
    {
        
        player.movement.X = -10;
        
    }
    
 


    if (player.position.Y > groundlevel -50)
    {
        player.position.Y = groundlevel -50 ;
        gravity = 0;
        jump = true;

    }

    //collision = Raylib.CheckCollisionRecs(playerRect,ground);

    // Vector2.Normalize(player.movement);
    player.position += player.movement;
    player.movement.Y += gravity;



    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.DarkGray);

    player.Draw();

    

    Raylib.DrawRectangleRec(playerRect, Color.Magenta);



    Raylib.EndDrawing();

}
