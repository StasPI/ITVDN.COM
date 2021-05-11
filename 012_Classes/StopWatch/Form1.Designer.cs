namespace StopWatch
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
         this.components = new System.ComponentModel.Container();
         this.TextBox = new System.Windows.Forms.TextBox();
         this.ResetButton = new System.Windows.Forms.Button();
         this.StopButton = new System.Windows.Forms.Button();
         this.StartButton = new System.Windows.Forms.Button();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.SuspendLayout();
         // 
         // TextBox
         // 
         this.TextBox.Location = new System.Drawing.Point(46, 114);
         this.TextBox.Name = "TextBox";
         this.TextBox.Size = new System.Drawing.Size(101, 23);
         this.TextBox.TabIndex = 3;
         // 
         // ResetButton
         // 
         this.ResetButton.Location = new System.Drawing.Point(58, 85);
         this.ResetButton.Name = "ResetButton";
         this.ResetButton.Size = new System.Drawing.Size(75, 23);
         this.ResetButton.TabIndex = 2;
         this.ResetButton.Text = "Reset";
         this.ResetButton.UseVisualStyleBackColor = true;
         this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
         // 
         // StopButton
         // 
         this.StopButton.Location = new System.Drawing.Point(58, 56);
         this.StopButton.Name = "StopButton";
         this.StopButton.Size = new System.Drawing.Size(75, 23);
         this.StopButton.TabIndex = 1;
         this.StopButton.Text = "Stop";
         this.StopButton.UseVisualStyleBackColor = true;
         this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
         // 
         // StartButton
         // 
         this.StartButton.Location = new System.Drawing.Point(58, 27);
         this.StartButton.Name = "StartButton";
         this.StartButton.Size = new System.Drawing.Size(75, 23);
         this.StartButton.TabIndex = 0;
         this.StartButton.Text = "Start";
         this.StartButton.UseVisualStyleBackColor = true;
         this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
         // 
         // timer1
         // 
         this.timer1.Interval = 1000;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(187, 141);
         this.Controls.Add(this.TextBox);
         this.Controls.Add(this.ResetButton);
         this.Controls.Add(this.StopButton);
         this.Controls.Add(this.StartButton);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      #endregion
      public System.Windows.Forms.TextBox TextBox;
      public System.Windows.Forms.Button StartButton;
      public System.Windows.Forms.Button StopButton;
      public System.Windows.Forms.Button ResetButton;
      public System.Windows.Forms.Timer timer1;
   }
}

