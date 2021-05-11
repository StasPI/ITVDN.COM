namespace Calc
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
         this.lableA = new System.Windows.Forms.Label();
         this.lableB = new System.Windows.Forms.Label();
         this.lableResult = new System.Windows.Forms.Label();
         this.textBoxA = new System.Windows.Forms.TextBox();
         this.textBoxB = new System.Windows.Forms.TextBox();
         this.textBoxResult = new System.Windows.Forms.TextBox();
         this.ButtonPlus = new System.Windows.Forms.Button();
         this.ButtonMinus = new System.Windows.Forms.Button();
         this.ButtonTimes = new System.Windows.Forms.Button();
         this.ButtonDivision = new System.Windows.Forms.Button();
         this.ButtonClean = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lableA
         // 
         this.lableA.AutoSize = true;
         this.lableA.Location = new System.Drawing.Point(12, 9);
         this.lableA.Name = "lableA";
         this.lableA.Size = new System.Drawing.Size(13, 15);
         this.lableA.TabIndex = 0;
         this.lableA.Text = "a";
         // 
         // lableB
         // 
         this.lableB.AutoSize = true;
         this.lableB.Location = new System.Drawing.Point(176, 9);
         this.lableB.Name = "lableB";
         this.lableB.Size = new System.Drawing.Size(14, 15);
         this.lableB.TabIndex = 1;
         this.lableB.Text = "b";
         // 
         // lableResult
         // 
         this.lableResult.AutoSize = true;
         this.lableResult.Location = new System.Drawing.Point(387, 9);
         this.lableResult.Name = "lableResult";
         this.lableResult.Size = new System.Drawing.Size(36, 15);
         this.lableResult.TabIndex = 2;
         this.lableResult.Text = "result";
         // 
         // textBoxA
         // 
         this.textBoxA.Location = new System.Drawing.Point(12, 33);
         this.textBoxA.Name = "textBoxA";
         this.textBoxA.Size = new System.Drawing.Size(127, 23);
         this.textBoxA.TabIndex = 3;
         // 
         // textBoxB
         // 
         this.textBoxB.Location = new System.Drawing.Point(176, 33);
         this.textBoxB.Name = "textBoxB";
         this.textBoxB.Size = new System.Drawing.Size(120, 23);
         this.textBoxB.TabIndex = 4;
         // 
         // textBoxResult
         // 
         this.textBoxResult.Location = new System.Drawing.Point(387, 33);
         this.textBoxResult.Name = "textBoxResult";
         this.textBoxResult.Size = new System.Drawing.Size(121, 23);
         this.textBoxResult.TabIndex = 5;
         // 
         // ButtonPlus
         // 
         this.ButtonPlus.Location = new System.Drawing.Point(62, 86);
         this.ButtonPlus.Name = "ButtonPlus";
         this.ButtonPlus.Size = new System.Drawing.Size(75, 23);
         this.ButtonPlus.TabIndex = 6;
         this.ButtonPlus.Text = "Plus";
         this.ButtonPlus.UseVisualStyleBackColor = true;
         this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
         // 
         // ButtonMinus
         // 
         this.ButtonMinus.Location = new System.Drawing.Point(163, 86);
         this.ButtonMinus.Name = "ButtonMinus";
         this.ButtonMinus.Size = new System.Drawing.Size(75, 23);
         this.ButtonMinus.TabIndex = 7;
         this.ButtonMinus.Text = "Minus";
         this.ButtonMinus.UseVisualStyleBackColor = true;
         this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
         // 
         // ButtonTimes
         // 
         this.ButtonTimes.Location = new System.Drawing.Point(268, 86);
         this.ButtonTimes.Name = "ButtonTimes";
         this.ButtonTimes.Size = new System.Drawing.Size(75, 23);
         this.ButtonTimes.TabIndex = 8;
         this.ButtonTimes.Text = "Times";
         this.ButtonTimes.UseVisualStyleBackColor = true;
         this.ButtonTimes.Click += new System.EventHandler(this.ButtonTimes_Click);
         // 
         // ButtonDivision
         // 
         this.ButtonDivision.Location = new System.Drawing.Point(374, 86);
         this.ButtonDivision.Name = "ButtonDivision";
         this.ButtonDivision.Size = new System.Drawing.Size(75, 23);
         this.ButtonDivision.TabIndex = 9;
         this.ButtonDivision.Text = "Division";
         this.ButtonDivision.UseVisualStyleBackColor = true;
         this.ButtonDivision.Click += new System.EventHandler(this.ButtonDivision_Click);
         // 
         // ButtonClean
         // 
         this.ButtonClean.Location = new System.Drawing.Point(558, 33);
         this.ButtonClean.Name = "ButtonClean";
         this.ButtonClean.Size = new System.Drawing.Size(75, 23);
         this.ButtonClean.TabIndex = 10;
         this.ButtonClean.Text = "Clean";
         this.ButtonClean.UseVisualStyleBackColor = true;
         this.ButtonClean.Click += new System.EventHandler(this.ButtonClean_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(701, 152);
         this.Controls.Add(this.ButtonClean);
         this.Controls.Add(this.ButtonDivision);
         this.Controls.Add(this.ButtonTimes);
         this.Controls.Add(this.ButtonMinus);
         this.Controls.Add(this.ButtonPlus);
         this.Controls.Add(this.textBoxResult);
         this.Controls.Add(this.textBoxB);
         this.Controls.Add(this.textBoxA);
         this.Controls.Add(this.lableResult);
         this.Controls.Add(this.lableB);
         this.Controls.Add(this.lableA);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      #endregion

      public System.Windows.Forms.Label lableA;
      public System.Windows.Forms.Label lableB;
      public System.Windows.Forms.Label lableResult;
      public System.Windows.Forms.TextBox textBoxA;
      public System.Windows.Forms.TextBox textBoxB;
      public System.Windows.Forms.TextBox textBoxResult;
      public System.Windows.Forms.Button ButtonPlus;
      public System.Windows.Forms.Button ButtonMinus;
      public System.Windows.Forms.Button ButtonTimes;
      public System.Windows.Forms.Button ButtonDivision;
      public System.Windows.Forms.Button ButtonClean;
   }
}

