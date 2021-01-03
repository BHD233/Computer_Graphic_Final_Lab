﻿using SharpGL;
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
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Top Left Of The Texture and Quad

            // Back Face
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Bottom Left Of The Texture and Quad

            // Top Face
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Right Of The Texture and Quad

            // Bottom Face
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad

            // Right face
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Top Left Of The Texture and Quad
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Left Of The Texture and Quad

            // Left Face
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Bottom Left Of The Texture and Quad
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Top Right Of The Texture and Quad
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad


            gl.End();

            gl.Color(OutlineColor.R / 255.0, OutlineColor.G / 255.0, OutlineColor.B / 255.0);
            gl.LineWidth(OutlineWeight);
            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);


            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);


            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);


            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);


            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);

            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);

            gl.End();

            gl.Flush();
        }
    }

    class Prism: Object
    {
        float _length = 2.0f/3; //độ dài cạnh cua mat day tam giac
        float _height = 1.0f; // chieu cao cua lang tru
        double alpha = 2 * Math.PI / 3;
        double R_bot;
        public Prism()
        {
             R_bot = Math.Sqrt(3) * _length / 3;
        }
        public override void Draw(OpenGL gl)
        {
            R_bot = Math.Sqrt(3) * _length / 3;

            //set drawing color
            gl.Color(ObjColor.R / 255.0, ObjColor.G / 255.0, ObjColor.B / 255.0);


            float x = (float)(Center.X - ScaleX);
            float y = (float)(Center.Y - ScaleY);
            float z = (float)(Center.Z - ScaleZ);

            //3 diem dau la mot tam giac
           CustomPoint V1 = new CustomPoint(Center.X + R_bot, Center.Y - _height / 2, Center.Z);
            CustomPoint V2 = new CustomPoint(Center.X + R_bot * Math.Cos(alpha), Center.Y - _height / 2, Center.Z + R_bot * Math.Sin(alpha));
            CustomPoint V3 = new CustomPoint(Center.X + R_bot * Math.Cos(2 * alpha), Center.Y - _height / 2, Center.Z + R_bot * Math.Sin(2 * alpha));
            //3 diem con lai cung tao nen mot mat tam giac
            CustomPoint V4 = new CustomPoint(V1.X, Center.Y + _height / 2, V1.Z);
            CustomPoint V5 = new CustomPoint(V2.X, Center.Y + _height / 2, V2.Z);
            CustomPoint V6 = new CustomPoint(V3.X, Center.Y + _height / 2, V3.Z);

            //Ve mat tam giac
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Vertex(V1.X, V1.Y, V1.Z); // V1
            gl.Vertex(V2.X, V2.Y, V2.Z); // V2
            gl.Vertex(V3.X, V3.Y, V3.Z); // V3

            gl.Vertex(V4.X, V4.Y, V4.Z); // V4
            gl.Vertex(V5.X, V5.Y, V5.Z); // V5
            gl.Vertex(V6.X, V6.Y, V6.Z); // V6

            gl.End();

            //Ve mat ben
            gl.Color(ObjColor.R / 255.0, ObjColor.G / 255.0, ObjColor.B / 255.0);
            gl.Begin(OpenGL.GL_QUADS);

            gl.Vertex(V1.X, V1.Y, V1.Z); // V1
            gl.Vertex(V2.X, V2.Y, V2.Z); // V2
            gl.Vertex(V5.X, V5.Y, V5.Z); // V5
            gl.Vertex(V4.X, V4.Y, V4.Z); // V4

            gl.Vertex(V1.X, V1.Y, V1.Z); // V1
            gl.Vertex(V3.X, V3.Y, V3.Z); // V3
            gl.Vertex(V6.X, V6.Y, V6.Z); // V6
            gl.Vertex(V4.X, V4.Y, V4.Z); // V4

            gl.Vertex(V2.X, V2.Y, V2.Z); // V2
            gl.Vertex(V3.X, V3.Y, V3.Z); // V3
            gl.Vertex(V6.X, V6.Y, V6.Z); // V6
            gl.Vertex(V5.X, V5.Y, V5.Z); // V5


            gl.End();

            //vien khung
            gl.Color(OutlineColor.R / 255.0, OutlineColor.G / 255.0, OutlineColor.B / 255.0);
            gl.LineWidth(OutlineWeight);
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(V1.X, V1.Y, V1.Z); // V1
            gl.Vertex(V2.X, V2.Y, V2.Z); // V2

            gl.Vertex(V2.X, V2.Y, V2.Z); // V2
            gl.Vertex(V3.X, V3.Y, V3.Z); // V3

            gl.Vertex(V1.X, V1.Y, V1.Z); // V1
            gl.Vertex(V3.X, V3.Y, V3.Z); // V3

            gl.Vertex(V1.X, V1.Y, V1.Z); // V1
            gl.Vertex(V4.X, V4.Y, V4.Z); // V4

            gl.Vertex(V2.X, V2.Y, V2.Z); // V2
            gl.Vertex(V5.X, V5.Y, V5.Z); // V5

            gl.Vertex(V3.X, V3.Y, V3.Z); // V3
            gl.Vertex(V6.X, V6.Y, V6.Z); // V6

            gl.Vertex(V4.X, V4.Y, V4.Z); // V4
            gl.Vertex(V5.X, V5.Y, V5.Z); // V5

            gl.Vertex(V6.X, V6.Y, V6.Z); // V6
            gl.Vertex(V4.X, V4.Y, V4.Z); // V4

            gl.Vertex(V6.X, V6.Y, V6.Z); // V6
            gl.Vertex(V5.X, V5.Y, V5.Z); // V5


            gl.End();

            gl.Flush();
        }
    }
}