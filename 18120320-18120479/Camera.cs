using System;
using System.Collections.Generic;
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
    class Camera
    {
        public void Execute(OpenGL gl)
        {
            Zoom(gl, zoomValue);
            Rotate(gl, rX, rY, rZ);
        }

        public float ZoomValue
        {
            set
            {
                zoomValue = value;
            }
            get
            {
                return zoomValue;
            }
        }
        public float RX
        {
            set
            {
                rX = value;
            }
            get
            {
                return rX;
            }
        }
        public float RY
        {
            set
            {
                rY = value;
            }
            get
            {
                return rY;
            }
        }
        public float RZ
        {
            set
            {
                rZ = value;
            }
            get
            {
                return rZ;
            }
        }

        float zoomValue, rX, rY, rZ;

        private void Zoom(OpenGL gl, float zoomValue)
        {
            gl.Translate(0.0f, 0.0f, -(20.0f - zoomValue));
        }

        private void Rotate(OpenGL gl, float rX, float rY, float rZ)
        {
            gl.Rotate(rX, rY, rZ);
        }

        public Camera()
        {
            zoomValue = 0f;
            rX = 0f;
            rY = 0f;
            rZ = 0f;
        }
    }
}
