using System;

namespace _18120320_Lab1
{
    partial class SharpGLForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl = new SharpGL.OpenGLControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorHexagon = new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weightEditText = new System.Windows.Forms.TextBox();
            this.weightEditor = new System.Windows.Forms.HScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.paintButton = new System.Windows.Forms.Button();
            this.hexagonButton = new System.Windows.Forms.Button();
            this.pentagonButton = new System.Windows.Forms.Button();
            this.equilateralTriangleButton = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.ngonButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.cubeButton = new System.Windows.Forms.Button();
            this.pyramidButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.scalZInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.scalYInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.scalXInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rotZInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rotYInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rotXInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.posZInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.posYInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.posXInput = new System.Windows.Forms.TextBox();
            this.objNameInput = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.objectList = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.selecttexture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.BackColor = System.Drawing.SystemColors.Window;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(283, 12);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(5);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(1235, 934);
            this.openGLControl.TabIndex = 8;
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.openGLControl_KeyDown);
            // 
            // colorHexagon
            // 
            this.colorHexagon.Location = new System.Drawing.Point(1, 12);
            this.colorHexagon.Margin = new System.Windows.Forms.Padding(4);
            this.colorHexagon.Name = "colorHexagon";
            this.colorHexagon.Size = new System.Drawing.Size(276, 327);
            this.colorHexagon.TabIndex = 10;
            this.colorHexagon.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon.ColorChangedEventHandler(this.colorHexagon_ColorChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // weightEditText
            // 
            this.weightEditText.Location = new System.Drawing.Point(0, 0);
            this.weightEditText.Name = "weightEditText";
            this.weightEditText.Size = new System.Drawing.Size(100, 22);
            this.weightEditText.TabIndex = 0;
            // 
            // weightEditor
            // 
            this.weightEditor.Location = new System.Drawing.Point(0, 0);
            this.weightEditor.Name = "weightEditor";
            this.weightEditor.Size = new System.Drawing.Size(80, 17);
            this.weightEditor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // paintButton
            // 
            this.paintButton.Location = new System.Drawing.Point(0, 0);
            this.paintButton.Name = "paintButton";
            this.paintButton.Size = new System.Drawing.Size(75, 23);
            this.paintButton.TabIndex = 0;
            // 
            // hexagonButton
            // 
            this.hexagonButton.Location = new System.Drawing.Point(0, 0);
            this.hexagonButton.Name = "hexagonButton";
            this.hexagonButton.Size = new System.Drawing.Size(75, 23);
            this.hexagonButton.TabIndex = 0;
            // 
            // pentagonButton
            // 
            this.pentagonButton.Location = new System.Drawing.Point(0, 0);
            this.pentagonButton.Name = "pentagonButton";
            this.pentagonButton.Size = new System.Drawing.Size(75, 23);
            this.pentagonButton.TabIndex = 0;
            // 
            // equilateralTriangleButton
            // 
            this.equilateralTriangleButton.Location = new System.Drawing.Point(0, 0);
            this.equilateralTriangleButton.Name = "equilateralTriangleButton";
            this.equilateralTriangleButton.Size = new System.Drawing.Size(75, 23);
            this.equilateralTriangleButton.TabIndex = 0;
            // 
            // ellipseButton
            // 
            this.ellipseButton.Location = new System.Drawing.Point(0, 0);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(75, 23);
            this.ellipseButton.TabIndex = 0;
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(0, 0);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(75, 23);
            this.rectangleButton.TabIndex = 0;
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(0, 0);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(75, 23);
            this.circleButton.TabIndex = 0;
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(0, 0);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(75, 23);
            this.lineButton.TabIndex = 0;
            // 
            // ngonButton
            // 
            this.ngonButton.Location = new System.Drawing.Point(0, 0);
            this.ngonButton.Name = "ngonButton";
            this.ngonButton.Size = new System.Drawing.Size(75, 23);
            this.ngonButton.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(0, 0);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 0;
            // 
            // cubeButton
            // 
            this.cubeButton.Location = new System.Drawing.Point(95, 419);
            this.cubeButton.Margin = new System.Windows.Forms.Padding(4);
            this.cubeButton.Name = "cubeButton";
            this.cubeButton.Size = new System.Drawing.Size(100, 28);
            this.cubeButton.TabIndex = 11;
            this.cubeButton.Text = "Cube";
            this.cubeButton.UseVisualStyleBackColor = true;
            this.cubeButton.Click += new System.EventHandler(this.cubeButton_Click);
            // 
            // pyramidButton
            // 
            this.pyramidButton.Location = new System.Drawing.Point(95, 484);
            this.pyramidButton.Margin = new System.Windows.Forms.Padding(4);
            this.pyramidButton.Name = "pyramidButton";
            this.pyramidButton.Size = new System.Drawing.Size(100, 28);
            this.pyramidButton.TabIndex = 12;
            this.pyramidButton.Text = "Pyramid";
            this.pyramidButton.UseVisualStyleBackColor = true;
            this.pyramidButton.Click += new System.EventHandler(this.pyramidButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.scalZInput);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.scalYInput);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.scalXInput);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rotZInput);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rotYInput);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rotXInput);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.posZInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.posYInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.posXInput);
            this.panel1.Controls.Add(this.objNameInput);
            this.panel1.Controls.Add(this.x);
            this.panel1.Location = new System.Drawing.Point(1551, 543);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 273);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Scale";
            // 
            // scalZInput
            // 
            this.scalZInput.Location = new System.Drawing.Point(265, 217);
            this.scalZInput.Margin = new System.Windows.Forms.Padding(4);
            this.scalZInput.Name = "scalZInput";
            this.scalZInput.Size = new System.Drawing.Size(60, 22);
            this.scalZInput.TabIndex = 20;
            this.scalZInput.TextChanged += new System.EventHandler(this.ScalZInput_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(237, 218);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Z";
            this.label11.UseMnemonic = false;
            // 
            // scalYInput
            // 
            this.scalYInput.Location = new System.Drawing.Point(151, 215);
            this.scalYInput.Margin = new System.Windows.Forms.Padding(4);
            this.scalYInput.Name = "scalYInput";
            this.scalYInput.Size = new System.Drawing.Size(60, 22);
            this.scalYInput.TabIndex = 18;
            this.scalYInput.TextChanged += new System.EventHandler(this.ScalYInput_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(123, 217);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Y";
            this.label12.UseMnemonic = false;
            // 
            // scalXInput
            // 
            this.scalXInput.Location = new System.Drawing.Point(37, 214);
            this.scalXInput.Margin = new System.Windows.Forms.Padding(4);
            this.scalXInput.Name = "scalXInput";
            this.scalXInput.Size = new System.Drawing.Size(60, 22);
            this.scalXInput.TabIndex = 16;
            this.scalXInput.TextChanged += new System.EventHandler(this.ScalXInput_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 215);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "X";
            this.label13.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rotation";
            // 
            // rotZInput
            // 
            this.rotZInput.Location = new System.Drawing.Point(271, 148);
            this.rotZInput.Margin = new System.Windows.Forms.Padding(4);
            this.rotZInput.Name = "rotZInput";
            this.rotZInput.Size = new System.Drawing.Size(60, 22);
            this.rotZInput.TabIndex = 13;
            this.rotZInput.TextChanged += new System.EventHandler(this.RotZInput_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Z";
            this.label7.UseMnemonic = false;
            // 
            // rotYInput
            // 
            this.rotYInput.Location = new System.Drawing.Point(156, 146);
            this.rotYInput.Margin = new System.Windows.Forms.Padding(4);
            this.rotYInput.Name = "rotYInput";
            this.rotYInput.Size = new System.Drawing.Size(60, 22);
            this.rotYInput.TabIndex = 11;
            this.rotYInput.TextChanged += new System.EventHandler(this.RotYInput_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Y";
            this.label8.UseMnemonic = false;
            // 
            // rotXInput
            // 
            this.rotXInput.Location = new System.Drawing.Point(43, 145);
            this.rotXInput.Margin = new System.Windows.Forms.Padding(4);
            this.rotXInput.Name = "rotXInput";
            this.rotXInput.Size = new System.Drawing.Size(60, 22);
            this.rotXInput.TabIndex = 9;
            this.rotXInput.TextChanged += new System.EventHandler(this.RotXInput_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 146);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "X";
            this.label9.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Position";
            // 
            // posZInput
            // 
            this.posZInput.Location = new System.Drawing.Point(271, 76);
            this.posZInput.Margin = new System.Windows.Forms.Padding(4);
            this.posZInput.Name = "posZInput";
            this.posZInput.Size = new System.Drawing.Size(60, 22);
            this.posZInput.TabIndex = 6;
            this.posZInput.TextChanged += new System.EventHandler(this.posZInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z";
            this.label4.UseMnemonic = false;
            // 
            // posYInput
            // 
            this.posYInput.Location = new System.Drawing.Point(156, 75);
            this.posYInput.Margin = new System.Windows.Forms.Padding(4);
            this.posYInput.Name = "posYInput";
            this.posYInput.Size = new System.Drawing.Size(60, 22);
            this.posYInput.TabIndex = 4;
            this.posYInput.TextChanged += new System.EventHandler(this.posYInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            this.label3.UseMnemonic = false;
            // 
            // posXInput
            // 
            this.posXInput.Location = new System.Drawing.Point(43, 74);
            this.posXInput.Margin = new System.Windows.Forms.Padding(4);
            this.posXInput.Name = "posXInput";
            this.posXInput.Size = new System.Drawing.Size(60, 22);
            this.posXInput.TabIndex = 2;
            this.posXInput.TextChanged += new System.EventHandler(this.posXInput_TextChanged);
            // 
            // objNameInput
            // 
            this.objNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objNameInput.Location = new System.Drawing.Point(4, 9);
            this.objNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.objNameInput.Name = "objNameInput";
            this.objNameInput.Size = new System.Drawing.Size(132, 24);
            this.objNameInput.TabIndex = 1;
            this.objNameInput.Tag = "";
            this.objNameInput.TextChanged += new System.EventHandler(this.objName_TextChanged);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(15, 75);
            this.x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(18, 18);
            this.x.TabIndex = 0;
            this.x.Text = "X";
            this.x.UseMnemonic = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 552);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Prism";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.prismButton_Click);
            // 
            // objectList
            // 
            this.objectList.FormattingEnabled = true;
            this.objectList.ItemHeight = 16;
            this.objectList.Location = new System.Drawing.Point(1554, 11);
            this.objectList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objectList.Name = "objectList";
            this.objectList.Size = new System.Drawing.Size(357, 436);
            this.objectList.TabIndex = 22;
            this.objectList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.objectListClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1707, 484);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(44, 28);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "-";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // selecttexture
            // 
            this.selecttexture.Location = new System.Drawing.Point(13, 677);
            this.selecttexture.Margin = new System.Windows.Forms.Padding(4);
            this.selecttexture.Name = "selecttexture";
            this.selecttexture.Size = new System.Drawing.Size(237, 33);
            this.selecttexture.TabIndex = 11;
            this.selecttexture.Text = "select texture";
            this.selecttexture.UseVisualStyleBackColor = true;
            this.selecttexture.Click += new System.EventHandler(this.textureSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 721);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 213);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // SharpGLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1923, 961);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.objectList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pyramidButton);
            this.Controls.Add(this.selecttexture);
            this.Controls.Add(this.cubeButton);
            this.Controls.Add(this.colorHexagon);
            this.Controls.Add(this.openGLControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1799, 998);
            this.Name = "SharpGLForm";
            this.Text = "18120320-Bui_Huu_Duc";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button equilateralTriangleButton;
        private System.Windows.Forms.Button pentagonButton;
        private System.Windows.Forms.Button hexagonButton;
        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon colorHexagon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weightEditText;
        private System.Windows.Forms.HScrollBar weightEditor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button paintButton;
        private System.Windows.Forms.Button ngonButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cubeButton;
        private System.Windows.Forms.Button pyramidButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox objNameInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox scalZInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox scalYInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox scalXInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rotZInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rotYInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rotXInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox posZInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox posYInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox posXInput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox objectList;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button selecttexture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
