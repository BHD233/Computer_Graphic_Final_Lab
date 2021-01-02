﻿using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18120320_Lab1
{
    //point but value is in double
    class CustomPoint
    {
        public double X = 0;
        public double Y = 0;

        public CustomPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public CustomPoint(Point p)
        {
            X = p.X;
            Y = p.Y;
        }

        public CustomPoint()
        {
            X = 0;
            Y = 0;
        }
    }
    //An Object interface for all draw object
    class Object
    {
        CustomPoint center;
        double scaleX = 1;
        double scaleY = 1;
        double scaleZ = 1;

        double rotateX = 0;
        double rotateY = 0;
        double rotateZ = 0;
        Color objColor = Color.White;

        bool isChosen = false;

        float outlineWeight = 1f;
        Color outlineColor = Color.White;

        //drawing function using method
        public virtual void Draw(OpenGL gl) 
        {
            
        }

        public CustomPoint Center
        {
            set
            {
                center = value;
            }
            get
            {
                return center;
            }
        }
        public double ScaleX
        {
            set
            {
                scaleX = value;
            }
            get
            {
                return scaleX;
            }
        }
        public double ScaleY
        {
            set
            {
                scaleY = value;
            }
            get
            {
                return scaleY;
            }
        }
        public double ScaleZ
        {
            set
            {
                scaleZ = value;
            }
            get
            {
                return scaleZ;
            }
        }
        public double RotateX
        {
            set
            {
                rotateX = value;
            }
            get
            {
                return rotateX;
            }
        }
        public double RotateY
        {
            set
            {
                rotateY = value;
            }
            get
            {
                return rotateY;
            }
        }
        public double RotateZ
        {
            set
            {
                rotateZ = value;
            }
            get
            {
                return rotateZ;
            }
        }
        public Color ObjColor
        {
            set
            {
                objColor = value;
                if (objColor == outlineColor)
                {
                    if (objColor == Color.Gray)
                    {
                        outlineColor = Color.White;
                    }
                    if (objColor == Color.White)
                    {
                        outlineColor = Color.Gray;
                    }
                }
            }
            get
            {
                return objColor;
            }
        }
        public bool IsChosen
        {
            set
            {
                isChosen = value;
            }
            get
            {
                return isChosen;
            }
        }
        public Color OutlineColor
        {
            set
            {
                outlineColor = value;
            }
            get
            {
                return outlineColor;
            }
        }
        public float OutlineWeight
        {
            set
            {
                outlineWeight = value;
            }
            get
            {
                return outlineWeight;
            }
        }

        public Object(Color color)
        {
            this.objColor = color;
            if (color == Color.Gray)
            {
                outlineColor = Color.White;
            }
        }

        public Object()
        {
            this.objColor = Color.Gray;
        }
    }
}