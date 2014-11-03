namespace TUC_Publisher
{
    partial class Form_Edit_Tags
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lb_Tag = new System.Windows.Forms.Label();
            this.txt_Tag = new System.Windows.Forms.TextBox();
            this.lb_Value = new System.Windows.Forms.Label();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(13, 13);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(53, 12);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "顯示名稱";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(15, 29);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(358, 22);
            this.txt_Name.TabIndex = 1;
            // 
            // lb_Tag
            // 
            this.lb_Tag.AutoSize = true;
            this.lb_Tag.Location = new System.Drawing.Point(13, 63);
            this.lb_Tag.Name = "lb_Tag";
            this.lb_Tag.Size = new System.Drawing.Size(29, 12);
            this.lb_Tag.TabIndex = 0;
            this.lb_Tag.Text = "標籤";
            // 
            // txt_Tag
            // 
            this.txt_Tag.Location = new System.Drawing.Point(15, 79);
            this.txt_Tag.Name = "txt_Tag";
            this.txt_Tag.Size = new System.Drawing.Size(358, 22);
            this.txt_Tag.TabIndex = 2;
            // 
            // lb_Value
            // 
            this.lb_Value.AutoSize = true;
            this.lb_Value.Location = new System.Drawing.Point(13, 114);
            this.lb_Value.Name = "lb_Value";
            this.lb_Value.Size = new System.Drawing.Size(41, 12);
            this.lb_Value.TabIndex = 0;
            this.lb_Value.Text = "填入值";
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(15, 130);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(358, 22);
            this.txt_Value.TabIndex = 3;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(298, 169);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "確定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // Form_Edit_Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 205);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Value);
            this.Controls.Add(this.lb_Value);
            this.Controls.Add(this.txt_Tag);
            this.Controls.Add(this.lb_Tag);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lb_Name);
            this.Name = "Form_Edit_Tags";
            this.Text = "新增替換標籤";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lb_Tag;
        private System.Windows.Forms.TextBox txt_Tag;
        private System.Windows.Forms.Label lb_Value;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Button btn_OK;
    }
}