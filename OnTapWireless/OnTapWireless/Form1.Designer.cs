
namespace OnTapQTMang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.btnChoice4 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnRemoveNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChoice1
            // 
            this.btnChoice1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice1.Location = new System.Drawing.Point(51, 52);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(559, 100);
            this.btnChoice1.TabIndex = 0;
            this.btnChoice1.UseVisualStyleBackColor = true;
            this.btnChoice1.Click += new System.EventHandler(this.btnChoice1_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice2.Location = new System.Drawing.Point(51, 176);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(559, 100);
            this.btnChoice2.TabIndex = 1;
            this.btnChoice2.UseVisualStyleBackColor = true;
            this.btnChoice2.Click += new System.EventHandler(this.btnChoice2_Click);
            // 
            // btnChoice3
            // 
            this.btnChoice3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice3.Location = new System.Drawing.Point(51, 303);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(559, 105);
            this.btnChoice3.TabIndex = 2;
            this.btnChoice3.UseVisualStyleBackColor = true;
            this.btnChoice3.Click += new System.EventHandler(this.btnChoice3_Click);
            // 
            // btnChoice4
            // 
            this.btnChoice4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice4.Location = new System.Drawing.Point(51, 436);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.Size = new System.Drawing.Size(559, 105);
            this.btnChoice4.TabIndex = 3;
            this.btnChoice4.UseVisualStyleBackColor = true;
            this.btnChoice4.Click += new System.EventHandler(this.btnChoice4_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AllowDrop = true;
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(697, 52);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(540, 489);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "dadsasd";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnRemoveNumbers
            // 
            this.btnRemoveNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumbers.Location = new System.Drawing.Point(964, 544);
            this.btnRemoveNumbers.Name = "btnRemoveNumbers";
            this.btnRemoveNumbers.Size = new System.Drawing.Size(273, 46);
            this.btnRemoveNumbers.TabIndex = 5;
            this.btnRemoveNumbers.Text = "Tắt số thứ tự câu";
            this.btnRemoveNumbers.UseVisualStyleBackColor = true;
            this.btnRemoveNumbers.Click += new System.EventHandler(this.btnRemoveNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 613);
            this.Controls.Add(this.btnRemoveNumbers);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnChoice4);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ôn Tập Quản Trị Mạng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Button btnChoice3;
        private System.Windows.Forms.Button btnChoice4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnRemoveNumbers;
    }
}

