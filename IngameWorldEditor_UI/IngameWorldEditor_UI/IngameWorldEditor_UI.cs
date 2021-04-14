using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngameWorldEditor_UI
{
  public static class IngameWorldEditor_UI
  {
    [DllExport]
    public static void UI_Initialize()
    {
      // MessageBox.Show("UI_Initialize");
      Classes.Forms.MainWindow mainWindow = new Classes.Forms.MainWindow();
      mainWindow.ShowDialog();
    }

    [DllExport]
    public static IntPtr UI_CreateWindow()
    {
      Classes.Forms.MainWindow mainWindow = new Classes.Forms.MainWindow();
      return mainWindow.Handle;
    }
  }
}
