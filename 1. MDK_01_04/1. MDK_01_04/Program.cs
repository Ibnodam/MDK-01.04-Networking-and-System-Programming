using System;
using System.Runtime.InteropServices;

class Program
{
    
    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll")]
    private static extern bool SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

    private const uint WM_CLOSE = 0x0010;

    static void Main(string[] args)
    {
        
        IntPtr hWnd = FindWindow(null, "Без имени — Блокнот");

        // Если окно найдено
        if (hWnd != IntPtr.Zero)
        {
            Console.WriteLine("Окно Блокнота найдено, отправляем сообщение о закрытии...");

            
            SendMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }
        else
        {
            Console.WriteLine("Окно Блокнота не найдено. Убедитесь, что оно открыто.");
        }

        Console.ReadLine();
    }
}