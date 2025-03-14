namespace bai14_sochinhphuong_winform
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSo = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.lblKq = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lsbKq = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIỂM TRA SỐ CHÍNH PHƯƠNG";
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.Location = new System.Drawing.Point(37, 56);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(32, 20);
            this.lblSo.TabIndex = 1;
            this.lblSo.Text = "SỐ";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(85, 50);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(121, 26);
            this.txtSo.TabIndex = 2;
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Location = new System.Drawing.Point(18, 88);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(78, 20);
            this.lblKq.TabIndex = 3;
            this.lblKq.Text = "KẾT QUẢ";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(85, 123);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(129, 36);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "TÍNH";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lsbKq
            // 
            this.lsbKq.FormattingEnabled = true;
            this.lsbKq.ItemHeight = 20;
            this.lsbKq.Location = new System.Drawing.Point(351, 65);
            this.lsbKq.Name = "lsbKq";
            this.lsbKq.Size = new System.Drawing.Size(231, 284);
            this.lsbKq.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 421);
            this.Controls.Add(this.lsbKq);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblSo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label lblKq;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.ListBox lsbKq;
    }
}

