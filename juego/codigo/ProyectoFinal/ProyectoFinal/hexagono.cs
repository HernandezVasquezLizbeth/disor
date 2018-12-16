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
    class hexagono
    {
        
        private float HexWidth(float height)
        {
            return (float)(4 * (height / 2 / Math.Sqrt(3)));
        }
        
        private PointF[] HexToPoints(float height, float row, float col)
        {
            
            float width = HexWidth(height);
            float y = height / 2;
            float x = 0;

            
            y += row * height;

            if (col % 2 == 1) y += height / 2;

           
            x += col * (width * 0.75f);

            return new PointF[]
                {
            new PointF(x, y),
            new PointF(x + width * 0.25f, y - height / 2),
            new PointF(x + width * 0.75f, y - height / 2),
            new PointF(x + width, y),
            new PointF(x + width * 0.75f, y + height / 2),
            new PointF(x + width * 0.25f, y + height / 2),
                };
        }

        private void DrawHexGrid(Graphics gr, Pen pen,
    float xmin, float xmax, float ymin, float ymax,
    float height)
        {
            for (int row = 0; ; row++)
            {

                PointF[] points = HexToPoints(height, row, 0);

                if (points[4].Y > ymax) break;

                for (int col = 0; ; col++)
                {

                    points = HexToPoints(height, row, col);

                    if (points[3].X > xmax) break;

                    
                    if (points[4].Y >= ymax)
                    {
                        gr.DrawPolygon(pen, points);
                    }
                }
            }
        }
    }
}
