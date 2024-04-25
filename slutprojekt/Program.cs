// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

class Program
{

    static void Main()
    {

        Raylib.InitWindow(1980, 1080, "spel");
        Raylib.ToggleFullscreen();
        Raylib.SetTargetFPS(60);

        Wallg wall = new Wallg();


        Player player = new Player();
        Program program = new Program();
        Rectangle playerRect = new Rectangle(player.position, player.size);
        Boolean right = false;
        Boolean left = false;
        Boolean up = false;




        bool collision = false;
        wall.wall1();


        while (!Raylib.WindowShouldClose())
        {


            float gravity = 0.35f;

            playerRect.Position = player.position;

            player.movement.X = 0;

            if (Raylib.IsKeyDown(KeyboardKey.A))
            {

                player.movement.X = -10;

            }

            if (Raylib.IsKeyDown(KeyboardKey.D))
                {
                    player.movement.X = 10;
                    
                }



            player.position += player.movement;
            player.movement.Y += gravity;



            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.DarkGray);

            //player.Draw();


            wall.wall2();

            Collision.collision(wall, player, playerRect);
            player.Update();



            Raylib.DrawRectangleRec(playerRect, Color.Magenta);
            Raylib.DrawText($"{Wallg.bana}", 50,50,50,Color.Green);


            Raylib.EndDrawing();

        }


    }
}