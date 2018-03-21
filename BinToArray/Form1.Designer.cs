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
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(16, 14);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 27);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbLoadPath
            // 
            this.tbLoadPath.Location = new System.Drawing.Point(112, 16);
            this.tbLoadPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbLoadPath.Name = "tbLoadPath";
            this.tbLoadPath.ReadOnly = true;
            this.tbLoadPath.Size = new System.Drawing.Size(313, 25);
            this.tbLoadPath.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 47);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(112, 50);
            this.tbSavePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.ReadOnly = true;
            this.tbSavePath.Size = new System.Drawing.Size(313, 25);
            this.tbSavePath.TabIndex = 3;
            // 
            // rtbArrayText
            // 
            this.rtbArrayText.Location = new System.Drawing.Point(16, 81);
            this.rtbArrayText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbArrayText.Name = "rtbArrayText";
            this.rtbArrayText.Size = new System.Drawing.Size(409, 207);
            this.rtbArrayText.TabIndex = 4;
            this.rtbArrayText.Text = "";
            // 
            // progressLoad
            // 
            this.progressLoad.Location = new System.Drawing.Point(112, 16);
            this.progressLoad.Name = "progressLoad";
            this.progressLoad.Size = new System.Drawing.Size(313, 25);
            this.progressLoad.TabIndex = 5;
            this.progressLoad.Visible = false;
            // 
            // BinToArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 302);
            this.Controls.Add(this.progressLoad);
            this.Controls.Add(this.rtbArrayText);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbLoadPath);
            this.Controls.Add(this.btnLoad);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BinToArray";
            this.Text = "Bin To Array";
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
    }
}

