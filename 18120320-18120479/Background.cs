using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
using System.Drawing;


namespace _18120320_Lab1
{
    class Background
    {
        int size = 10;
        public Background() { }
        public Background(int size) { this.size = size; }
        public void Draw(OpenGL gl)
        {

            //Vẽ trục tọa độ tại gốc 0,0,0
            gl.LineWidth(3);
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(0f, 1f, 0, 0); // Chọn màu Green
            gl.Vertex(-size, 0, 0); gl.Vertex(size, 0, 0);

            gl.Color(0f, 0, 1f, 0); // Chọn màu Blue
            gl.Vertex(0, -size, 0); gl.Vertex(0, size, 0);

            gl.Color(1f, 0, 0, 0); // Chọn màu Red
            gl.Vertex(0, 0, -size); gl.Vertex(0, 0, size);

            gl.End();

            //Vẽ lưới tọa độ
            gl.LineWidth(1);

            gl.Begin(OpenGL.GL_LINES);
            gl.LineWidth(0.1f);
            gl.Color(150.0 / 255.0, 150.0 / 255.0, 150.0 / 255.0, 0);

            for (float i = -size; i <= size; i += 0.5f)
                if (i != 0)
                {
                    gl.Vertex(-size, 0, i); gl.Vertex(size, 0, i);
                    gl.Vertex(i, 0, -size); gl.Vertex(i, 0, size);

                }

            //border
            gl.Color(1f, 1f, 1f, 0); // Chọn màu white

            gl.Vertex(-size, 0, -size); gl.Vertex(size, 0, -size);
            gl.Vertex(-size, 0, -size); gl.Vertex(-size, 0, size);

            gl.Vertex(-size, 0, size); gl.Vertex(size, 0, size);
            gl.Vertex(size, 0, -size); gl.Vertex(size, 0, size);

            gl.End();
        }
    }
}
