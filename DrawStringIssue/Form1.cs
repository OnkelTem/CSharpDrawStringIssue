using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawStringIssue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.Black, ClientRectangle);
            Console.WriteLine($"OnPaint: {ClientRectangle}");
            e.Graphics.DrawString($"{ClientRectangle}", Font, Brushes.White, ClientRectangle);
        }
    }
}
