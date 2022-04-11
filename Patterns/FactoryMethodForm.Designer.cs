
namespace Patterns
{
    partial class FactoryMethodForm
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
            this.label1 = new System.Windows.Forms.Label();
            this._shapeCouner = new System.Windows.Forms.DomainUpDown();
            this._createShapeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число сторон";
            // 
            // _shapeCouner
            // 
            this._shapeCouner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._shapeCouner.Items.Add("0");
            this._shapeCouner.Items.Add("1");
            this._shapeCouner.Items.Add("2");
            this._shapeCouner.Items.Add("3");
            this._shapeCouner.Items.Add("4");
            this._shapeCouner.Items.Add("5");
            this._shapeCouner.Location = new System.Drawing.Point(318, 31);
            this._shapeCouner.Name = "_shapeCouner";
            this._shapeCouner.ReadOnly = true;
            this._shapeCouner.Size = new System.Drawing.Size(60, 20);
            this._shapeCouner.TabIndex = 1;
            // 
            // _createShapeButton
            // 
            this._createShapeButton.Location = new System.Drawing.Point(384, 28);
            this._createShapeButton.Name = "_createShapeButton";
            this._createShapeButton.Size = new System.Drawing.Size(75, 23);
            this._createShapeButton.TabIndex = 2;
            this._createShapeButton.Text = "Создать";
            this._createShapeButton.UseVisualStyleBackColor = true;
            this._createShapeButton.Click += new System.EventHandler(this._createShapeButton_Click);
            // 
            // FactoryMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._createShapeButton);
            this.Controls.Add(this._shapeCouner);
            this.Controls.Add(this.label1);
            this.Name = "FactoryMethodForm";
            this.Text = "FactoryMethodForm";
            this.Load += new System.EventHandler(this.FactoryMethodForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown _shapeCouner;
        private System.Windows.Forms.Button _createShapeButton;
    }
}