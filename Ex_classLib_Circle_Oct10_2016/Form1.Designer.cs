namespace Ex_classLib_Circle_Oct10_2016
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnCyllinder = new System.Windows.Forms.Button();
            this.btnCone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(256, 375);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(285, 28);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(71, 125);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnCyllinder
            // 
            this.btnCyllinder.Location = new System.Drawing.Point(285, 159);
            this.btnCyllinder.Name = "btnCyllinder";
            this.btnCyllinder.Size = new System.Drawing.Size(71, 119);
            this.btnCyllinder.TabIndex = 2;
            this.btnCyllinder.Text = "Cyllinder";
            this.btnCyllinder.UseVisualStyleBackColor = true;
            this.btnCyllinder.Click += new System.EventHandler(this.btnCyllinder_Click);
            // 
            // btnCone
            // 
            this.btnCone.Location = new System.Drawing.Point(285, 284);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(71, 119);
            this.btnCone.TabIndex = 3;
            this.btnCone.Text = "Cone";
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 436);
            this.Controls.Add(this.btnCone);
            this.Controls.Add(this.btnCyllinder);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnCyllinder;
        private System.Windows.Forms.Button btnCone;
    }
}

