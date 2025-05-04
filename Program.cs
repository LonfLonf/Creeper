using System.Drawing;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    [DllImport("user32.dll")]
    public static extern IntPtr GetDC(IntPtr hwnd);
    public static void Main()
    {
        IntPtr desktop = GetDC(IntPtr.Zero);

        using (Graphics g = Graphics.FromHdc(desktop))
        {
            System.Drawing.Font font = new System.Drawing.Font("Courier New", 60);
            string text = "I'M THE CREEPER. CATCH ME IF YOU CAN!";

            // Medir o tamanho do texto
            SizeF textSize = g.MeasureString(text, font);

            // Calcular a posição centralizada
            float x = (1920 - textSize.Width) / 2;
            float y = (1080 - textSize.Height) / 2;


            while (true)
            {
                g.FillRectangle(Brushes.Black, 0, 0, 1920, 1080);
                g.DrawString(text, font, Brushes.Green, x, y);
                g.DrawString(text, font, Brushes.Green, x, y);
            }
        }
    }
}