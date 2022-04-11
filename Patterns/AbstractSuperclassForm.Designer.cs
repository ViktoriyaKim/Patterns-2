
namespace Patterns
{
    partial class AbstractSuperclassForm
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
            this._circleButton = new System.Windows.Forms.Button();
            this._rectangleButton = new System.Windows.Forms.Button();
            this._ellipseButton = new System.Windows.Forms.Button();
            this._squareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _circleButton
            // 
            this._circleButton.Location = new System.Drawing.Point(120, 395);
            this._circleButton.Name = "_circleButton";
            this._circleButton.Size = new System.Drawing.Size(113, 35);
            this._circleButton.TabIndex = 1;
            this._circleButton.Text = "Круг";
            this._circleButton.UseVisualStyleBackColor = true;
            this._circleButton.Click += new System.EventHandler(this._circleButton_Click);
            // 
            // _rectangleButton
            // 
            this._rectangleButton.Location = new System.Drawing.Point(272, 395);
            this._rectangleButton.Name = "_rectangleButton";
            this._rectangleButton.Size = new System.Drawing.Size(113, 35);
            this._rectangleButton.TabIndex = 2;
            this._rectangleButton.Text = "Прямоугольник";
            this._rectangleButton.UseVisualStyleBackColor = true;
            this._rectangleButton.Click += new System.EventHandler(this._rectangleButton_Click);
            // 
            // _ellipseButton
            // 
            this._ellipseButton.Location = new System.Drawing.Point(420, 395);
            this._ellipseButton.Name = "_ellipseButton";
            this._ellipseButton.Size = new System.Drawing.Size(113, 35);
            this._ellipseButton.TabIndex = 3;
            this._ellipseButton.Text = "Эллипс";
            this._ellipseButton.UseVisualStyleBackColor = true;
            this._ellipseButton.Click += new System.EventHandler(this._ellipseButton_Click);
            // 
            // _squareButton
            // 
            this._squareButton.Location = new System.Drawing.Point(561, 395);
            this._squareButton.Name = "_squareButton";
            this._squareButton.Size = new System.Drawing.Size(113, 35);
            this._squareButton.TabIndex = 4;
            this._squareButton.Text = "Квадрат";
            this._squareButton.UseVisualStyleBackColor = true;
            this._squareButton.Click += new System.EventHandler(this._squareButton_Click);
            // 
            // AbstractSuperclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._squareButton);
            this.Controls.Add(this._ellipseButton);
            this.Controls.Add(this._rectangleButton);
            this.Controls.Add(this._circleButton);
            this.Name = "AbstractSuperclass";
            this.Text = "AbstractSuperclass";
            this.Load += new System.EventHandler(this.AbstractSuperclass_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _circleButton;
        private System.Windows.Forms.Button _rectangleButton;
        private System.Windows.Forms.Button _ellipseButton;
        private System.Windows.Forms.Button _squareButton;
    }
}