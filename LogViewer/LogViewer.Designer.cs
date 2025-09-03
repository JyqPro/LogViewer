namespace LogViewer
{
    partial class LogViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewer));
            toolStrip1 = new ToolStrip();
            statusStrip1 = new StatusStrip();
            splitContainer1 = new SplitContainer();
            tree_testList = new TreeView();
            imageList1 = new ImageList(components);
            txt_content = new RichTextBox();
            btn_open = new ToolStripButton();
            btn_loadLog = new ToolStripButton();
            btn_close = new ToolStripButton();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_open, btn_loadLog, btn_close });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1328, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 748);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1328, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tree_testList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txt_content);
            splitContainer1.Size = new Size(1328, 721);
            splitContainer1.SplitterDistance = 442;
            splitContainer1.TabIndex = 2;
            // 
            // tree_testList
            // 
            tree_testList.Dock = DockStyle.Fill;
            tree_testList.ImageIndex = 0;
            tree_testList.ImageList = imageList1;
            tree_testList.Location = new Point(0, 0);
            tree_testList.Name = "tree_testList";
            tree_testList.SelectedImageIndex = 0;
            tree_testList.Size = new Size(442, 721);
            tree_testList.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "file16.png");
            // 
            // txt_content
            // 
            txt_content.Dock = DockStyle.Fill;
            txt_content.Location = new Point(0, 0);
            txt_content.Name = "txt_content";
            txt_content.ReadOnly = true;
            txt_content.Size = new Size(882, 721);
            txt_content.TabIndex = 0;
            txt_content.Text = "";
            // 
            // btn_open
            // 
            btn_open.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_open.Image = Resource.open_folder32;
            btn_open.ImageTransparentColor = Color.Magenta;
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(29, 24);
            btn_open.Text = "打开日志";
            // 
            // btn_loadLog
            // 
            btn_loadLog.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_loadLog.Image = Resource.folder32;
            btn_loadLog.ImageTransparentColor = Color.Magenta;
            btn_loadLog.Name = "btn_loadLog";
            btn_loadLog.Size = new Size(29, 24);
            btn_loadLog.Text = "仅加载日志";
            // 
            // btn_close
            // 
            btn_close.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_close.Image = Resource.close32;
            btn_close.ImageTransparentColor = Color.Magenta;
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(29, 24);
            btn_close.Text = "退出";
            // 
            // LogViewer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 770);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogViewer";
            Text = "LogViewer";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private TreeView tree_testList;
        private RichTextBox txt_content;
        private ImageList imageList1;
        private ToolStripButton btn_open;
        private ToolStripButton btn_loadLog;
        private ToolStripButton btn_close;
    }
}
