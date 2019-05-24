namespace XMLPlugin
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtBoxParentNodeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxChildNodeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPropLst = new System.Windows.Forms.TextBox();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.radiobtnDel = new System.Windows.Forms.RadioButton();
            this.radioBtnUpdate = new System.Windows.Forms.RadioButton();
            this.lblFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "选择文件";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(214, 263);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "操作";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtBoxParentNodeName
            // 
            this.txtBoxParentNodeName.Location = new System.Drawing.Point(194, 61);
            this.txtBoxParentNodeName.Name = "txtBoxParentNodeName";
            this.txtBoxParentNodeName.Size = new System.Drawing.Size(100, 21);
            this.txtBoxParentNodeName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "父节点名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "修改节点名称";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxChildNodeName
            // 
            this.txtBoxChildNodeName.Location = new System.Drawing.Point(194, 127);
            this.txtBoxChildNodeName.Name = "txtBoxChildNodeName";
            this.txtBoxChildNodeName.Size = new System.Drawing.Size(100, 21);
            this.txtBoxChildNodeName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "修改的属性集合";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPropLst
            // 
            this.txtBoxPropLst.Location = new System.Drawing.Point(194, 161);
            this.txtBoxPropLst.Multiline = true;
            this.txtBoxPropLst.Name = "txtBoxPropLst";
            this.txtBoxPropLst.Size = new System.Drawing.Size(164, 96);
            this.txtBoxPropLst.TabIndex = 7;
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Location = new System.Drawing.Point(439, 19);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(71, 16);
            this.radioBtnAdd.TabIndex = 8;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "添加节点";
            this.radioBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            // 
            // radiobtnDel
            // 
            this.radiobtnDel.AutoSize = true;
            this.radiobtnDel.Location = new System.Drawing.Point(439, 124);
            this.radiobtnDel.Name = "radiobtnDel";
            this.radiobtnDel.Size = new System.Drawing.Size(71, 16);
            this.radiobtnDel.TabIndex = 9;
            this.radiobtnDel.TabStop = true;
            this.radiobtnDel.Text = "删除节点";
            this.radiobtnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobtnDel.UseVisualStyleBackColor = true;
            // 
            // radioBtnUpdate
            // 
            this.radioBtnUpdate.AutoSize = true;
            this.radioBtnUpdate.Location = new System.Drawing.Point(439, 229);
            this.radioBtnUpdate.Name = "radioBtnUpdate";
            this.radioBtnUpdate.Size = new System.Drawing.Size(71, 16);
            this.radioBtnUpdate.TabIndex = 10;
            this.radioBtnUpdate.TabStop = true;
            this.radioBtnUpdate.Text = "更新节点";
            this.radioBtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(103, 17);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(77, 12);
            this.lblFileName.TabIndex = 11;
            this.lblFileName.Text = "选择文件名称";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 298);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.radioBtnUpdate);
            this.Controls.Add(this.radiobtnDel);
            this.Controls.Add(this.radioBtnAdd);
            this.Controls.Add(this.txtBoxPropLst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxChildNodeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxParentNodeName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnOpenFile);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML插件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtBoxParentNodeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxChildNodeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPropLst;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.RadioButton radiobtnDel;
        private System.Windows.Forms.RadioButton radioBtnUpdate;
        private System.Windows.Forms.Label lblFileName;
    }
}

