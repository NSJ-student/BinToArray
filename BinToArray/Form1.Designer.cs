namespace BinToArray
{
    partial class BinToArray
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbLoadPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.rtbArrayText = new System.Windows.Forms.RichTextBox();
            this.progressLoad = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbDec32bit = new System.Windows.Forms.RadioButton();
            this.rbDec16bit = new System.Windows.Forms.RadioButton();
            this.rbDec8bit = new System.Windows.Forms.RadioButton();
            this.rbHex32bit = new System.Windows.Forms.RadioButton();
            this.rbHex16bit = new System.Windows.Forms.RadioButton();
            this.rbHex8bit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numColCount = new System.Windows.Forms.NumericUpDown();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(16, 25);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 28);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbLoadPath
            // 
            this.tbLoadPath.Location = new System.Drawing.Point(112, 28);
            this.tbLoadPath.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tbLoadPath.Name = "tbLoadPath";
            this.tbLoadPath.ReadOnly = true;
            this.tbLoadPath.Size = new System.Drawing.Size(165, 25);
            this.tbLoadPath.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 64);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(112, 66);
            this.tbSavePath.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.ReadOnly = true;
            this.tbSavePath.Size = new System.Drawing.Size(165, 25);
            this.tbSavePath.TabIndex = 3;
            // 
            // rtbArrayText
            // 
            this.rtbArrayText.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbArrayText.Location = new System.Drawing.Point(16, 126);
            this.rtbArrayText.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.rtbArrayText.Name = "rtbArrayText";
            this.rtbArrayText.Size = new System.Drawing.Size(604, 223);
            this.rtbArrayText.TabIndex = 4;
            this.rtbArrayText.Text = "";
            this.rtbArrayText.WordWrap = false;
            // 
            // progressLoad
            // 
            this.progressLoad.Location = new System.Drawing.Point(112, 28);
            this.progressLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressLoad.Name = "progressLoad";
            this.progressLoad.Size = new System.Drawing.Size(166, 25);
            this.progressLoad.TabIndex = 5;
            this.progressLoad.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(294, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(327, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.rbDec32bit, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbDec16bit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbDec8bit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbHex32bit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbHex16bit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbHex8bit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numColCount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReload, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 88);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // rbDec32bit
            // 
            this.rbDec32bit.AutoSize = true;
            this.rbDec32bit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDec32bit.Location = new System.Drawing.Point(236, 33);
            this.rbDec32bit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDec32bit.Name = "rbDec32bit";
            this.rbDec32bit.Size = new System.Drawing.Size(82, 21);
            this.rbDec32bit.TabIndex = 2;
            this.rbDec32bit.Text = "32-bit";
            this.rbDec32bit.UseVisualStyleBackColor = true;
            // 
            // rbDec16bit
            // 
            this.rbDec16bit.AutoSize = true;
            this.rbDec16bit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDec16bit.Location = new System.Drawing.Point(148, 33);
            this.rbDec16bit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDec16bit.Name = "rbDec16bit";
            this.rbDec16bit.Size = new System.Drawing.Size(82, 21);
            this.rbDec16bit.TabIndex = 2;
            this.rbDec16bit.Text = "16-bit";
            this.rbDec16bit.UseVisualStyleBackColor = true;
            // 
            // rbDec8bit
            // 
            this.rbDec8bit.AutoSize = true;
            this.rbDec8bit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDec8bit.Location = new System.Drawing.Point(60, 33);
            this.rbDec8bit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDec8bit.Name = "rbDec8bit";
            this.rbDec8bit.Size = new System.Drawing.Size(82, 21);
            this.rbDec8bit.TabIndex = 2;
            this.rbDec8bit.Text = "8-bit";
            this.rbDec8bit.UseVisualStyleBackColor = true;
            // 
            // rbHex32bit
            // 
            this.rbHex32bit.AutoSize = true;
            this.rbHex32bit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbHex32bit.Location = new System.Drawing.Point(236, 4);
            this.rbHex32bit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHex32bit.Name = "rbHex32bit";
            this.rbHex32bit.Size = new System.Drawing.Size(82, 21);
            this.rbHex32bit.TabIndex = 2;
            this.rbHex32bit.Text = "32-bit";
            this.rbHex32bit.UseVisualStyleBackColor = true;
            // 
            // rbHex16bit
            // 
            this.rbHex16bit.AutoSize = true;
            this.rbHex16bit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbHex16bit.Location = new System.Drawing.Point(148, 4);
            this.rbHex16bit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHex16bit.Name = "rbHex16bit";
            this.rbHex16bit.Size = new System.Drawing.Size(82, 21);
            this.rbHex16bit.TabIndex = 1;
            this.rbHex16bit.Text = "16-bit";
            this.rbHex16bit.UseVisualStyleBackColor = true;
            // 
            // rbHex8bit
            // 
            this.rbHex8bit.AutoSize = true;
            this.rbHex8bit.Checked = true;
            this.rbHex8bit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbHex8bit.Location = new System.Drawing.Point(60, 4);
            this.rbHex8bit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHex8bit.Name = "rbHex8bit";
            this.rbHex8bit.Size = new System.Drawing.Size(82, 21);
            this.rbHex8bit.TabIndex = 0;
            this.rbHex8bit.TabStop = true;
            this.rbHex8bit.Text = "8-bit";
            this.rbHex8bit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "HEX :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "DEC :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numColCount
            // 
            this.numColCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numColCount.Location = new System.Drawing.Point(60, 62);
            this.numColCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numColCount.Name = "numColCount";
            this.numColCount.Size = new System.Drawing.Size(82, 25);
            this.numColCount.TabIndex = 6;
            this.numColCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numColCount.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(236, 62);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 22);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // BinToArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressLoad);
            this.Controls.Add(this.rtbArrayText);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbLoadPath);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BinToArray";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bin To Array";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbLoadPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.RichTextBox rtbArrayText;
        private System.Windows.Forms.ProgressBar progressLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHex8bit;
        private System.Windows.Forms.RadioButton rbHex16bit;
        private System.Windows.Forms.RadioButton rbHex32bit;
        private System.Windows.Forms.RadioButton rbDec8bit;
        private System.Windows.Forms.RadioButton rbDec16bit;
        private System.Windows.Forms.RadioButton rbDec32bit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numColCount;
        private System.Windows.Forms.Button btnReload;
    }
}

