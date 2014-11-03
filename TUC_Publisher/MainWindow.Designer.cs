namespace TUC_Publisher
{
    partial class Form_MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.txt_HTMLCode = new System.Windows.Forms.TextBox();
            this.lv_Tag_Value = new System.Windows.Forms.ListView();
            this.header_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header_Tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header_Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Load_Template = new System.Windows.Forms.Button();
            this.btn_DoReplace = new System.Windows.Forms.Button();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.btn_OpenWebsite = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Delete_Tag = new System.Windows.Forms.Button();
            this.btn_Edit_Tag = new System.Windows.Forms.Button();
            this.btn_AddTag = new System.Windows.Forms.Button();
            this.menu_Copy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuitem_CopyHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Sites = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OFD_Template = new System.Windows.Forms.OpenFileDialog();
            this.menu_Copy.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_HTMLCode
            // 
            this.txt_HTMLCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_HTMLCode.Location = new System.Drawing.Point(12, 12);
            this.txt_HTMLCode.Multiline = true;
            this.txt_HTMLCode.Name = "txt_HTMLCode";
            this.txt_HTMLCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_HTMLCode.Size = new System.Drawing.Size(860, 607);
            this.txt_HTMLCode.TabIndex = 0;
            // 
            // lv_Tag_Value
            // 
            this.lv_Tag_Value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Tag_Value.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header_Name,
            this.header_Tag,
            this.header_Value});
            this.lv_Tag_Value.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lv_Tag_Value.FullRowSelect = true;
            this.lv_Tag_Value.GridLines = true;
            this.lv_Tag_Value.Location = new System.Drawing.Point(879, 13);
            this.lv_Tag_Value.Name = "lv_Tag_Value";
            this.lv_Tag_Value.Size = new System.Drawing.Size(373, 606);
            this.lv_Tag_Value.TabIndex = 1;
            this.lv_Tag_Value.UseCompatibleStateImageBehavior = false;
            this.lv_Tag_Value.View = System.Windows.Forms.View.Details;
            this.lv_Tag_Value.DoubleClick += new System.EventHandler(this.lv_Tag_Value_DoubleClick);
            // 
            // header_Name
            // 
            this.header_Name.Text = "名稱";
            // 
            // header_Tag
            // 
            this.header_Tag.Text = "標籤";
            // 
            // header_Value
            // 
            this.header_Value.Text = "填入值";
            // 
            // btn_Load_Template
            // 
            this.btn_Load_Template.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Load_Template.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Load_Template.Location = new System.Drawing.Point(12, 625);
            this.btn_Load_Template.Name = "btn_Load_Template";
            this.btn_Load_Template.Size = new System.Drawing.Size(124, 44);
            this.btn_Load_Template.TabIndex = 2;
            this.btn_Load_Template.Text = "載入範本";
            this.btn_Load_Template.UseVisualStyleBackColor = true;
            this.btn_Load_Template.Click += new System.EventHandler(this.btn_Load_Template_Click);
            // 
            // btn_DoReplace
            // 
            this.btn_DoReplace.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_DoReplace.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_DoReplace.Location = new System.Drawing.Point(142, 625);
            this.btn_DoReplace.Name = "btn_DoReplace";
            this.btn_DoReplace.Size = new System.Drawing.Size(124, 44);
            this.btn_DoReplace.TabIndex = 2;
            this.btn_DoReplace.Text = "取代標籤";
            this.btn_DoReplace.UseVisualStyleBackColor = true;
            this.btn_DoReplace.Click += new System.EventHandler(this.btn_DoReplace_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Preview.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Preview.Location = new System.Drawing.Point(272, 625);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(124, 44);
            this.btn_Preview.TabIndex = 2;
            this.btn_Preview.Text = "預覽";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // btn_OpenWebsite
            // 
            this.btn_OpenWebsite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OpenWebsite.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OpenWebsite.Location = new System.Drawing.Point(402, 625);
            this.btn_OpenWebsite.Name = "btn_OpenWebsite";
            this.btn_OpenWebsite.Size = new System.Drawing.Size(124, 44);
            this.btn_OpenWebsite.TabIndex = 2;
            this.btn_OpenWebsite.Text = "開啟發布網站";
            this.btn_OpenWebsite.UseVisualStyleBackColor = true;
            this.btn_OpenWebsite.Click += new System.EventHandler(this.btn_OpenWebsite_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Copy.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Copy.Location = new System.Drawing.Point(532, 625);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(124, 44);
            this.btn_Copy.TabIndex = 2;
            this.btn_Copy.Text = "複製...";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Delete_Tag
            // 
            this.btn_Delete_Tag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete_Tag.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Delete_Tag.Location = new System.Drawing.Point(1128, 625);
            this.btn_Delete_Tag.Name = "btn_Delete_Tag";
            this.btn_Delete_Tag.Size = new System.Drawing.Size(124, 44);
            this.btn_Delete_Tag.TabIndex = 2;
            this.btn_Delete_Tag.Text = "刪除";
            this.btn_Delete_Tag.UseVisualStyleBackColor = true;
            this.btn_Delete_Tag.Click += new System.EventHandler(this.btn_Delete_Tag_Click);
            // 
            // btn_Edit_Tag
            // 
            this.btn_Edit_Tag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit_Tag.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Edit_Tag.Location = new System.Drawing.Point(998, 625);
            this.btn_Edit_Tag.Name = "btn_Edit_Tag";
            this.btn_Edit_Tag.Size = new System.Drawing.Size(124, 44);
            this.btn_Edit_Tag.TabIndex = 2;
            this.btn_Edit_Tag.Text = "修改";
            this.btn_Edit_Tag.UseVisualStyleBackColor = true;
            this.btn_Edit_Tag.Click += new System.EventHandler(this.btn_Edit_Tag_Click);
            // 
            // btn_AddTag
            // 
            this.btn_AddTag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_AddTag.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AddTag.Location = new System.Drawing.Point(868, 625);
            this.btn_AddTag.Name = "btn_AddTag";
            this.btn_AddTag.Size = new System.Drawing.Size(124, 44);
            this.btn_AddTag.TabIndex = 2;
            this.btn_AddTag.Text = "新增";
            this.btn_AddTag.UseVisualStyleBackColor = true;
            this.btn_AddTag.Click += new System.EventHandler(this.btn_AddTag_Click);
            // 
            // menu_Copy
            // 
            this.menu_Copy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_CopyHTML});
            this.menu_Copy.Name = "menu_Copy";
            this.menu_Copy.Size = new System.Drawing.Size(169, 48);
            // 
            // menuitem_CopyHTML
            // 
            this.menuitem_CopyHTML.Name = "menuitem_CopyHTML";
            this.menuitem_CopyHTML.Size = new System.Drawing.Size(168, 22);
            this.menuitem_CopyHTML.Text = "複製HTML原始碼";
            // 
            // menu_Sites
            // 
            this.menu_Sites.Name = "menu_Sites";
            this.menu_Sites.Size = new System.Drawing.Size(61, 4);
            // 
            // OFD_Template
            // 
            this.OFD_Template.RestoreDirectory = true;
            this.OFD_Template.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_Template_FileOk);
            // 
            // Form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_AddTag);
            this.Controls.Add(this.btn_Edit_Tag);
            this.Controls.Add(this.btn_Delete_Tag);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_OpenWebsite);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.btn_DoReplace);
            this.Controls.Add(this.btn_Load_Template);
            this.Controls.Add(this.lv_Tag_Value);
            this.Controls.Add(this.txt_HTMLCode);
            this.Name = "Form_MainWindow";
            this.Text = "TUC發布程式";
            this.menu_Copy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_HTMLCode;
        private System.Windows.Forms.ListView lv_Tag_Value;
        private System.Windows.Forms.ColumnHeader header_Name;
        private System.Windows.Forms.ColumnHeader header_Tag;
        private System.Windows.Forms.ColumnHeader header_Value;
        private System.Windows.Forms.Button btn_Load_Template;
        private System.Windows.Forms.Button btn_DoReplace;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_OpenWebsite;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Delete_Tag;
        private System.Windows.Forms.Button btn_Edit_Tag;
        private System.Windows.Forms.Button btn_AddTag;
        private System.Windows.Forms.ContextMenuStrip menu_Copy;
        private System.Windows.Forms.ToolStripMenuItem menuitem_CopyHTML;
        private System.Windows.Forms.ContextMenuStrip menu_Sites;
        private System.Windows.Forms.OpenFileDialog OFD_Template;
    }
}

