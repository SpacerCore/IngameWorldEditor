
namespace IngameWorldEditor_UI.Classes.Forms
{
  partial class MainWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panelRenderView = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.vobTree = new IngameWorldEditor_UI.Classes.Controls.VobTree();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelRenderView
      // 
      this.panelRenderView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelRenderView.Location = new System.Drawing.Point(0, 0);
      this.panelRenderView.Name = "panelRenderView";
      this.panelRenderView.Size = new System.Drawing.Size(576, 590);
      this.panelRenderView.TabIndex = 0;
      this.panelRenderView.Click += new System.EventHandler(this.panelRenderView_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(121, 49);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 1;
      this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Controls.Add(this.tabControl1);
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Enabled = false;
      this.panel1.Location = new System.Drawing.Point(594, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(334, 590);
      this.panel1.TabIndex = 1;
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(3, 161);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(328, 426);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.vobTree);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(320, 400);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Vob tree";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(457, 493);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // vobTree
      // 
      this.vobTree.Dock = System.Windows.Forms.DockStyle.Fill;
      this.vobTree.Location = new System.Drawing.Point(3, 3);
      this.vobTree.Name = "vobTree";
      this.vobTree.Size = new System.Drawing.Size(314, 394);
      this.vobTree.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel2.Controls.Add(this.panelRenderView);
      this.panel2.Location = new System.Drawing.Point(12, 12);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(576, 590);
      this.panel2.TabIndex = 1;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(940, 614);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "MainWindow";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "MainWindow";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Deactivate += new System.EventHandler(this.MainWindow_Deactivate);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelRenderView;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    public Classes.Controls.VobTree vobTree;
    private System.Windows.Forms.Panel panel2;
  }
}