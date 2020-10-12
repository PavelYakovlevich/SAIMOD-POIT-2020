namespace lab3_4
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
            this.txtBoxP = new System.Windows.Forms.TextBox();
            this.txtBoxPI1 = new System.Windows.Forms.TextBox();
            this.txtBoxPI2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxTiksCount = new System.Windows.Forms.TextBox();
            this.txtBoxDenyvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAvgQueueLen = new System.Windows.Forms.TextBox();
            this.txtBoxAverageReqCountInQueue = new System.Windows.Forms.TextBox();
            this.txtBoxQ = new System.Windows.Forms.TextBox();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.txtBoxAvgReqTimeInQueue = new System.Windows.Forms.TextBox();
            this.txtBoxAvgReqTimeInSystem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxLoadCoef1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxLoadCoef2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxP
            // 
            this.txtBoxP.Location = new System.Drawing.Point(10, 21);
            this.txtBoxP.Name = "txtBoxP";
            this.txtBoxP.Size = new System.Drawing.Size(100, 20);
            this.txtBoxP.TabIndex = 0;
            this.txtBoxP.Text = "0.75";
            // 
            // txtBoxPI1
            // 
            this.txtBoxPI1.Location = new System.Drawing.Point(10, 58);
            this.txtBoxPI1.Name = "txtBoxPI1";
            this.txtBoxPI1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPI1.TabIndex = 1;
            this.txtBoxPI1.Text = "0.7";
            // 
            // txtBoxPI2
            // 
            this.txtBoxPI2.Location = new System.Drawing.Point(10, 97);
            this.txtBoxPI2.Name = "txtBoxPI2";
            this.txtBoxPI2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPI2.TabIndex = 2;
            this.txtBoxPI2.Text = "0.65";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 162);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxTiksCount
            // 
            this.txtBoxTiksCount.Location = new System.Drawing.Point(12, 154);
            this.txtBoxTiksCount.Name = "txtBoxTiksCount";
            this.txtBoxTiksCount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTiksCount.TabIndex = 7;
            this.txtBoxTiksCount.Text = "1000";
            // 
            // txtBoxDenyvalue
            // 
            this.txtBoxDenyvalue.Location = new System.Drawing.Point(12, 227);
            this.txtBoxDenyvalue.Name = "txtBoxDenyvalue";
            this.txtBoxDenyvalue.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDenyvalue.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Po";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество тиков";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lоч";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lc";
            // 
            // txtBoxAvgQueueLen
            // 
            this.txtBoxAvgQueueLen.Location = new System.Drawing.Point(12, 278);
            this.txtBoxAvgQueueLen.Name = "txtBoxAvgQueueLen";
            this.txtBoxAvgQueueLen.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAvgQueueLen.TabIndex = 13;
            // 
            // txtBoxAverageReqCountInQueue
            // 
            this.txtBoxAverageReqCountInQueue.Location = new System.Drawing.Point(12, 328);
            this.txtBoxAverageReqCountInQueue.Name = "txtBoxAverageReqCountInQueue";
            this.txtBoxAverageReqCountInQueue.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAverageReqCountInQueue.TabIndex = 14;
            // 
            // txtBoxQ
            // 
            this.txtBoxQ.Location = new System.Drawing.Point(143, 227);
            this.txtBoxQ.Name = "txtBoxQ";
            this.txtBoxQ.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQ.TabIndex = 15;
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(143, 278);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(100, 20);
            this.txtBoxA.TabIndex = 16;
            // 
            // txtBoxAvgReqTimeInQueue
            // 
            this.txtBoxAvgReqTimeInQueue.Location = new System.Drawing.Point(273, 227);
            this.txtBoxAvgReqTimeInQueue.Name = "txtBoxAvgReqTimeInQueue";
            this.txtBoxAvgReqTimeInQueue.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAvgReqTimeInQueue.TabIndex = 17;
            // 
            // txtBoxAvgReqTimeInSystem
            // 
            this.txtBoxAvgReqTimeInSystem.Location = new System.Drawing.Point(273, 278);
            this.txtBoxAvgReqTimeInSystem.Name = "txtBoxAvgReqTimeInSystem";
            this.txtBoxAvgReqTimeInSystem.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAvgReqTimeInSystem.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Wоч";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Wc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Kкан";
            // 
            // txtBoxLoadCoef1
            // 
            this.txtBoxLoadCoef1.Location = new System.Drawing.Point(189, 351);
            this.txtBoxLoadCoef1.Name = "txtBoxLoadCoef1";
            this.txtBoxLoadCoef1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLoadCoef1.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "P";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "PI1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "PI2";
            // 
            // txtBoxLoadCoef2
            // 
            this.txtBoxLoadCoef2.Location = new System.Drawing.Point(309, 351);
            this.txtBoxLoadCoef2.Name = "txtBoxLoadCoef2";
            this.txtBoxLoadCoef2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLoadCoef2.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P,
            this.Value});
            this.dataGridView1.Location = new System.Drawing.Point(427, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(146, 369);
            this.dataGridView1.TabIndex = 29;
            // 
            // P
            // 
            this.P.HeaderText = "P";
            this.P.Name = "P";
            this.P.Width = 50;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 393);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxLoadCoef2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxLoadCoef1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxAvgReqTimeInSystem);
            this.Controls.Add(this.txtBoxAvgReqTimeInQueue);
            this.Controls.Add(this.txtBoxA);
            this.Controls.Add(this.txtBoxQ);
            this.Controls.Add(this.txtBoxAverageReqCountInQueue);
            this.Controls.Add(this.txtBoxAvgQueueLen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDenyvalue);
            this.Controls.Add(this.txtBoxTiksCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxPI2);
            this.Controls.Add(this.txtBoxPI1);
            this.Controls.Add(this.txtBoxP);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxP;
        private System.Windows.Forms.TextBox txtBoxPI1;
        private System.Windows.Forms.TextBox txtBoxPI2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxTiksCount;
        private System.Windows.Forms.TextBox txtBoxDenyvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxAvgQueueLen;
        private System.Windows.Forms.TextBox txtBoxAverageReqCountInQueue;
        private System.Windows.Forms.TextBox txtBoxQ;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.TextBox txtBoxAvgReqTimeInQueue;
        private System.Windows.Forms.TextBox txtBoxAvgReqTimeInSystem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxLoadCoef1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxLoadCoef2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

