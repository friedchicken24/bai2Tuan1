namespace bai2Tuan1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtHoTen = new TextBox();
            txtKQ = new TextBox();
            rad1 = new RadioButton();
            rad2 = new RadioButton();
            btnKQ = new Button();
            btnXoa = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập họ và tên:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad1);
            groupBox1.Location = new Point(70, 175);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(785, 196);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn kiểu chữ";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(274, 66);
            txtHoTen.Margin = new Padding(4, 3, 4, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(770, 30);
            txtHoTen.TabIndex = 4;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(274, 404);
            txtKQ.Margin = new Padding(4, 3, 4, 3);
            txtKQ.Name = "txtKQ";
            txtKQ.ReadOnly = true;
            txtKQ.Size = new Size(770, 30);
            txtKQ.TabIndex = 5;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Checked = true;
            rad1.Location = new Point(0, 53);
            rad1.Margin = new Padding(4, 3, 4, 3);
            rad1.Name = "rad1";
            rad1.Size = new Size(119, 26);
            rad1.TabIndex = 6;
            rad1.TabStop = true;
            rad1.Text = "chữ thường";
            rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(70, 296);
            rad2.Margin = new Padding(4, 3, 4, 3);
            rad2.Name = "rad2";
            rad2.Size = new Size(146, 26);
            rad2.TabIndex = 7;
            rad2.TabStop = true;
            rad2.Text = "CHỮ IN HOA";
            rad2.UseVisualStyleBackColor = true;
            // 
            // btnKQ
            // 
            btnKQ.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKQ.Location = new Point(70, 402);
            btnKQ.Margin = new Padding(4, 3, 4, 3);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(173, 37);
            btnKQ.TabIndex = 8;
            btnKQ.Text = "KẾT QUẢ";
            btnKQ.UseVisualStyleBackColor = true;
            btnKQ.Click += btnKQ_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(899, 175);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(146, 196);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 495);
            Controls.Add(btnXoa);
            Controls.Add(rad2);
            Controls.Add(btnKQ);
            Controls.Add(txtKQ);
            Controls.Add(txtHoTen);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Đổi kiểu chữ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtHoTen;
        private TextBox txtKQ;
        private RadioButton rad1;
        private RadioButton rad2;
        private Button btnKQ;
        private Button btnXoa;
    }
}
