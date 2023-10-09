namespace CalculatorWFA
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBERABER = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.calcTXTBOX = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnUSTEGELME = new System.Windows.Forms.Button();
            this.btnCIXMA = new System.Windows.Forms.Button();
            this.btnVURMA = new System.Windows.Forms.Button();
            this.btnBOLME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBERABER
            // 
            this.btnBERABER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBERABER.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBERABER.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBERABER.Location = new System.Drawing.Point(164, 353);
            this.btnBERABER.Name = "btnBERABER";
            this.btnBERABER.Size = new System.Drawing.Size(70, 70);
            this.btnBERABER.TabIndex = 1;
            this.btnBERABER.Text = "=";
            this.btnBERABER.UseVisualStyleBackColor = false;
            this.btnBERABER.Click += new System.EventHandler(this.btnBERABER_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnC.Location = new System.Drawing.Point(12, 353);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(70, 70);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(88, 353);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 70);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.ButtonAll);
            // 
            // calcTXTBOX
            // 
            this.calcTXTBOX.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcTXTBOX.Location = new System.Drawing.Point(12, 56);
            this.calcTXTBOX.Name = "calcTXTBOX";
            this.calcTXTBOX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.calcTXTBOX.Size = new System.Drawing.Size(298, 63);
            this.calcTXTBOX.TabIndex = 18;
            this.calcTXTBOX.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculatorWFA.Properties.Resources.Xiaomi_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(164, 277);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 70);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.ButtonAll);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(164, 201);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 70);
            this.btn6.TabIndex = 21;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.ButtonAll);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(164, 125);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 70);
            this.btn9.TabIndex = 22;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.ButtonAll);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(88, 125);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 70);
            this.btn8.TabIndex = 23;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.ButtonAll);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(88, 277);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 70);
            this.btn2.TabIndex = 24;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.ButtonAll);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(88, 201);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 25;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.ButtonAll);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(12, 201);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 70);
            this.btn4.TabIndex = 26;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.ButtonAll);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(12, 125);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 70);
            this.btn7.TabIndex = 27;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.ButtonAll);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(12, 277);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 70);
            this.btn1.TabIndex = 28;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.ButtonAll);
            // 
            // btnUSTEGELME
            // 
            this.btnUSTEGELME.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUSTEGELME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUSTEGELME.Location = new System.Drawing.Point(240, 125);
            this.btnUSTEGELME.Name = "btnUSTEGELME";
            this.btnUSTEGELME.Size = new System.Drawing.Size(70, 70);
            this.btnUSTEGELME.TabIndex = 29;
            this.btnUSTEGELME.Text = "+";
            this.btnUSTEGELME.UseVisualStyleBackColor = true;
            this.btnUSTEGELME.Click += new System.EventHandler(this.btnUSTEGELME_Click);
            // 
            // btnCIXMA
            // 
            this.btnCIXMA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCIXMA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCIXMA.Location = new System.Drawing.Point(240, 201);
            this.btnCIXMA.Name = "btnCIXMA";
            this.btnCIXMA.Size = new System.Drawing.Size(70, 70);
            this.btnCIXMA.TabIndex = 30;
            this.btnCIXMA.Text = "-";
            this.btnCIXMA.UseVisualStyleBackColor = true;
            this.btnCIXMA.Click += new System.EventHandler(this.btnCIXMA_Click);
            // 
            // btnVURMA
            // 
            this.btnVURMA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVURMA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVURMA.Location = new System.Drawing.Point(240, 277);
            this.btnVURMA.Name = "btnVURMA";
            this.btnVURMA.Size = new System.Drawing.Size(70, 70);
            this.btnVURMA.TabIndex = 31;
            this.btnVURMA.Text = "*";
            this.btnVURMA.UseVisualStyleBackColor = true;
            this.btnVURMA.Click += new System.EventHandler(this.btnVURMA_Click);
            // 
            // btnBOLME
            // 
            this.btnBOLME.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBOLME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBOLME.Location = new System.Drawing.Point(240, 353);
            this.btnBOLME.Name = "btnBOLME";
            this.btnBOLME.Size = new System.Drawing.Size(70, 70);
            this.btnBOLME.TabIndex = 32;
            this.btnBOLME.Text = "/";
            this.btnBOLME.UseVisualStyleBackColor = true;
            this.btnBOLME.Click += new System.EventHandler(this.btnBOLME_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(322, 433);
            this.Controls.Add(this.btnBOLME);
            this.Controls.Add(this.btnVURMA);
            this.Controls.Add(this.btnCIXMA);
            this.Controls.Add(this.btnUSTEGELME);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calcTXTBOX);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnBERABER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(338, 472);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBERABER;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox calcTXTBOX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnUSTEGELME;
        private System.Windows.Forms.Button btnCIXMA;
        private System.Windows.Forms.Button btnVURMA;
        private System.Windows.Forms.Button btnBOLME;
    }
}

