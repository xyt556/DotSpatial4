namespace DotSpatial4
{
    partial class mainForm
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
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            新建ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            spatialToolStrip = new DotSpatial.Controls.SpatialToolStrip();
            map = new DotSpatial.Controls.Map();
            legend = new DotSpatial.Controls.Legend();
            spatialStatusStrip = new DotSpatial.Controls.SpatialStatusStrip();
            toolStripStatusLabelzuozhe = new ToolStripStatusLabel();
            spatialDockManager1 = new DotSpatial.Controls.SpatialDockManager();
            menuStrip1.SuspendLayout();
            spatialStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spatialDockManager1).BeginInit();
            spatialDockManager1.Panel1.SuspendLayout();
            spatialDockManager1.Panel2.SuspendLayout();
            spatialDockManager1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 帮助ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 新建ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(44, 21);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            新建ToolStripMenuItem.Size = new Size(100, 22);
            新建ToolStripMenuItem.Text = "新建";
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 关于ToolStripMenuItem });
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(44, 21);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(100, 22);
            关于ToolStripMenuItem.Text = "关于";
            关于ToolStripMenuItem.Click += 关于ToolStripMenuItem_Click;
            // 
            // spatialToolStrip
            // 
            spatialToolStrip.ApplicationManager = null;
            spatialToolStrip.Location = new Point(0, 25);
            spatialToolStrip.Map = map;
            spatialToolStrip.Name = "spatialToolStrip";
            spatialToolStrip.Size = new Size(800, 25);
            spatialToolStrip.TabIndex = 1;
            spatialToolStrip.Text = "spatialToolStrip1";
            // 
            // map
            // 
            map.AllowDrop = true;
            map.BackColor = Color.White;
            map.CollisionDetection = false;
            map.Dock = DockStyle.Fill;
            map.ExtendBuffer = false;
            map.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            map.IsBusy = false;
            map.IsZoomedToMaxExtent = false;
            map.Legend = legend;
            map.Location = new Point(0, 0);
            map.Name = "map";
            map.ProgressHandler = null;
            map.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            map.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            map.RedrawLayersWhileResizing = false;
            map.SelectionEnabled = true;
            map.Size = new Size(530, 378);
            map.TabIndex = 0;
            map.ZoomOutFartherThanMaxExtent = false;
            // 
            // legend
            // 
            legend.BackColor = Color.White;
            legend.ControlRectangle = new Rectangle(0, 0, 266, 378);
            legend.Dock = DockStyle.Fill;
            legend.DocumentRectangle = new Rectangle(0, 0, 187, 428);
            legend.HorizontalScrollEnabled = true;
            legend.Indentation = 30;
            legend.IsInitialized = false;
            legend.Location = new Point(0, 0);
            legend.MinimumSize = new Size(5, 5);
            legend.Name = "legend";
            legend.ProgressHandler = null;
            legend.ResetOnResize = false;
            legend.SelectionFontColor = Color.Black;
            legend.SelectionHighlight = Color.FromArgb(215, 238, 252);
            legend.Size = new Size(266, 378);
            legend.TabIndex = 0;
            legend.Text = "legend1";
            legend.UseLegendForSelection = true;
            legend.VerticalScrollEnabled = true;
            // 
            // spatialStatusStrip
            // 
            spatialStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelzuozhe });
            spatialStatusStrip.Location = new Point(0, 428);
            spatialStatusStrip.Name = "spatialStatusStrip";
            spatialStatusStrip.ProgressBar = null;
            spatialStatusStrip.ProgressLabel = toolStripStatusLabelzuozhe;
            spatialStatusStrip.Size = new Size(800, 22);
            spatialStatusStrip.TabIndex = 2;
            spatialStatusStrip.Text = "spatialStatusStrip1";
            // 
            // toolStripStatusLabelzuozhe
            // 
            toolStripStatusLabelzuozhe.IsLink = true;
            toolStripStatusLabelzuozhe.LinkColor = Color.Blue;
            toolStripStatusLabelzuozhe.LinkVisited = true;
            toolStripStatusLabelzuozhe.Name = "toolStripStatusLabelzuozhe";
            toolStripStatusLabelzuozhe.Size = new Size(80, 17);
            toolStripStatusLabelzuozhe.Text = "作者：奚砚涛";
            // 
            // spatialDockManager1
            // 
            spatialDockManager1.Dock = DockStyle.Fill;
            spatialDockManager1.Location = new Point(0, 50);
            spatialDockManager1.Name = "spatialDockManager1";
            // 
            // spatialDockManager1.Panel1
            // 
            spatialDockManager1.Panel1.Controls.Add(legend);
            // 
            // spatialDockManager1.Panel2
            // 
            spatialDockManager1.Panel2.Controls.Add(map);
            spatialDockManager1.Size = new Size(800, 378);
            spatialDockManager1.SplitterDistance = 266;
            spatialDockManager1.TabControl1 = null;
            spatialDockManager1.TabControl2 = null;
            spatialDockManager1.TabIndex = 3;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(spatialDockManager1);
            Controls.Add(spatialStatusStrip);
            Controls.Add(spatialToolStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            Text = "GIS平台";
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            spatialStatusStrip.ResumeLayout(false);
            spatialStatusStrip.PerformLayout();
            spatialDockManager1.Panel1.ResumeLayout(false);
            spatialDockManager1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spatialDockManager1).EndInit();
            spatialDockManager1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 新建ToolStripMenuItem;
        private DotSpatial.Controls.SpatialToolStrip spatialToolStrip;
        private DotSpatial.Controls.Map map;
        private DotSpatial.Controls.Legend legend;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip;
        private DotSpatial.Controls.SpatialDockManager spatialDockManager1;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabelzuozhe;
    }
}