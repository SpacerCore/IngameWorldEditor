using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngameWorldEditor_UI.Classes.Forms
{
  public partial class MainWindow : Form
  {
    public IntPtr RenderViewHandle
    {
      get
      {
        return panelRenderView.Handle;
      }
    }

    public MainWindow()
    {
      InitializeComponent();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
      Console.WriteLine(e.KeyCode);
      if (e.KeyCode == Keys.Enter)
      {
        //textBox1.Enabled = false;
        //textBox1.Visible = false;
        this.Activate();
        this.Focus();
      }
    }

    private void MainWindow_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.F3)
      {
        IngameWorldEditor_UI.Core_StopInput();
        panel1.Enabled = false;
      }
    }


    private static bool SkipDeactivate = false;

    private void panelRenderView_Click(object sender, EventArgs e)
    {
      this.Focus();
      IngameWorldEditor_UI.Core_StartInput();
      panel1.Enabled = false;
      Console.WriteLine("Click");
      SkipDeactivate = true;
    }

    private void MainWindow_Deactivate(object sender, EventArgs e)
    {
      if (SkipDeactivate == true)
      {
        SkipDeactivate = false;
        return;
      }

      IngameWorldEditor_UI.Core_StopInput();
      panel1.Enabled = true;
      Console.WriteLine("Deactivate");
    }
  }
}
