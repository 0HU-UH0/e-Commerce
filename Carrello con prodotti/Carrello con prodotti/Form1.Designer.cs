namespace Carrello_con_prodotti
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
            button1 = new Button();
            button2 = new Button();
            Carrello = new ListBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(67, 621);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(109, 82);
            button1.TabIndex = 0;
            button1.Text = "AGGIUNGI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(384, 620);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(109, 85);
            button2.TabIndex = 1;
            button2.Text = "RIMUOVI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Carrello
            // 
            Carrello.FormattingEnabled = true;
            Carrello.ItemHeight = 25;
            Carrello.Location = new Point(566, 26);
            Carrello.Margin = new Padding(4, 5, 4, 5);
            Carrello.Name = "Carrello";
            Carrello.Size = new Size(466, 654);
            Carrello.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(205, 617);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(155, 91);
            button3.TabIndex = 6;
            button3.Text = "RIMUOVI TUTTO";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_11_22_083158;
            pictureBox1.Location = new Point(67, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 583);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1002);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(Carrello);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox Carrello;
        private Button button3;
        private PictureBox pictureBox1;
    }
}
