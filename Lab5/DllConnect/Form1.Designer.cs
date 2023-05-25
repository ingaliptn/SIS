namespace DllConnect
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
            this.buttonLoadDll = new System.Windows.Forms.Button();
            this.buttonStartMultiThreading = new System.Windows.Forms.Button();
            this.buttonCheckMath = new System.Windows.Forms.Button();
            this.buttonCheckCalculations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadDll
            // 
            this.buttonLoadDll.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLoadDll.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadDll.Location = new System.Drawing.Point(13, 15);
            this.buttonLoadDll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadDll.Name = "buttonLoadDll";
            this.buttonLoadDll.Size = new System.Drawing.Size(536, 45);
            this.buttonLoadDll.TabIndex = 0;
            this.buttonLoadDll.Text = "Load dll";
            this.buttonLoadDll.UseVisualStyleBackColor = false;
            this.buttonLoadDll.Click += new System.EventHandler(this.buttonLoadDll_Click);
            // 
            // buttonStartMultiThreading
            // 
            this.buttonStartMultiThreading.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonStartMultiThreading.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartMultiThreading.Location = new System.Drawing.Point(13, 186);
            this.buttonStartMultiThreading.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartMultiThreading.Name = "buttonStartMultiThreading";
            this.buttonStartMultiThreading.Size = new System.Drawing.Size(536, 51);
            this.buttonStartMultiThreading.TabIndex = 1;
            this.buttonStartMultiThreading.Text = "Multithreading sort ( high CPU load )";
            this.buttonStartMultiThreading.UseVisualStyleBackColor = false;
            this.buttonStartMultiThreading.Click += new System.EventHandler(this.buttonStartMultiThreading_Click);
            // 
            // buttonCheckMath
            // 
            this.buttonCheckMath.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCheckMath.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckMath.Location = new System.Drawing.Point(13, 127);
            this.buttonCheckMath.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheckMath.Name = "buttonCheckMath";
            this.buttonCheckMath.Size = new System.Drawing.Size(536, 51);
            this.buttonCheckMath.TabIndex = 2;
            this.buttonCheckMath.Text = "Checking the Math Library";
            this.buttonCheckMath.UseVisualStyleBackColor = false;
            this.buttonCheckMath.Click += new System.EventHandler(this.buttonCheckMath_Click);
            // 
            // buttonCheckCalculations
            // 
            this.buttonCheckCalculations.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCheckCalculations.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckCalculations.Location = new System.Drawing.Point(13, 68);
            this.buttonCheckCalculations.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheckCalculations.Name = "buttonCheckCalculations";
            this.buttonCheckCalculations.Size = new System.Drawing.Size(536, 51);
            this.buttonCheckCalculations.TabIndex = 3;
            this.buttonCheckCalculations.Text = "Perform calculations";
            this.buttonCheckCalculations.UseVisualStyleBackColor = false;
            this.buttonCheckCalculations.Click += new System.EventHandler(this.buttonCheckCalculations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 247);
            this.Controls.Add(this.buttonCheckCalculations);
            this.Controls.Add(this.buttonCheckMath);
            this.Controls.Add(this.buttonStartMultiThreading);
            this.Controls.Add(this.buttonLoadDll);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab05";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonCheckMath;
        private System.Windows.Forms.Button buttonLoadDll;
        private System.Windows.Forms.Button buttonStartMultiThreading;

        #endregion

        private System.Windows.Forms.Button buttonCheckCalculations;
    }
}