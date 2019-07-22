using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_TreeView控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击添加根节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbnParent_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(txParent.Text);
            txParent.Text = null;
            txParent.Focus();
        }

        /// <summary>
        /// 点击添加子节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChild_Click(object sender, EventArgs e)
        {
            // 获得当前选择节点
            TreeNode td = treeView1.SelectedNode;

            // 操作当前节点
            td.Nodes.Add(txChild.Text);

            txChild.Text = null;
            txChild.Focus();
        }

        /// <summary>
        /// 点击修改节点名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdata_Click(object sender, EventArgs e)
        {
            TreeNode td = treeView1.SelectedNode;  // 获得当前选中节点

            td.Text = txUpdata.Text;  // 修改节点名称

            txUpdata.Text = null;
            txUpdata.Focus();
        }

        /// <summary>
        /// 点击展开全部节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpenAll_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();  // 展开全部
        }

        private void BtnCloseAll_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();  // 折叠所有
        }

        /// <summary>
        /// 点击删除节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            TreeNode td = treeView1.SelectedNode;  // 获得当前选中节点

            //td.Nodes.Clear();   // 清空所有子节点

            td.Remove();   // 移除当前节点
        }
    }
}
