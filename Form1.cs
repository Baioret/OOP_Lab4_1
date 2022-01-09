using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryStorage;

namespace Lab4_1
{
    public partial class Form1 : Form
    {
        MyStorage storage; // хранилище
        DrawFigures G; // рисовальщик

        public Form1()
        {
            InitializeComponent();
            storage = new MyStorage();
            G = new DrawFigures(sheet.Width, sheet.Height);
        }

        private void sheet_MouseUp(object sender, MouseEventArgs e)
        {
            G.UnselectAll(storage);
            G.DrawStorage(storage);

            //====================

            CCircle obj = new CCircle(e.X, e.Y, G);

            //====================

            obj.DrawCircle();
            sheet.Image = G.GetBitmap();

            //====================

            storage.add(obj);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            G.DrawStorage(storage);
        }
    }
}
