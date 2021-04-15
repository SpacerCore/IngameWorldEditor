using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace IngameWorldEditor_UI
{
  public static class IngameWorldEditor_UI
  {
    [DllImport("Ole32.dll")]
    public static extern IntPtr CoInitialize(IntPtr reserved);

    [DllExport]
    public static void UI_Initialize()
    {
      CoInitialize(IntPtr.Zero);
      Application.EnableVisualStyles();
    }

    [DllExport]
    public static IntPtr UI_CreateWindow()
    {
      Classes.Forms.MainWindow mainWindow = new Classes.Forms.MainWindow();
      return mainWindow.Handle;
    }
  }
}
