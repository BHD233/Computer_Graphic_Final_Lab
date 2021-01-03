using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120320_Lab1.Properties
{
    class Cube : Object
    {
        public override void Draw(OpenGL gl)
        {
            //set drawing color
            gl.Color(ObjColor.R / 255.0, ObjColor.G / 255.0, ObjColor.B / 255.0);

            gl.Begin(OpenGL.GL_QUADS);

            // Front Face
            float x = (float)(Center.X - ScaleX);
            float y = (float)(Center.Y - ScaleY);
            float z = (float)(Center.Z - ScaleZ);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-x, -y, z); // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(x, -y, z);  // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x, y, z);   // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-x, y, z);  // Top Left Of The Texture and Quad

            // Back Face
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-x, -y, -z);    // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-x, y, -z); // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(x, y, -z);  // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x, -y, -z); // Bottom Left Of The Texture and Quad

            // Top Face
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-x, y, -z); // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-x, y, z);  // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(x, y, z);   // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x, y, -z);  // Top Right Of The Texture and Quad

            // Bottom Face
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-x, -y, -z);    // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(x, -y, -z); // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x, -y, z);  // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-x, -y, z); // Bottom Right Of The Texture and Quad

            // Right face
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(x, -y, -z); // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x, y, -z);  // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(x, y, z);   // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x, -y, z);  // Bottom Left Of The Texture and Quad

            // Left Face
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-x, -y, -z);    // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-x, -y, z); // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-x, y, z);  // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-x, y, -z);	// Top Left Of The Texture and Quad

            gl.End();

            //draw control line
            gl.Color(OutlineColor.R / 255.0, OutlineColor.G / 255.0, OutlineColor.B / 255.0);
            gl.LineWidth(OutlineWeight);
            gl.Begin(OpenGL.GL_LINE_LOOP);

            gl.Vertex(-x, -y, z);
            gl.Vertex(x, -y, z);
            gl.Vertex(x, y, z);
            gl.Vertex(-x, y, z);
            gl.Vertex(-x, -y, z);


            gl.Vertex(-x, -y, -z);
            gl.Vertex(-x, y, -z);
            gl.Vertex(x, y, -z);
            gl.Vertex(x, -y, -z);
            gl.Vertex(-x, -y, -z);


            gl.Vertex(-x, y, -z);
            gl.Vertex(-x, y, z);
            gl.Vertex(x, y, z);
            gl.Vertex(x, y, -z);
            gl.Vertex(-x, y, -z);


            gl.Vertex(-x, -y, -z);
            gl.Vertex(x, -y, -z);
            gl.Vertex(x, -y, z);
            gl.Vertex(-x, -y, z);
            gl.Vertex(-x, -y, -z);

            gl.Vertex(x, -y, -z);
            gl.Vertex(x, y, -z);
            gl.Vertex(x, y, z);
            gl.Vertex(x, -y, z);
            gl.Vertex(x, -y, -z);

            gl.Vertex(-x, -y, -z);
            gl.Vertex(-x, -y, z);
            gl.Vertex(-x, y, z);
            gl.Vertex(-x, y, -z);
            gl.Vertex(-x, -y, -z);

            gl.End();

            gl.Flush();
        }

        public Cube():base()
        {
           
        }
    }
}
