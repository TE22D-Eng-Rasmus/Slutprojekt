using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;


//  Raylib.GetCollisionRec(Program.playerRect );

//  Player player = new Player();
//  Rectangle playerRect = new Rectangle(player.position, player.size);




class Collision
{

    Player player;
    Program program;

    public static bool jumpt = true;

    public static void collision(Wallg wall, Player player, Rectangle playerRect)
    {


        foreach (Rectangle f in wall.floor)
        {
            if (Raylib.CheckCollisionRecs(f, playerRect))
            {

                player.movement.Y = 0;
                if (player.position.Y >= f.Y - 50)
                {
                    player.position.Y = f.Y - 50;
                }
                jumpt = true;



            }



        }


        foreach (Rectangle g in wall.goals)
        {
            if (Raylib.CheckCollisionRecs(g, playerRect))
            {
                Wallg.bana ++;
                player.movement.Y = -20;
                

            }
        }

    }
}