﻿using _18120320_Lab1.Properties;
using SharpGL;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Lighting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _18120320_Lab1
{
    public partial class SharpGLForm: Form
    {
        //list of all object to draw
        List<Object> drawObjs = new List<Object>();
        List<String> objNames = new List<String>();
        Color color = Color.Black;
        int chosenObj = 0;
        //================new
        float rtri = 0;


        //  The texture identifier.
        Texture texture = new Texture();

        public SharpGLForm()
        {
            InitializeComponent();
            //  Get the OpenGL object, for quick access.
            SharpGL.OpenGL gl = this.openGLControl.OpenGL;

            //  A bit of extra initialisation here, we have to enable textures.
            gl.Enable(OpenGL.GL_TEXTURE_2D);

            //  Create our texture object from a file. This creates the texture for OpenGL.
            //texture.Create(gl, "Crate.bmp");

            //  Create a light.
            Light light = new Light()
            {
                On = true,
                Position = new Vertex(3, 10, 3),
                GLCode = OpenGL.GL_LIGHT1
            };
        }


        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            //  Get the OpenGL object, for quick access.
            SharpGL.OpenGL gl = this.openGLControl.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();
            gl.Translate(0.0f, 0.0f, -6.0f);
            gl.Rotate(rtri, rtri, 0.0f);
            rtri += 1.0f;

            foreach (Object obj in drawObjs)
            {
                obj.Draw(gl);

                if (i == chosenObj)
                {
                    obj.OutlineColor = Color.Orange;
                }
                else
                {
                    obj.OutlineColor = Color.Gray;
                }
                i++;

            }
            rtri += 1.0f;// 0.2f;	

        }

        private void colorHexagon_ColorChanged(object sender, MechanikaDesign.WinForms.UI.ColorPicker.ColorChangedEventArgs args)
        {
            //change color base on what user chose
            color = colorHexagon.SelectedColor;
            drawObjs[chosenObj].ObjColor = color;

        }

        private void cubeButton_Click(object sender, EventArgs e)
        {
            drawObjs.Add(new Cube());
            objNames.Add("cube" + objNames.Count.ToString());
            objectList.Items.Add(objNames[objNames.Count - 1]);


            listObjects.Items.Add("cube" + objNames.Count.ToString());
            
        }

        private void prismButton_Click(object sender, EventArgs e)
        {
            drawObjs.Add(new Prism());
            objNames.Add("prism" + objNames.Count.ToString());
            objectList.Items.Add(objNames[objNames.Count - 1]);

            listObjects.Items.Add("prism" + objNames.Count.ToString());

            //foreach (var i in listObjects.Items)
            //{
            //    Console.WriteLine(i);
            //}

        }

        private void listObjectsClick(object sender, MouseEventArgs e)
        {
            // Get vị trí click chuột
            int index = this.listObjects.IndexFromPoint(e.Location);
            Console.WriteLine(index);

            //nếu chuột nằm trên item có vị trí index thì drawObject[index] được tô viền màu
            if (index != -1)
            {
                //drawObjs[index].OutlineColor = Color.Orange;
                chosenObj = index;
                
            }
        }

        private void pyramidButton_Click(object sender, EventArgs e)
        {
            drawObjs.Add(new Pyramid());
            objNames.Add("pyramid" + objNames.Count.ToString());
            objectList.Items.Add(objNames[objNames.Count - 1]);
        }

        private void posXInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void posYInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void posZInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RotXInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RotYInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RotZInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScalXInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScalYInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScalZInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
