namespace Assigment__7__MovieBonanza
{
    partial class StreamForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StreamCosttextBox1 = new System.Windows.Forms.TextBox();
            this.StreamTitletextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.OkButton.Location = new System.Drawing.Point(139, 259);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(50, 35);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thank for choosing our App!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "You\'ve been charged:  $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sit tight and enjoy the movie! ";
            // 
            // StreamCosttextBox1
            // 
            this.StreamCosttextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StreamCosttextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StreamCosttextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamCosttextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.StreamCosttextBox1.Location = new System.Drawing.Point(209, 81);
            this.StreamCosttextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StreamCosttextBox1.Name = "StreamCosttextBox1";
            this.StreamCosttextBox1.ReadOnly = true;
            this.StreamCosttextBox1.Size = new System.Drawing.Size(69, 19);
            this.StreamCosttextBox1.TabIndex = 4;
            // 
            // StreamTitletextBox2
            // 
            this.StreamTitletextBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StreamTitletextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StreamTitletextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamTitletextBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.StreamTitletextBox2.Location = new System.Drawing.Point(15, 153);
            this.StreamTitletextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StreamTitletextBox2.Name = "StreamTitletextBox2";
            this.StreamTitletextBox2.ReadOnly = true;
            this.StreamTitletextBox2.Size = new System.Drawing.Size(285, 22);
            this.StreamTitletextBox2.TabIndex = 5;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(317, 302);
            this.ControlBox = false;
            this.Controls.Add(this.StreamTitletextBox2);
            this.Controls.Add(this.StreamCosttextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stream";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox StreamCosttextBox1;
        public System.Windows.Forms.TextBox StreamTitletextBox2;
    }
}