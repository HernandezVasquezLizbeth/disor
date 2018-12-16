using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class triangulo
    {

        private float TriangleWidth(float height)
        {
            return (float)(2 * height / Math.Sqrt(3));
        }

        
        private PointF[] TriangleToPoints(float height,
            float row, float col)
        {
            float width = TriangleWidth(height);
            float y = row * height;
            float x = (col + 0.5f) * width;

           
            bool whole_col = (Math.Abs(col - (int)col) < 0.1);
            bool rightside_up;
            if ((int)row % 2 == 0)
            {
         
                rightside_up = whole_col;
            }
            else
            {
             
                rightside_up = !whole_col;
            }

           
            if (rightside_up)
                return new PointF[]
                    {
                new PointF(x, y),
                new PointF(x + width / 2, y + height),
                new PointF(x - width / 2, y + height),
                    };
            else
                return new PointF[]
                    {
                new PointF(x, y + height),
                new PointF(x + width / 2, y),
                new PointF(x - width / 2, y),
                    };
        }

        private List<PointF> Triangles = new List<PointF>();
        private float TriangleHeight=0;

        private Form picGrid = new Form();


        public void picGrid_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

     
            foreach (PointF point in Triangles)
            {
                e.Graphics.FillPolygon(Brushes.LightBlue,
                    TriangleToPoints(TriangleHeight, point.X, point.Y));
            }


            DrawTriangularGrid(e.Graphics, Pens.Black,0, picGrid.ClientSize.Width,0, picGrid.ClientSize.Height,TriangleHeight);
        }


        private void DrawTriangularGrid(Graphics gr, Pen pen,float xmin, float xmax, float ymin, float ymax, float height)
        {
            float width = TriangleWidth(height);
            int row = 0;
            for (float y = 0; y <= ymax + width / 2; y += height)
            {
                float x = 0;
                if (row % 2 == 0) x = width / 2;

                PointF[] points =
                {
            new PointF(x, y),
            new PointF(x + width / 2, y + height),
            new PointF(x - width / 2, y + height),
        };
                for (; x <= xmax; x += width)
                {
                    gr.DrawPolygon(pen, points);
                    points[0].X += width;
                    points[1].X += width;
                    points[2].X += width;
                }
                row++;
            }
        }

    }
}
