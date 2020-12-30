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
            this.objectList = new System.Windows.Forms.ListView();
            this.cubeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.BackColor = System.Drawing.SystemColors.Window;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(283, 12);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(1234, 943);
            this.openGLControl.TabIndex = 8;
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            // 
            // colorHexagon
            // 
            this.colorHexagon.Location = new System.Drawing.Point(1, 12);
            this.colorHexagon.Name = "colorHexagon";
            this.colorHexagon.Size = new System.Drawing.Size(276, 328);
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
            this.weightEditText.Size = new System.Drawing.Size(100, 20);
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
            // objectList
            // 
            this.objectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectList.FullRowSelect = true;
            this.objectList.HideSelection = false;
            this.objectList.Location = new System.Drawing.Point(1523, 12);
            this.objectList.Name = "objectList";
            this.objectList.Size = new System.Drawing.Size(255, 334);
            this.objectList.TabIndex = 0;
            this.objectList.TileSize = new System.Drawing.Size(200, 40);
            this.objectList.UseCompatibleStateImageBehavior = false;
            this.objectList.View = System.Windows.Forms.View.Tile;
            // 
            // cubeButton
            // 
            this.cubeButton.Location = new System.Drawing.Point(26, 371);
            this.cubeButton.Name = "cubeButton";
            this.cubeButton.Size = new System.Drawing.Size(75, 23);
            this.cubeButton.TabIndex = 11;
            this.cubeButton.Text = "CUBE";
            this.cubeButton.UseVisualStyleBackColor = true;
            this.cubeButton.Click += new System.EventHandler(this.cubeButton_Click);
            // 
            // SharpGLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 961);
            this.Controls.Add(this.cubeButton);
            this.Controls.Add(this.objectList);
            this.Controls.Add(this.colorHexagon);
            this.Controls.Add(this.openGLControl);
            this.MinimumSize = new System.Drawing.Size(1800, 1000);
            this.Name = "SharpGLForm";
            this.Text = "18120320-Bui_Huu_Duc";
            this.Load += new System.EventHandler(this.ShapGLForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.ResumeLayout(false);

        }

        private void ShapGLForm_Load(object sender, EventArgs e)
        {
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
        private System.Windows.Forms.ListView objectList;
        private System.Windows.Forms.Button cubeButton;
    }
}

