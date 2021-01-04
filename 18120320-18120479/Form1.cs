using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;

using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Lighting;
using SharpGL.SceneGraph;
using _18120320_Lab1.Properties;

namespace _18120320_Lab1
{
    public partial class SharpGLForm: Form
    {
        //list of all object to draw
        List<Object> drawObjs = new List<Object>();
        List<String> objNames = new List<String>();
        Color color = Color.Black;
        int chosenObj = -1;
        Background background = new Background();

        float rX = 0, rY = 0, rZ = 0;
        float zoom = 0;

        Camera camera = new Camera();


        //  The texture identifier.
        Texture texture = new Texture();

        public SharpGLForm()
        {
            InitializeComponent();
            //  Get the OpenGL object, for quick access.
            OpenGL gl = this.openGLControl.OpenGL;

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
            OpenGL gl = this.openGLControl.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();


            camera.Execute(gl);

            //background 
            background.Draw(gl);


            foreach (Object obj in drawObjs)
            {
                obj.Draw(gl);
            }

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

            chosenObj = drawObjs.Count - 1;
            ChooseObj();
        }

        private void pyramidButton_Click(object sender, EventArgs e)
        {
            drawObjs.Add(new Pyramid());
            objNames.Add("pyramid" + objNames.Count.ToString());
            objectList.Items.Add(objNames[objNames.Count - 1]);

            chosenObj = drawObjs.Count - 1;
            ChooseObj();
        }

        private void prismButton_Click(object sender, EventArgs e)
        {
            drawObjs.Add(new Prism());
            objNames.Add("prism" + objNames.Count.ToString());
            objectList.Items.Add(objNames[objNames.Count - 1]);

            chosenObj = drawObjs.Count - 1;
            ChooseObj();
        }

        private void posXInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawObjs[chosenObj].Center.X = double.Parse(posXInput.Text.ToString());
            }
            catch
            {
                //not double
            }
        }

        private void posYInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawObjs[chosenObj].Center.Y = double.Parse(posYInput.Text.ToString());
            }
            catch
            {
                //not double
            }
        }

        private void posZInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawObjs[chosenObj].Center.Z = double.Parse(posZInput.Text.ToString());
            }
            catch
            {
                //not double
            }
        }

        private void RotXInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawObjs[chosenObj].RotateX = float.Parse(rotXInput.Text.ToString());
            }
            catch
            {
                //not double
            }
        }

        private void RotYInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawObjs[chosenObj].RotateY = float.Parse(rotYInput.Text.ToString());
            }
            catch
            {
                //not double
            }
        }

        private void RotZInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawObjs[chosenObj].RotateZ = float.Parse(rotZInput.Text.ToString());
            }
            catch
            {
                //not double
            }
        }

        private void ScalXInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawObjs[chosenObj].ScaleX = double.Parse(scalXInput.Text.ToString());
                if (drawObjs[chosenObj].Type == 2)
                {
                    scalZInput.Text = drawObjs[chosenObj].ScaleZ.ToString();
                }
            }
            catch
            {
                //not double
            }
        }

        private void ScalYInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawObjs[chosenObj].ScaleY = double.Parse(scalYInput.Text.ToString());
            }
            catch
            {
                //not double
            }
        }

        private void ScalZInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawObjs[chosenObj].ScaleZ = double.Parse(scalZInput.Text.ToString());
            }
            catch
            {
                //not double
            }
        }

        private void ChooseObj()
        {
            //change outline color
            foreach (Object obj in drawObjs)
            {
                obj.ResetOutlineColor();
            }

            drawObjs[chosenObj].OutlineColor = Color.Orange;

            //show panel
            panel1.Visible = true;

            //update name text of main field
            //name
            objNameInput.Text = objNames[chosenObj];

            //pos
            posXInput.Text = drawObjs[chosenObj].Center.X.ToString();
            posYInput.Text = drawObjs[chosenObj].Center.Y.ToString();
            posZInput.Text = drawObjs[chosenObj].Center.Z.ToString();

            //rotate
            rotXInput.Text = drawObjs[chosenObj].RotateX.ToString();
            rotYInput.Text = drawObjs[chosenObj].RotateY.ToString();
            rotZInput.Text = drawObjs[chosenObj].RotateZ.ToString();

            //scale
            scalXInput.Text = drawObjs[chosenObj].ScaleX.ToString();
            scalYInput.Text = drawObjs[chosenObj].ScaleY.ToString();
            scalZInput.Text = drawObjs[chosenObj].ScaleZ.ToString();
        }

        private void objectListClick(object sender, MouseEventArgs e)
        {
            // Get vị trí click chuột
            int index = this.objectList.IndexFromPoint(e.Location);
            Console.WriteLine(index);

            //nếu chuột nằm trên item có vị trí index thì drawObject[index] được tô viền màu
            if (index != -1)
            {
                chosenObj = index;

                ChooseObj();
            }
        }

        private void objName_TextChanged(object sender, EventArgs e)
        {
            objNames[chosenObj] = objNameInput.Text;
            objectList.Items[chosenObj] = objNameInput.Text;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                rX++;
                camera.RotateUp();
            }
            else if (keyData == Keys.Down)
            {
                rX--;
                camera.RotateDown();
            }
            else if (keyData == Keys.Left)
            {
                rY--;
                camera.RotateLeft();
            }
            else if (keyData == Keys.Right)
            {
                rY++;
                camera.RotateRight();
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }



            return true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (chosenObj >= 0 && chosenObj < drawObjs.Count)
            {
                drawObjs.RemoveAt(chosenObj);
                objNames.RemoveAt(chosenObj);
                objectList.Items.RemoveAt(chosenObj);

                chosenObj = -1;

                panel1.Visible = false;
            }
        }

        private void openGLControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Z)
            {
                zoom++;
            }
            if (e.KeyData == Keys.X)
            {
                zoom--;
            }

        }
    }
}
