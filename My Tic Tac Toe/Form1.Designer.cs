namespace My_Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonA1 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.buttonB2 = new System.Windows.Forms.Button();
            this.buttonB1 = new System.Windows.Forms.Button();
            this.buttonC2 = new System.Windows.Forms.Button();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.buttonC3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonA1
            // 
            this.buttonA1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonA1.BackgroundImage")));
            this.buttonA1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonA1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonA1.Location = new System.Drawing.Point(24, 22);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(100, 100);
            this.buttonA1.TabIndex = 0;
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.Click += new System.EventHandler(this.buttonA1_Click);
            // 
            // buttonA2
            // 
            this.buttonA2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonA2.BackgroundImage")));
            this.buttonA2.Location = new System.Drawing.Point(134, 22);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(100, 100);
            this.buttonA2.TabIndex = 1;
            this.buttonA2.UseVisualStyleBackColor = true;
            this.buttonA2.Click += new System.EventHandler(this.buttonA2_Click);
            // 
            // buttonA3
            // 
            this.buttonA3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonA3.BackgroundImage")));
            this.buttonA3.Location = new System.Drawing.Point(245, 22);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(100, 100);
            this.buttonA3.TabIndex = 2;
            this.buttonA3.UseVisualStyleBackColor = true;
            this.buttonA3.Click += new System.EventHandler(this.buttonA3_Click);
            // 
            // buttonB3
            // 
            this.buttonB3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonB3.BackgroundImage")));
            this.buttonB3.Location = new System.Drawing.Point(245, 136);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(100, 100);
            this.buttonB3.TabIndex = 5;
            this.buttonB3.UseVisualStyleBackColor = true;
            // 
            // buttonB2
            // 
            this.buttonB2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonB2.BackgroundImage")));
            this.buttonB2.Location = new System.Drawing.Point(134, 136);
            this.buttonB2.Name = "buttonB2";
            this.buttonB2.Size = new System.Drawing.Size(100, 100);
            this.buttonB2.TabIndex = 4;
            this.buttonB2.UseVisualStyleBackColor = true;
            // 
            // buttonB1
            // 
            this.buttonB1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonB1.BackgroundImage")));
            this.buttonB1.Location = new System.Drawing.Point(24, 136);
            this.buttonB1.Name = "buttonB1";
            this.buttonB1.Size = new System.Drawing.Size(100, 100);
            this.buttonB1.TabIndex = 3;
            this.buttonB1.UseVisualStyleBackColor = true;
            // 
            // buttonC2
            // 
            this.buttonC2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonC2.BackgroundImage")));
            this.buttonC2.Location = new System.Drawing.Point(134, 249);
            this.buttonC2.Name = "buttonC2";
            this.buttonC2.Size = new System.Drawing.Size(100, 100);
            this.buttonC2.TabIndex = 10;
            this.buttonC2.UseVisualStyleBackColor = true;
            // 
            // buttonC1
            // 
            this.buttonC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonC1.BackgroundImage")));
            this.buttonC1.Location = new System.Drawing.Point(24, 249);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(100, 100);
            this.buttonC1.TabIndex = 9;
            this.buttonC1.UseVisualStyleBackColor = true;
            // 
            // buttonC3
            // 
            this.buttonC3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonC3.BackgroundImage")));
            this.buttonC3.Location = new System.Drawing.Point(245, 249);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(100, 100);
            this.buttonC3.TabIndex = 11;
            this.buttonC3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 372);
            this.Controls.Add(this.buttonC3);
            this.Controls.Add(this.buttonC2);
            this.Controls.Add(this.buttonC1);
            this.Controls.Add(this.buttonB3);
            this.Controls.Add(this.buttonB2);
            this.Controls.Add(this.buttonB1);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonA2);
            this.Controls.Add(this.buttonA1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIC TAC TOE";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonA1;
        private Button buttonA2;
        private Button buttonA3;
        private Button buttonB3;
        private Button buttonB2;
        private Button buttonB1;
        private Button buttonC2;
        private Button buttonC1;
        private Button buttonC3;
    }
}