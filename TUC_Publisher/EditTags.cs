using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TUC_Publisher;

namespace TUC_Publisher
{
    public partial class Form_Edit_Tags : Form
    {
        internal string name, tag, value;
        public Form_Edit_Tags()
        {
            InitializeComponent();
        }

        public Form_Edit_Tags(string mode, Tag tag_in)
        {
            InitializeComponent();
            if (mode.Equals("add"))
                    this.Text = "新增替換標籤";
            if (mode.Equals("edit"))
                    this.Text = "修改替換標籤";

            name = tag_in.name;
            tag = tag_in.tag;
            value = tag_in.value;
            txt_Name.Text  = name;
            txt_Tag.Text   = tag;
            txt_Value.Text = value;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            name  = txt_Name.Text;
            tag   = txt_Tag.Text;
            value = txt_Value.Text;
            this.Hide();
        }
    }
}
