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
            gl.Rotate(RotateX, RotateY, RotateZ);

            gl.Enable(OpenGL.GL_TEXTURE_2D);

            //Bind the texture.
            Texture.Bind(gl);

            //set drawing color
            gl.Color(ObjColor.R / 255.0, ObjColor.G / 255.0, ObjColor.B / 255.0);

            gl.Begin(OpenGL.GL_QUADS);

            // Front Face
            float x1 = (float)(Center.X - ScaleX);
            float y1 = (float)(Center.Y - ScaleY);
            float z1 = (float)(Center.Z - ScaleZ);
            float x2 = (float)(Center.X + ScaleX);
            float y2 = (float)(Center.Y + ScaleY);
            float z2 = (float)(Center.Z + ScaleZ);

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x1, y1, z2); // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(x2, y1, z2);  // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x2, y2, z2);   // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(x1, y2, z2);  // Top Left Of The Texture and Quad

            // Back Face
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(x1, y1, z1);    // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x1, y2, z1); // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(x2, y2, z1);  // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x2, y1, z1); // Bottom Left Of The Texture and Quad

            // Top Face
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(x1, y2, z1); // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x1, y2, z2);  // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(x2, y2, z2);   // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x2, y2, z1);  // Top Right Of The Texture and Quad

            // Bottom Face
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x1, y1, z1);    // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(x2, y1, z1); // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x2, y1, z2);  // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(x1, y1, z2); // Bottom Right Of The Texture and Quad

            // Right face
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(x2, y1, z1); // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x2, y2, z1);  // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(x2, y2, z2);   // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x2, y1, z2);  // Bottom Left Of The Texture and Quad

            // Left Face
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x1, y1, z1);    // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(x1, y1, z2); // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x1, y2, z2);  // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(x1, y2, z1);	// Top Left Of The Texture and Quad

            gl.End();

            //draw control line
            gl.Color(OutlineColor.R / 255.0, OutlineColor.G / 255.0, OutlineColor.B / 255.0);
            gl.LineWidth(OutlineWeight);
            gl.Begin(OpenGL.GL_LINE_LOOP);

            gl.Vertex(x1, y1, z2);
            gl.Vertex(x2, y1, z2);
            gl.Vertex(x2, y2, z2);
            gl.Vertex(x1, y2, z2);
            gl.Vertex(x1, y1, z2);


            gl.Vertex(x1, y1, z1);
            gl.Vertex(x1, y2, z1);
            gl.Vertex(x2, y2, z1);
            gl.Vertex(x2, y1, z1);
            gl.Vertex(x1, y1, z1);


            gl.Vertex(x1, y2, z1);
            gl.Vertex(x1, y2, z2);
            gl.Vertex(x2, y2, z2);
            gl.Vertex(x2, y2, z1);
            gl.Vertex(x1, y2, z1);


            gl.Vertex(x1, y1, z1);
            gl.Vertex(x2, y1, z1);
            gl.Vertex(x2, y1, z2);
            gl.Vertex(x1, y1, z2);
            gl.Vertex(x1, y1, z1);

            gl.Vertex(x2, y1, z1);
            gl.Vertex(x2, y2, z1);
            gl.Vertex(x2, y2, z2);
            gl.Vertex(x2, y1, z2);
            gl.Vertex(x2, y1, z1);

            gl.Vertex(x1, y1, z1);
            gl.Vertex(x1, y1, z2);
            gl.Vertex(x1, y2, z2);
            gl.Vertex(x1, y2, z1);
            gl.Vertex(x1, y1, z1);

            gl.End();

            gl.Disable(OpenGL.GL_TEXTURE_2D);

            gl.Flush();

            gl.Rotate(-RotateX, -RotateY, -RotateZ);
        }

        public Cube():base()
        {
           
        }
    }
}
