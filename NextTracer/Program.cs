using System;
using Silk.NET.Core;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Maths;
using Silk.NET.Vulkan;


namespace NextTracer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var shit = Window.Create(new WindowOptions(
                true,
                Vector2D<int>.Zero,
                new Vector2D<int>(640, 480),
                300,
                60,
                GraphicsAPI.Default,
                "Hello Silk.NET!",
                WindowState.Normal,
                WindowBorder.Resizable,
                false,
                true,
                new VideoMode(300)));

            //var shit = Window.Create(WindowOptions.Default);

            shit.Render += elapsedTime =>
            {
                Console.WriteLine(1000 / (elapsedTime * 1000));
            };

            shit.Run();
        }
    }
}
