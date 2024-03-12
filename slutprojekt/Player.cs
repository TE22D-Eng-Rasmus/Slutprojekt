// See https://aka.ms/new-console-template for more information
using System.Numerics;
using Raylib_cs;

class player
{

public int speed = 0;

public Vector2 movement = new(0,0);

public Vector2 position = new(Raylib.GetScreenWidth() /2, Raylib.GetScreenHeight() /2);

public Vector2 size = new(50,50);

}