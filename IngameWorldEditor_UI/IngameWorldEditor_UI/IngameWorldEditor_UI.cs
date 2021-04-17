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
    public static Classes.Forms.MainWindow MainWindow = null;

    [DllImport("Ole32.dll")]
    public static extern IntPtr CoInitialize(IntPtr reserved);

    [DllImport("IngameWorldEditor_Core.dll")]
    public static extern void Core_StopInput();

    [DllImport("IngameWorldEditor_Core.dll")]
    public static extern void Core_StartInput();

    [DllImport("IngameWorldEditor_Core.dll")]
    private static extern IntPtr Core_GetVobNamePtr(IntPtr vobHandle);

    public static string Core_GetVobName(IntPtr vobHandle)
    {
      IntPtr ansiPtr = Core_GetVobNamePtr(vobHandle);
      return Marshal.PtrToStringAnsi(ansiPtr);
    }

    [DllImport("IngameWorldEditor_Core.dll")]
    private static extern IntPtr Core_GetVobTypePtr(IntPtr vobHandle);

    public static string Core_GetVobType(IntPtr vobHandle)
    {
      IntPtr ansiPtr = Core_GetVobTypePtr(vobHandle);
      return Marshal.PtrToStringAnsi(ansiPtr);
    }

    [DllExport]
    public static void UI_Initialize()
    {
      CoInitialize(IntPtr.Zero);
      Application.EnableVisualStyles();
    }

    [DllExport]
    public static IntPtr UI_CreateWindow()
    {
      MainWindow = new Classes.Forms.MainWindow();
      return MainWindow.Handle;
    }

    [DllExport]
    public static IntPtr UI_GetRenderView()
    {
      return MainWindow.RenderViewHandle;
    }

    [DllExport]
    public static void UI_ShowWindow()
    {
      MainWindow.Show();
    }

    [DllExport]
    public static void UI_SetWindowText(string text)
    {
      MainWindow.Text = text;
    }

    [DllExport]
    public static void UI_VobTree_Add(IntPtr vobHandle, IntPtr vobParentHandle)
    {
      MainWindow.vobTree.AddVobNode(vobHandle, vobParentHandle);
    }

    [DllExport]
    public static void UI_VobTree_Move(IntPtr vobHandle, IntPtr vobParentHandle)
    {
      MainWindow.vobTree.MoveVobNode(vobHandle, vobParentHandle);
    }

    [DllExport]
    public static void UI_VobTree_Remove(IntPtr vobHandle)
    {
      MainWindow.vobTree.RemoveVobNode(vobHandle);
    }

    [DllExport]
    public static void UI_VobTree_LockRedraw()
    {
      MainWindow.vobTree.LockRedraw();
    }

    [DllExport]
    public static void UI_VobTree_UnlockRedraw()
    {
      MainWindow.vobTree.UnlockRedraw();
    }
  }
}
