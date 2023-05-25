namespace Lab04
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
            this.GlobalProgramRun = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalUserProgram = new System.Windows.Forms.RichTextBox();
            this.SheduleTask = new System.Windows.Forms.RichTextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.AddToAutoStart = new System.Windows.Forms.Button();
            this.AutostartProgram = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentTask = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddToAssociation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RegisterSection = new System.Windows.Forms.TextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GlobalProgramRun
            // 
            this.GlobalProgramRun.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobalProgramRun.Location = new System.Drawing.Point(19, 36);
            this.GlobalProgramRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GlobalProgramRun.Name = "GlobalProgramRun";
            this.GlobalProgramRun.Size = new System.Drawing.Size(386, 676);
            this.GlobalProgramRun.TabIndex = 1;
            this.GlobalProgramRun.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Global Program Run";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local User Program";
            // 
            // LocalUserProgram
            // 
            this.LocalUserProgram.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalUserProgram.Location = new System.Drawing.Point(411, 36);
            this.LocalUserProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocalUserProgram.Name = "LocalUserProgram";
            this.LocalUserProgram.Size = new System.Drawing.Size(386, 676);
            this.LocalUserProgram.TabIndex = 3;
            this.LocalUserProgram.Text = "";
            this.LocalUserProgram.TextChanged += new System.EventHandler(this.richTextBoxCurrentUserPrograms_TextChanged);
            // 
            // SheduleTask
            // 
            this.SheduleTask.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheduleTask.Location = new System.Drawing.Point(803, 36);
            this.SheduleTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SheduleTask.Name = "SheduleTask";
            this.SheduleTask.Size = new System.Drawing.Size(470, 673);
            this.SheduleTask.TabIndex = 6;
            this.SheduleTask.Text = "";
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(1306, 783);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(383, 55);
            this.Refresh.TabIndex = 7;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // AddToAutoStart
            // 
            this.AddToAutoStart.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToAutoStart.Location = new System.Drawing.Point(1064, 718);
            this.AddToAutoStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddToAutoStart.Name = "AddToAutoStart";
            this.AddToAutoStart.Size = new System.Drawing.Size(236, 58);
            this.AddToAutoStart.TabIndex = 8;
            this.AddToAutoStart.Text = "Add";
            this.AddToAutoStart.UseVisualStyleBackColor = true;
            this.AddToAutoStart.Click += new System.EventHandler(this.buttonAddToAutoStart_Click);
            // 
            // AutostartProgram
            // 
            this.AutostartProgram.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutostartProgram.Location = new System.Drawing.Point(313, 718);
            this.AutostartProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutostartProgram.Name = "AutostartProgram";
            this.AutostartProgram.Size = new System.Drawing.Size(745, 32);
            this.AutostartProgram.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(930, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Schedule Tasks";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CurrentTask
            // 
            this.CurrentTask.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTask.Location = new System.Drawing.Point(1279, 36);
            this.CurrentTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentTask.Name = "CurrentTask";
            this.CurrentTask.Size = new System.Drawing.Size(411, 673);
            this.CurrentTask.TabIndex = 12;
            this.CurrentTask.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1414, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Current Task";
            // 
            // AddToAssociation
            // 
            this.AddToAssociation.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToAssociation.Location = new System.Drawing.Point(1306, 718);
            this.AddToAssociation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddToAssociation.Name = "AddToAssociation";
            this.AddToAssociation.Size = new System.Drawing.Size(384, 58);
            this.AddToAssociation.TabIndex = 13;
            this.AddToAssociation.Text = "Add .ttt to the association";
            this.AddToAssociation.UseVisualStyleBackColor = true;
            this.AddToAssociation.Click += new System.EventHandler(this.buttonAddToAssociation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 811);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Register section:";
            // 
            // RegisterSection
            // 
            this.RegisterSection.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterSection.Location = new System.Drawing.Point(313, 811);
            this.RegisterSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterSection.Name = "RegisterSection";
            this.RegisterSection.Size = new System.Drawing.Size(745, 32);
            this.RegisterSection.TabIndex = 15;
            // 
            // Copy
            // 
            this.Copy.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy.Location = new System.Drawing.Point(1064, 783);
            this.Copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(236, 55);
            this.Copy.TabIndex = 16;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.buttonCopy_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 718);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Autostart program:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(37, 764);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(312, 31);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "If you want to delete from autostart";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 849);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.RegisterSection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddToAssociation);
            this.Controls.Add(this.CurrentTask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AutostartProgram);
            this.Controls.Add(this.AddToAutoStart);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.SheduleTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LocalUserProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GlobalProgramRun);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab04";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox GlobalProgramRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox LocalUserProgram;
        private System.Windows.Forms.RichTextBox SheduleTask;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button AddToAutoStart;
        private System.Windows.Forms.TextBox AutostartProgram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox CurrentTask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddToAssociation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RegisterSection;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

