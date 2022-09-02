using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace Carlo
{
    public static class Program
    {
        private static void Main()
        {
            var nativeWindowSettings = new NativeWindowSettings()
            {
                Size = new Vector2i(800,600),
                Title = "hola Triangulo - 3",
                Flags = ContextFlags.ForwardCompatible,
            };
            using (var window = new Window(GameWindowSettings.Default, nativeWindowSettings))
            {
                window.Run();
            }
        }
    }
}

// Be warned, there is a LOT of stuff here. It might seem complicated, but just take it slow and you'll be fine.
   