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


       

 if (Wallg.bana == 2){
        wall.wallSecond();
}
else 
        wall.wall1();

        while (!Raylib.WindowShouldClose())
        {


            float gravity = 0.35f;

            playerRect.Position = player.position;

            player.movement.X = 0;

            if (Raylib.IsKeyDown(KeyboardKey.A)) // så spelaren kan gå vänster
            {

                player.movement.X = -10;

            }

            if (Raylib.IsKeyDown(KeyboardKey.D))  // så spelaren kan gå höger
            {
                player.movement.X = 10;

            }



            player.position += player.movement;
            player.movement.Y += gravity;   // så att spelaren konstant dras ner av "tyngdkraften"



            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.DarkGray);
            if (Wallg.bana >= 2){
                Wallg.bana = 2;
            }

           


            wall.wall2();

            Collision.collision(wall, player, playerRect);
            player.Update();



            Raylib.DrawRectangleRec(playerRect, Color.Magenta);
            Raylib.DrawText($"{Wallg.bana}", 50, 50, 50, Color.Green);


            Raylib.EndDrawing();

        }


    }
}