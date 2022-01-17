
namespace db_project
{
    partial class mainmenu
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
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
			this.label1.ForeColor = System.Drawing.Color.SandyBrown;
			this.label1.Location = new System.Drawing.Point(173, 130);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(330, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "ROOM RESERVATION";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
			this.label2.ForeColor = System.Drawing.Color.SandyBrown;
			this.label2.Location = new System.Drawing.Point(173, 192);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "ORDER FOOD";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(977, 504);
			this.panel1.TabIndex = 2;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.ForeColor = System.Drawing.Color.Goldenrod;
			this.button3.Location = new System.Drawing.Point(558, 250);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(264, 34);
			this.button3.TabIndex = 6;
			this.button3.Text = "GO";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
			this.label3.ForeColor = System.Drawing.Color.SandyBrown;
			this.label3.Location = new System.Drawing.Point(173, 260);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(188, 36);
			this.label3.TabIndex = 5;
			this.label3.Text = "CHECK OUT";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Black;
			this.button2.ForeColor = System.Drawing.Color.Goldenrod;
			this.button2.Location = new System.Drawing.Point(558, 192);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(264, 34);
			this.button2.TabIndex = 4;
			this.button2.Text = "ORDER";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.ForeColor = System.Drawing.Color.Goldenrod;
			this.button1.Location = new System.Drawing.Point(558, 133);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(264, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "BOOK";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// mainmenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::db_project.Properties.Resources.hp_banner_1_1024x576;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(977, 504);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "mainmenu";
			this.Text = "mainmenu";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}