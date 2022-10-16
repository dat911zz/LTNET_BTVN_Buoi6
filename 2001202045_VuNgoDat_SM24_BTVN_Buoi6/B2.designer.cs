
namespace _2001202045_VuNgoDat_SM24_Buoi6
{
    partial class B2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnPickOdds = new System.Windows.Forms.Button();
            this.btnPickEvens = new System.Windows.Forms.Button();
            this.btnPowSelf = new System.Windows.Forms.Button();
            this.btnIncreaseAll2Unit = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnDeleteHeadNTail = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listbox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xử lý listbox";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lbOutput);
            this.panel2.Controls.Add(this.txtInput);
            this.panel2.Location = new System.Drawing.Point(25, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 411);
            this.panel2.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Nhập";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 20;
            this.lbOutput.Location = new System.Drawing.Point(24, 82);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbOutput.Size = new System.Drawing.Size(241, 324);
            this.lbOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(24, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(241, 28);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblSum);
            this.panel3.Controls.Add(this.btnPickOdds);
            this.panel3.Controls.Add(this.btnPickEvens);
            this.panel3.Controls.Add(this.btnPowSelf);
            this.panel3.Controls.Add(this.btnIncreaseAll2Unit);
            this.panel3.Controls.Add(this.btnDeleteSelected);
            this.panel3.Controls.Add(this.btnDeleteHeadNTail);
            this.panel3.Controls.Add(this.btnSum);
            this.panel3.Location = new System.Drawing.Point(332, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 411);
            this.panel3.TabIndex = 4;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(40, 371);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(19, 21);
            this.lblSum.TabIndex = 7;
            this.lblSum.Text = "0";
            // 
            // btnPickOdds
            // 
            this.btnPickOdds.Location = new System.Drawing.Point(44, 307);
            this.btnPickOdds.Name = "btnPickOdds";
            this.btnPickOdds.Size = new System.Drawing.Size(566, 44);
            this.btnPickOdds.TabIndex = 6;
            this.btnPickOdds.Text = "Chọn số lẻ";
            this.btnPickOdds.UseVisualStyleBackColor = true;
            this.btnPickOdds.Click += new System.EventHandler(this.btnPickOdds_Click);
            // 
            // btnPickEvens
            // 
            this.btnPickEvens.Location = new System.Drawing.Point(44, 262);
            this.btnPickEvens.Name = "btnPickEvens";
            this.btnPickEvens.Size = new System.Drawing.Size(566, 44);
            this.btnPickEvens.TabIndex = 5;
            this.btnPickEvens.Text = "Chọn số chẵn";
            this.btnPickEvens.UseVisualStyleBackColor = true;
            this.btnPickEvens.Click += new System.EventHandler(this.btnPickEvens_Click);
            // 
            // btnPowSelf
            // 
            this.btnPowSelf.Location = new System.Drawing.Point(44, 217);
            this.btnPowSelf.Name = "btnPowSelf";
            this.btnPowSelf.Size = new System.Drawing.Size(566, 44);
            this.btnPowSelf.TabIndex = 4;
            this.btnPowSelf.Text = "Thay bằng bình phương";
            this.btnPowSelf.UseVisualStyleBackColor = true;
            this.btnPowSelf.Click += new System.EventHandler(this.btnPowSelf_Click);
            // 
            // btnIncreaseAll2Unit
            // 
            this.btnIncreaseAll2Unit.Location = new System.Drawing.Point(44, 172);
            this.btnIncreaseAll2Unit.Name = "btnIncreaseAll2Unit";
            this.btnIncreaseAll2Unit.Size = new System.Drawing.Size(566, 44);
            this.btnIncreaseAll2Unit.TabIndex = 3;
            this.btnIncreaseAll2Unit.Text = "Tăng mỗi phần tử lên 2";
            this.btnIncreaseAll2Unit.UseVisualStyleBackColor = true;
            this.btnIncreaseAll2Unit.Click += new System.EventHandler(this.btnIncreaseAll2Unit_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(44, 127);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(566, 44);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Xóa phần tử đang chọn";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnDeleteHeadNTail
            // 
            this.btnDeleteHeadNTail.Location = new System.Drawing.Point(44, 82);
            this.btnDeleteHeadNTail.Name = "btnDeleteHeadNTail";
            this.btnDeleteHeadNTail.Size = new System.Drawing.Size(566, 44);
            this.btnDeleteHeadNTail.TabIndex = 1;
            this.btnDeleteHeadNTail.Text = "Xóa phần tử đầu và cuối";
            this.btnDeleteHeadNTail.UseVisualStyleBackColor = true;
            this.btnDeleteHeadNTail.Click += new System.EventHandler(this.btnDeleteHeadNTail_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(44, 37);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(566, 44);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Tổng các phần tử trong list";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(26, 549);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(954, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&KẾT THÚC";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // B2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "B2";
            this.Text = "B2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPickOdds;
        private System.Windows.Forms.Button btnPickEvens;
        private System.Windows.Forms.Button btnPowSelf;
        private System.Windows.Forms.Button btnIncreaseAll2Unit;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnDeleteHeadNTail;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}