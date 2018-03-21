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
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(66, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbLoadPath
            // 
            this.tbLoadPath.Location = new System.Drawing.Point(84, 14);
            this.tbLoadPath.Name = "tbLoadPath";
            this.tbLoadPath.ReadOnly = true;
            this.tbLoadPath.Size = new System.Drawing.Size(236, 20);
            this.tbLoadPath.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(84, 43);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.ReadOnly = true;
            this.tbSavePath.Size = new System.Drawing.Size(236, 20);
            this.tbSavePath.TabIndex = 3;
            // 
            // rtbArrayText
            // 
            this.rtbArrayText.Location = new System.Drawing.Point(12, 70);
            this.rtbArrayText.Name = "rtbArrayText";
            this.rtbArrayText.Size = new System.Drawing.Size(308, 180);
            this.rtbArrayText.TabIndex = 4;
            this.rtbArrayText.Text = "";
            // 
            // BinToArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 262);
            this.Controls.Add(this.rtbArrayText);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbLoadPath);
            this.Controls.Add(this.btnLoad);
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
    }
}

