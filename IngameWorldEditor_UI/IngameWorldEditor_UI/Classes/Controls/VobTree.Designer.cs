
namespace IngameWorldEditor_UI.Classes.Controls
{
  partial class VobTree
  {
    /// <summary> 
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.vobTreeView = new System.Windows.Forms.TreeView();
      this.SuspendLayout();
      // 
      // treeView1
      // 
      this.vobTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.vobTreeView.Location = new System.Drawing.Point(0, 0);
      this.vobTreeView.Name = "treeView1";
      this.vobTreeView.Size = new System.Drawing.Size(709, 624);
      this.vobTreeView.TabIndex = 0;
      // 
      // UserControl1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.vobTreeView);
      this.Name = "UserControl1";
      this.Size = new System.Drawing.Size(709, 624);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TreeView vobTreeView;
  }
}
