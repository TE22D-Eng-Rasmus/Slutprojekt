// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Numerics;
using System.Security;
using Raylib_cs;

class player
{

public int speed = 0;

public Vector2 movement = new(0,0);

public Vector2 position = new(Raylib.GetScreenWidth() /8, 1000 - 50);

public Vector2 size = new(50,50);

public float gravity = 0.35f;
}