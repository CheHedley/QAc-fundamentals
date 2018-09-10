namespace ShapeUI
{
    partial class ShapeForm
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
            this.SelectAShape = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TriangleSideA = new System.Windows.Forms.Label();
            this.TriangleSideB = new System.Windows.Forms.Label();
            this.TriangleSideC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TrianglePerimeter = new System.Windows.Forms.Label();
            this.TriangleArea = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectAShape
            // 
            this.SelectAShape.AutoSize = true;
            this.SelectAShape.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAShape.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectAShape.Location = new System.Drawing.Point(72, 56);
            this.SelectAShape.Name = "SelectAShape";
            this.SelectAShape.Size = new System.Drawing.Size(127, 19);
            this.SelectAShape.TabIndex = 0;
            this.SelectAShape.Text = "Select a shape";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Triangle",
            "Square",
            "Rectangle",
            "Hexagon"});
            this.comboBox1.Location = new System.Drawing.Point(240, 56);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 25);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TriangleSideC);
            this.groupBox1.Controls.Add(this.TriangleSideB);
            this.groupBox1.Controls.Add(this.TriangleSideA);
            this.groupBox1.Controls.Add(this.CalculateButton);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(240, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(369, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape dimensions";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 61);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 25);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 95);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 25);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(91, 154);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(205, 30);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // TriangleSideA
            // 
            this.TriangleSideA.AutoSize = true;
            this.TriangleSideA.Location = new System.Drawing.Point(44, 30);
            this.TriangleSideA.Name = "TriangleSideA";
            this.TriangleSideA.Size = new System.Drawing.Size(45, 17);
            this.TriangleSideA.TabIndex = 3;
            this.TriangleSideA.Text = "Side A";
            this.TriangleSideA.Click += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TriangleSideB
            // 
            this.TriangleSideB.AutoSize = true;
            this.TriangleSideB.Location = new System.Drawing.Point(44, 64);
            this.TriangleSideB.Name = "TriangleSideB";
            this.TriangleSideB.Size = new System.Drawing.Size(44, 17);
            this.TriangleSideB.TabIndex = 7;
            this.TriangleSideB.Text = "Side B";
            this.TriangleSideB.Click += new System.EventHandler(this.TriangleSideB_Click);
            // 
            // TriangleSideC
            // 
            this.TriangleSideC.AutoSize = true;
            this.TriangleSideC.Location = new System.Drawing.Point(44, 98);
            this.TriangleSideC.Name = "TriangleSideC";
            this.TriangleSideC.Size = new System.Drawing.Size(45, 17);
            this.TriangleSideC.TabIndex = 8;
            this.TriangleSideC.Text = "Side C";
            this.TriangleSideC.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TriangleArea);
            this.groupBox2.Controls.Add(this.TrianglePerimeter);
            this.groupBox2.Location = new System.Drawing.Point(331, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 82);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // TrianglePerimeter
            // 
            this.TrianglePerimeter.AutoSize = true;
            this.TrianglePerimeter.Location = new System.Drawing.Point(17, 25);
            this.TrianglePerimeter.Name = "TrianglePerimeter";
            this.TrianglePerimeter.Size = new System.Drawing.Size(71, 17);
            this.TrianglePerimeter.TabIndex = 0;
            this.TrianglePerimeter.Text = "Perimeter: ";
            // 
            // TriangleArea
            // 
            this.TriangleArea.AutoSize = true;
            this.TriangleArea.Location = new System.Drawing.Point(17, 53);
            this.TriangleArea.Name = "TriangleArea";
            this.TriangleArea.Size = new System.Drawing.Size(38, 17);
            this.TriangleArea.TabIndex = 1;
            this.TriangleArea.Text = "Area:";
            // 
            // ShapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 589);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SelectAShape);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShapeForm";
            this.Text = "Shape Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectAShape;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label TriangleSideA;
        private System.Windows.Forms.Label TriangleSideC;
        private System.Windows.Forms.Label TriangleSideB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TriangleArea;
        private System.Windows.Forms.Label TrianglePerimeter;
    }
}

