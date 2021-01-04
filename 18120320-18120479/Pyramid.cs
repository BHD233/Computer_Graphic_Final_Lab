using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120320_Lab1
{
    class Pyramid : Object
    {
        public override void Draw(OpenGL gl)
        {
            gl.Rotate(RotateX, RotateY, RotateZ);

            //set drawing color
            gl.Color(ObjColor.R / 255.0, ObjColor.G / 255.0, ObjColor.B / 255.0);

            gl.Enable(OpenGL.GL_TEXTURE_2D);

            //Bind the texture.
            Texture.Bind(gl);

            gl.Begin(OpenGL.GL_QUADS);

            // Front Face
            float x1 = (float)(Center.X - ScaleX);
            float y1 = (float)(Center.Y - ScaleY);
            float z1 = (float)(Center.Z - ScaleZ);
            float x2 = (float)(Center.X + ScaleX);
            float y2 = (float)(Center.Y + ScaleY);
            float z2 = (float)(Center.Z + ScaleZ);

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x1, y1, z1); // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(Center.X, y2, Center.Z);  // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x2, y1, z1);   // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x1, y1, z1); // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(Center.X, y2, Center.Z);  // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x1, y1, z2);   // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x2, y1, z2); // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(Center.X, y2, Center.Z);  // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x2, y1, z1);   // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x2, y1, z2); // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(Center.X, y2, Center.Z);  // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x1, y1, z2);   // Top Right Of The Texture and Quad

            // Bottom Face
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(x1, y1, z1);    // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(x2, y1, z1); // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(x2, y1, z2);  // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(x1, y1, z2); // Bottom Right Of The Texture and Quad
            
            gl.End();

            //draw control line
            gl.Color(OutlineColor.R / 255.0, OutlineColor.G / 255.0, OutlineColor.B / 255.0);
            gl.LineWidth(OutlineWeight);
            gl.Begin(OpenGL.GL_LINE_LOOP);

            gl.Vertex(x1, y1, z1);
            gl.Vertex(Center.X, y2, Center.Z);
            gl.Vertex(x2, y1, z1);

            gl.Vertex(x1, y1, z1);
            gl.Vertex(Center.X, y2, Center.Z);
            gl.Vertex(x1, y1, z2);

            gl.Vertex(x2, y1, z2); 
            gl.Vertex(Center.X, y2, Center.Z);
            gl.Vertex(x2, y1, z1);

            gl.Vertex(x2, y1, z2); 
            gl.Vertex(Center.X, y2, Center.Z);
            gl.Vertex(x1, y1, z2);

            gl.Vertex(x1, y1, z1);
            gl.Vertex(x2, y1, z1);
            gl.Vertex(x2, y1, z2);
            gl.Vertex(x1, y1, z2);

            gl.End();

            gl.Disable(OpenGL.GL_TEXTURE_2D);

            gl.Flush();

            gl.Rotate(-RotateX, -RotateY, -RotateZ);
        }

        public Pyramid() : base()
        {

        }
    }
}
