namespace Stephan_Toy_assignment
{
    using Raylib_cs;
    using System.Numerics;

    internal class Program
    {
        static string title = "Toy"; 
        static int screenWidth = 800; 
        static int screenHeight = 800; 
        static int targetFps = 60;
        static void Main()
        {
            
            Raylib.InitWindow(screenWidth, screenHeight, title);
           
            Raylib.SetTargetFPS(targetFps);
            // Setup your game. This is a function YOU define.
            Setup();
            // Loop so long as window should not close
            while (!Raylib.WindowShouldClose())
            {
                // Enable drawing to the canvas (window)
                Raylib.BeginDrawing();
                // Clear the canvas with one color
                Raylib.ClearBackground(Color.DarkBlue);
                // Your game code here. This is a function YOU define.
                Update();
                Raylib.DrawCircle(100,100,50,Color.DarkPurple);
                Raylib.DrawCircle(300, 200, 150, Color.DarkBrown);
                Raylib.DrawCircle(500, 430, 70, Color.DarkGreen);
                Raylib.DrawCircle(220, 700, 90, Color.Red);
                // Stop drawing to the canvas, begin displaying the frame
                Raylib.EndDrawing();
            }
            // Close the window
            Raylib.CloseWindow();
        }

        static void Setup()
        {
            Vector2 mousePosition = GetMousePosition();
        }

        static void Update()
        {
            // Your game code run each frame here
        }
    }

    }




