using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.GAP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }
        public static byte[] imagetobyteArray(Image imagenIn)
        {
            var MS = new MemoryStream();
            imagenIn.Save(MS, imagenIn.RawFormat);
            return MS.ToArray();
        }
    }
}
