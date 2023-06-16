namespace Challange_01
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
            this.txt_colorChange = new System.Windows.Forms.TextBox();
            this.lbl_red = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_gre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_colorChange
            // 
            this.txt_colorChange.Location = new System.Drawing.Point(285, 161);
            this.txt_colorChange.Multiline = true;
            this.txt_colorChange.Name = "txt_colorChange";
            this.txt_colorChange.ReadOnly = true;
            this.txt_colorChange.Size = new System.Drawing.Size(243, 46);
            this.txt_colorChange.TabIndex = 0;
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_red.Location = new System.Drawing.Point(215, 253);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(54, 25);
            this.lbl_red.TabIndex = 3;
            this.lbl_red.Text = "Red";
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(195, 341);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(139, 47);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.Location = new System.Drawing.Point(520, 341);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(139, 47);
            this.btn_previous.TabIndex = 7;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_green.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_green.Location = new System.Drawing.Point(551, 253);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(59, 25);
            this.lbl_green.TabIndex = 5;
            this.lbl_green.Text = "Blue";
            // 
            // lbl_gre
            // 
            this.lbl_gre.AutoSize = true;
            this.lbl_gre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_gre.Location = new System.Drawing.Point(387, 253);
            this.lbl_gre.Name = "lbl_gre";
            this.lbl_gre.Size = new System.Drawing.Size(76, 25);
            this.lbl_gre.TabIndex = 4;
            this.lbl_gre.Text = "Green";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_green);
            this.Controls.Add(this.lbl_gre);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.txt_colorChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_colorChange;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_gre;
    }
}

