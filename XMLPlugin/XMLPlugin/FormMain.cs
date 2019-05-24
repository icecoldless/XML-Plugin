using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLPlugin
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //定义一个文件打开控件
            OpenFileDialog ofd = new OpenFileDialog();
            //设置打开对话框的初始目录，默认目录为exe运行文件所在的路径
            ofd.InitialDirectory = Application.StartupPath;
            //设置打开对话框的标题
            ofd.Title = "请选择要打开的文件";
            //设置打开对话框可以多选
            ofd.Multiselect = true;
            //设置对话框打开的文件类型
            ofd.Filter = "文本文件|*.txt|音频文件|*.wav|图片文件|*.jpg|所有文件|*.*";
            //设置文件对话框当前选定的筛选器的索引
            ofd.FilterIndex = 2;
            //设置对话框是否记忆之前打开的目录
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择的文件完整路径
                XMLMgr.Instance.FilePath = ofd.FileName;
                this.lblFileName.Text = ofd.SafeFileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(XMLMgr.Instance.FilePath)) { MessageBox.Show("未选择文件");return; }

            string parentName = this.txtBoxParentNodeName.Text;
            string childName = this.txtBoxChildNodeName.Text;

            if (string.IsNullOrEmpty(parentName) || string.IsNullOrEmpty(childName)) { MessageBox.Show("请输入完整的父节点名称或者子节点名称");return; };

            string[] arr = this.txtBoxPropLst.Text.Split('|');
            List<NodeProp> lst = null;
            if(arr.Length>0)
            {
                lst = new List<NodeProp>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if(!string.IsNullOrEmpty(arr[i]))
                    {
                        NodeProp prop = new NodeProp()
                        {
                            NodeName = arr[i].Split(',')[0],
                            NodeValue = arr[i].Split(',')[1]
                        };
                        if (arr[i].Split(',')[2] == "true")
                        {
                            prop.IsEncrypt = true;
                        }
                        else if (arr[i].Split(',')[2] == "false")
                        {
                            prop.IsEncrypt = false;
                        }
                        lst.Add(prop);
                    }
                }
            }
           
            if (this.radioBtnAdd.Checked)
            {
                XMLMgr.Instance.AddNode(parentName,childName,lst);
                MessageBox.Show("插入成功");
            }else if (this.radiobtnDel.Checked)
            {
                MessageBox.Show(XMLMgr.Instance.DelNode(parentName, childName));
            }
            else if(this.radioBtnUpdate.Checked)
            {
                MessageBox.Show(XMLMgr.Instance.UpdateNode(parentName, childName, lst));
            }
        }
    }
}
