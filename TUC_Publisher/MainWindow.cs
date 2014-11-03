using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TUC_Publisher
{
    public partial class Form_MainWindow : Form
    {
        Form_Edit_Tags F_AddTags;
        Form_Edit_Tags F_EditTags;
        ListDictionary SitesCollection = new ListDictionary();

        private void AutoResizeAllColumns()
        {
            foreach (ColumnHeader CH in lv_Tag_Value.Columns)
            {
                CH.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                if (CH.Width < 70) CH.Width = 70;
            }
            
        }
        private void DoReplace()
        {
            /* 為了預防要將某tag取代成空白的狀況 所以不將填入值Trim() */
            foreach (ListViewItem LVI in lv_Tag_Value.Items)
            {
                if (LVI.SubItems[2].Text != String.Empty)
                    txt_HTMLCode.Text = txt_HTMLCode.Text.Replace(LVI.SubItems[1].Text.Trim(), LVI.SubItems[2].Text);
            }
            foreach (ListViewItem LVI in lv_Tag_Value.Items)
            {
                if (LVI.SubItems[2].Text != String.Empty)
                {
                    if (txt_HTMLCode.Text.IndexOf(LVI.SubItems[1].Text) != -1)
                        DoReplace();
                }
            }
        }

        void ClearAll()
        {
            txt_HTMLCode.Text = String.Empty;
            lv_Tag_Value.Items.Clear();
            SitesCollection.Clear();
            menu_Sites.Items.Clear();
        }

        void ParseTemplate(string FileName)
        {
            string temp;
            string[] temparr;
            short phrase = 1, i = 0;
            ClearAll();
            StreamReader SR = new StreamReader(FileName);
            while (!SR.EndOfStream)
            {
                temp = SR.ReadLine();
                if (phrase == 1)
                {
                    if (temp.Equals("### ###"))
                    { phrase++; continue; }
                    else if (temp.Trim().StartsWith("//"))
                        continue;
                    else if (!String.IsNullOrWhiteSpace(temp.Trim()))
                    {
                        temparr = temp.Split(',');
                        ListViewItem LVI = new ListViewItem();
                        LVI.Text = temparr[0]; 
                        LVI.SubItems.Add(temparr[1].Trim());
                        if (temparr.Length > 2) LVI.SubItems.Add(temparr[2].Trim());
                        else LVI.SubItems.Add(String.Empty);
                        lv_Tag_Value.Items.Add(LVI);
                    }
                    AutoResizeAllColumns();
                }
                else if (phrase == 2)
                {
                    if (temp.Equals("### ###"))
                    { phrase++; continue; }
                    else if (temp.Trim().StartsWith("//"))
                        continue;
                    else if (!String.IsNullOrWhiteSpace(temp.Trim()))
                    {
                        temparr = temp.Split(',');
                        SitesCollection[temparr[0]] = temparr[1];
                        ToolStripMenuItem TSMI = new ToolStripMenuItem(temparr[0]);
                        TSMI.Click += (sender, eventArgs) =>
                            {
                                form_Preview F_Preview = new form_Preview((string)SitesCollection[TSMI.Text]);
                                F_Preview.Show();
                            };
                        menu_Sites.Items.Add(TSMI);
                    }
                }
                else if (phrase == 3)
                {
                    if (temp.Equals("### ###"))
                    { phrase++; continue; }
                    else if (temp.Trim().StartsWith("//"))
                        continue;
                    else
                        txt_HTMLCode.Text += temp;
                }
            }
        }

        public Form_MainWindow()
        {
            InitializeComponent();
            AutoResizeAllColumns();
            menuitem_CopyHTML.Click += new EventHandler(menuitem_CopyHTML_Click);
        }

        private void menuitem_CopyHTML_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_HTMLCode.Text))
                Clipboard.SetText(txt_HTMLCode.Text);
        }

        private void btn_AddTag_Click(object sender, EventArgs e)
        {
            F_AddTags = new Form_Edit_Tags();
            F_AddTags.ShowDialog();
            ListViewItem LVI = new ListViewItem(F_AddTags.name);
            LVI.SubItems.Add(F_AddTags.tag);
            LVI.SubItems.Add(F_AddTags.value);
            lv_Tag_Value.Items.Add(LVI);
            F_AddTags.Dispose();
            AutoResizeAllColumns();
        }

        private void btn_Delete_Tag_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem LVI in lv_Tag_Value.SelectedItems)
                LVI.Remove();
            AutoResizeAllColumns();
        }

        private void btn_Edit_Tag_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem LVI in lv_Tag_Value.SelectedItems)
            {
                Tag EditTag = new Tag();
                EditTag.name = LVI.SubItems[0].Text;
                EditTag.tag = LVI.SubItems[1].Text;
                if (LVI.SubItems.Count < 3) LVI.SubItems.Add(EditTag.value);
                EditTag.value = LVI.SubItems[2].Text;
                //catch (Exception Ex) { MessageBox.Show(Ex.Message); }

                F_EditTags = new Form_Edit_Tags("edit", EditTag);
                F_EditTags.ShowDialog();

                LVI.SubItems[0].Text = F_EditTags.name;
                LVI.SubItems[1].Text = F_EditTags.tag;
                try { LVI.SubItems[2].Text = F_EditTags.value; }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }

                F_EditTags.Dispose();
            }
            AutoResizeAllColumns();
        }

        private void btn_DoReplace_Click(object sender, EventArgs e)
        {
            DoReplace();
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            form_Preview F_Preview = new form_Preview(txt_HTMLCode.Text);
            F_Preview.Show();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            menu_Copy.Show(btn_Copy, new Point(0,-menu_Copy.Size.Height));
        }

        private void btn_Load_Template_Click(object sender, EventArgs e)
        {
            OFD_Template.ShowDialog();
        }

        private void btn_OpenWebsite_Click(object sender, EventArgs e)
        {
            menu_Sites.Show(btn_OpenWebsite, new Point(0, -btn_OpenWebsite.Size.Height));
        }

        private void OFD_Template_FileOk(object sender, CancelEventArgs e)
        {
            ParseTemplate(OFD_Template.FileName);
        }

        private void lv_Tag_Value_DoubleClick(object sender, EventArgs e)
        {
            btn_Edit_Tag_Click(null, null);
        }
    }
}
