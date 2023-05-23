namespace DoAnLTDT
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
            this.lbl_Nhap = new System.Windows.Forms.Label();
            this.txt_MaTran = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_VeDT = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Prim = new System.Windows.Forms.Button();
            this.btn_Dijkstra = new System.Windows.Forms.Button();
            this.txt_ThuatToan = new System.Windows.Forms.TextBox();
            this.txt_Prim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Dijkstra2 = new System.Windows.Forms.TextBox();
            this.txt_Dijkstra1 = new System.Windows.Forms.TextBox();
            this.btn_DocFile = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Nhap
            // 
            this.lbl_Nhap.AutoSize = true;
            this.lbl_Nhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Nhap.Location = new System.Drawing.Point(1126, 12);
            this.lbl_Nhap.Name = "lbl_Nhap";
            this.lbl_Nhap.Size = new System.Drawing.Size(111, 21);
            this.lbl_Nhap.TabIndex = 0;
            this.lbl_Nhap.Text = "Nhập ma trận";
            // 
            // txt_MaTran
            // 
            this.txt_MaTran.Location = new System.Drawing.Point(1126, 36);
            this.txt_MaTran.Multiline = true;
            this.txt_MaTran.Name = "txt_MaTran";
            this.txt_MaTran.Size = new System.Drawing.Size(373, 272);
            this.txt_MaTran.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 746);
            this.panel1.TabIndex = 2;
            // 
            // btn_VeDT
            // 
            this.btn_VeDT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_VeDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VeDT.Location = new System.Drawing.Point(1265, 314);
            this.btn_VeDT.Name = "btn_VeDT";
            this.btn_VeDT.Size = new System.Drawing.Size(234, 36);
            this.btn_VeDT.TabIndex = 3;
            this.btn_VeDT.Text = "Vẽ đồ thị";
            this.btn_VeDT.UseVisualStyleBackColor = false;
            this.btn_VeDT.Click += new System.EventHandler(this.btn_VeDT_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Location = new System.Drawing.Point(1170, 709);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(270, 36);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa đồ thị";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Prim
            // 
            this.btn_Prim.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Prim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prim.Location = new System.Drawing.Point(1126, 365);
            this.btn_Prim.Name = "btn_Prim";
            this.btn_Prim.Size = new System.Drawing.Size(129, 36);
            this.btn_Prim.TabIndex = 6;
            this.btn_Prim.Text = "Prim";
            this.btn_Prim.UseVisualStyleBackColor = false;
            this.btn_Prim.Click += new System.EventHandler(this.btn_Prim_Click);
            // 
            // btn_Dijkstra
            // 
            this.btn_Dijkstra.BackColor = System.Drawing.Color.Olive;
            this.btn_Dijkstra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dijkstra.Location = new System.Drawing.Point(1130, 434);
            this.btn_Dijkstra.Name = "btn_Dijkstra";
            this.btn_Dijkstra.Size = new System.Drawing.Size(129, 36);
            this.btn_Dijkstra.TabIndex = 7;
            this.btn_Dijkstra.Text = "Dijkstra";
            this.btn_Dijkstra.UseVisualStyleBackColor = false;
            this.btn_Dijkstra.Click += new System.EventHandler(this.btn_Dijkstra_Click);
            // 
            // txt_ThuatToan
            // 
            this.txt_ThuatToan.Location = new System.Drawing.Point(1126, 521);
            this.txt_ThuatToan.Multiline = true;
            this.txt_ThuatToan.Name = "txt_ThuatToan";
            this.txt_ThuatToan.Size = new System.Drawing.Size(373, 169);
            this.txt_ThuatToan.TabIndex = 8;
            // 
            // txt_Prim
            // 
            this.txt_Prim.Location = new System.Drawing.Point(1373, 370);
            this.txt_Prim.Name = "txt_Prim";
            this.txt_Prim.Size = new System.Drawing.Size(126, 28);
            this.txt_Prim.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1261, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đỉnh bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1265, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đỉnh bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1265, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đỉnh kết thúc";
            // 
            // txt_Dijkstra2
            // 
            this.txt_Dijkstra2.Location = new System.Drawing.Point(1377, 459);
            this.txt_Dijkstra2.Name = "txt_Dijkstra2";
            this.txt_Dijkstra2.Size = new System.Drawing.Size(126, 28);
            this.txt_Dijkstra2.TabIndex = 13;
            // 
            // txt_Dijkstra1
            // 
            this.txt_Dijkstra1.Location = new System.Drawing.Point(1377, 428);
            this.txt_Dijkstra1.Name = "txt_Dijkstra1";
            this.txt_Dijkstra1.Size = new System.Drawing.Size(126, 28);
            this.txt_Dijkstra1.TabIndex = 14;
            // 
            // btn_DocFile
            // 
            this.btn_DocFile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_DocFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DocFile.Location = new System.Drawing.Point(1126, 314);
            this.btn_DocFile.Name = "btn_DocFile";
            this.btn_DocFile.Size = new System.Drawing.Size(129, 36);
            this.btn_DocFile.TabIndex = 15;
            this.btn_DocFile.Text = "Đọc File";
            this.btn_DocFile.UseVisualStyleBackColor = false;
            this.btn_DocFile.Click += new System.EventHandler(this.btn_DocFile_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Title.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Title.Location = new System.Drawing.Point(232, -3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(593, 56);
            this.lbl_Title.TabIndex = 16;
            this.lbl_Title.Text = "LTDT_Nhóm05";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(1126, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1587, 810);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Nhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_MaTran);
            this.Controls.Add(this.btn_DocFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_VeDT);
            this.Controls.Add(this.txt_Prim);
            this.Controls.Add(this.btn_Prim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Dijkstra1);
            this.Controls.Add(this.txt_ThuatToan);
            this.Controls.Add(this.btn_Dijkstra);
            this.Controls.Add(this.txt_Dijkstra2);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nhap;
        private System.Windows.Forms.TextBox txt_MaTran;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_VeDT;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Prim;
        private System.Windows.Forms.Button btn_Dijkstra;
        private System.Windows.Forms.TextBox txt_ThuatToan;
        private System.Windows.Forms.TextBox txt_Prim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Dijkstra2;
        private System.Windows.Forms.TextBox txt_Dijkstra1;
        private System.Windows.Forms.Button btn_DocFile;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label4;
    }
}

