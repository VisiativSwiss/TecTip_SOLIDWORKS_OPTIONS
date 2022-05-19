namespace Tec_Tip_SWOptions
{
    partial class Form1
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
            this.RadioButton_SolidSurfaceGeometry = new System.Windows.Forms.RadioButton();
            this.RadioButton_Wireframe = new System.Windows.Forms.RadioButton();
            this.CheckBox_ExportSketch = new System.Windows.Forms.CheckBox();
            this.TextBox_StepFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadioButton_SolidSurfaceGeometry
            // 
            this.RadioButton_SolidSurfaceGeometry.AutoSize = true;
            this.RadioButton_SolidSurfaceGeometry.Location = new System.Drawing.Point(99, 33);
            this.RadioButton_SolidSurfaceGeometry.Name = "RadioButton_SolidSurfaceGeometry";
            this.RadioButton_SolidSurfaceGeometry.Size = new System.Drawing.Size(136, 17);
            this.RadioButton_SolidSurfaceGeometry.TabIndex = 2;
            this.RadioButton_SolidSurfaceGeometry.TabStop = true;
            this.RadioButton_SolidSurfaceGeometry.Text = "Solid/Surface geometry";
            this.RadioButton_SolidSurfaceGeometry.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Wireframe
            // 
            this.RadioButton_Wireframe.AutoSize = true;
            this.RadioButton_Wireframe.Location = new System.Drawing.Point(99, 56);
            this.RadioButton_Wireframe.Name = "RadioButton_Wireframe";
            this.RadioButton_Wireframe.Size = new System.Drawing.Size(73, 17);
            this.RadioButton_Wireframe.TabIndex = 3;
            this.RadioButton_Wireframe.TabStop = true;
            this.RadioButton_Wireframe.Text = "Wireframe";
            this.RadioButton_Wireframe.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ExportSketch
            // 
            this.CheckBox_ExportSketch.AutoSize = true;
            this.CheckBox_ExportSketch.Location = new System.Drawing.Point(118, 80);
            this.CheckBox_ExportSketch.Name = "CheckBox_ExportSketch";
            this.CheckBox_ExportSketch.Size = new System.Drawing.Size(127, 17);
            this.CheckBox_ExportSketch.TabIndex = 4;
            this.CheckBox_ExportSketch.Text = "Export sketch entities";
            this.CheckBox_ExportSketch.UseVisualStyleBackColor = true;
            // 
            // TextBox_StepFormat
            // 
            this.TextBox_StepFormat.Location = new System.Drawing.Point(99, 7);
            this.TextBox_StepFormat.Name = "TextBox_StepFormat";
            this.TextBox_StepFormat.Size = new System.Drawing.Size(174, 20);
            this.TextBox_StepFormat.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "STEP FORMAT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 134);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox_StepFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBox_ExportSketch);
            this.Controls.Add(this.RadioButton_Wireframe);
            this.Controls.Add(this.RadioButton_SolidSurfaceGeometry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioButton_SolidSurfaceGeometry;
        private System.Windows.Forms.RadioButton RadioButton_Wireframe;
        private System.Windows.Forms.CheckBox CheckBox_ExportSketch;
        private System.Windows.Forms.TextBox TextBox_StepFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

