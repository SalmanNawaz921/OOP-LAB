namespace Task_5
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
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name1 = new System.Windows.Forms.TextBox();
            this.txt_name2 = new System.Windows.Forms.TextBox();
            this.btn_compare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name1
            // 
            this.lbl_name1.AutoSize = true;
            this.lbl_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name1.Location = new System.Drawing.Point(165, 96);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(180, 25);
            this.lbl_name1.TabIndex = 0;
            this.lbl_name1.Text = "ENTER NAME 1";
            this.lbl_name1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER NAME 2";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_name1
            // 
            this.txt_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name1.Location = new System.Drawing.Point(377, 96);
            this.txt_name1.Multiline = true;
            this.txt_name1.Name = "txt_name1";
            this.txt_name1.Size = new System.Drawing.Size(217, 31);
            this.txt_name1.TabIndex = 2;
            // 
            // txt_name2
            // 
            this.txt_name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name2.Location = new System.Drawing.Point(377, 145);
            this.txt_name2.Multiline = true;
            this.txt_name2.Name = "txt_name2";
            this.txt_name2.Size = new System.Drawing.Size(217, 31);
            this.txt_name2.TabIndex = 3;
            // 
            // btn_compare
            // 
            this.btn_compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compare.Location = new System.Drawing.Point(352, 216);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(122, 58);
            this.btn_compare.TabIndex = 4;
            this.btn_compare.Text = "Compare";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_compare);
            this.Controls.Add(this.txt_name2);
            this.Controls.Add(this.txt_name1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name1;
        private System.Windows.Forms.TextBox txt_name2;
        private System.Windows.Forms.Button btn_compare;
    }
}

