// uses https://github.com/ZeroElectric/Raylib-CSharp-Vinculum
//cheat sheet https://www.raylib.com/cheatsheet/cheatsheet.html

using ZeroElectric.Vinculum;
using System;
using System.Runtime.InteropServices;



public unsafe static class Program
{

    //Remove all logs from terminal.
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })] //changes C# standard vars to C standard vars(Cdecl)
    private static void LogCustom(int logLevel, sbyte* text, sbyte* args)
    {
        //empty for no RayLib Logs
    }



	public static void Main(string[] args)
	{  
        Raylib.SetTraceLogCallback(&LogCustom);
        intWindow();
        //Declare Vars
        int textsize = 80;

		// Loop until the window is closed
		while (!Raylib.WindowShouldClose())
		{
			// Begin drawing to the window
			Raylib.BeginDrawing();

			// Clear the background to white
			Raylib.ClearBackground(Raylib.RAYWHITE);

            //Set GUI defaults
            RayGui.GuiSetStyle(default, 16, textsize);

			// End drawing to the window
			Raylib.EndDrawing();

    }
		// Close the window
		Raylib.CloseWindow();
	}

    // Set up window
    private static void intWindow(){

        // Set the width and height of the window     
		int screenWidth = 500;
		int screenHeight = 600;

		// Initialize the window with the specified width, height, and title
		Raylib.InitWindow(screenWidth, screenHeight, "CalcUI-Ver1");

		// Set the FPS to 60
		Raylib.SetTargetFPS(60);
    }
    private static void getInput(){

    }
}
