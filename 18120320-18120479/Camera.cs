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
        double eyeX, eyeY, eyeZ;
        double lookX, lookY, lookZ;
        double radius;
        double theta;
        double phi;

        public void Execute(OpenGL gl)
        {
            gl.LookAt(eyeX, eyeY, eyeZ, lookX, lookY, lookZ, 0, 1 * Math.Cos(phi), 0);
        }

        public void ZoomIn()
        {
            eyeX += -0.02 * eyeX;
            eyeY += -0.02 * eyeY;
            eyeZ += -0.02 * eyeZ;

            CalculateRadius();
            CalculateTheta();
            CalculatePhi();
        }

        public void ZoomOut()
        {
            eyeX += 0.02 * eyeX;
            eyeY += 0.02 * eyeY;
            eyeZ += 0.02 * eyeZ;

            CalculateRadius();
            CalculateTheta();
            CalculatePhi();
        }

        public void RotateRight()
        {
            theta += 0.02;
            eyeX = lookX + radius * Math.Cos(phi) * Math.Sin(theta);
            eyeZ = lookZ + radius * Math.Cos(phi) * Math.Cos(theta);
        }

        public void RotateLeft()
        {
            theta -= 0.02;
            eyeX = lookX + radius * Math.Cos(phi) * Math.Sin(theta);
            eyeZ = lookZ + radius * Math.Cos(phi) * Math.Cos(theta);
        }

        public void RotateUp()
        {
            phi += 0.02;
            eyeY = lookY + radius * Math.Sin(phi);
            eyeZ = lookZ + radius * Math.Cos(phi) * Math.Cos(theta);
            eyeX = lookX + radius * Math.Cos(phi) * Math.Sin(theta);
        }

        public void RotateDown()
        {
            phi -= 0.02;

            eyeY = lookY + radius * Math.Sin(phi);
            eyeZ = lookZ + radius * Math.Cos(phi) * Math.Cos(theta);
            eyeX = lookX + radius * Math.Cos(phi) * Math.Sin(theta);
        }

        public Camera()
        {
            eyeX = 20;
            eyeY = 5;
            eyeZ = 20;
            lookX = 0;
            lookY = 0;
            lookZ = 0;

            CalculateRadius();
            CalculateTheta();
            CalculatePhi();
        }

        private void CalculateTheta()
        {
            theta = Math.Atan((eyeX - lookX) / (eyeZ - lookZ));
        }

        private void CalculatePhi()
        {
            phi = Math.Asin((eyeY - lookY) / radius);
        }

        //Calculate radius from eye to look
        private void CalculateRadius()
        {
            radius = Math.Sqrt(Math.Pow(eyeX - lookX, 2)
                     + Math.Pow(eyeY - lookY, 2)
                     + Math.Pow(eyeZ - lookZ, 2));
        }
    }
}
