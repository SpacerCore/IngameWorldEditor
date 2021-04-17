using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngameWorldEditor_UI.Classes.Controls
{
  public partial class VobTree : UserControl
  {
    private Dictionary<IntPtr, VobTreeNode> MappedVobList = new Dictionary<IntPtr, VobTreeNode>();
    private int RedrawLockedCount = 0;

    public VobTree()
    {
      InitializeComponent();
      InitializeDefaultTreeNode();
    }

    private void RegisterVobInMap(IntPtr vobHandle, VobTreeNode node)
    {
      try
      {
        MappedVobList.Add(vobHandle, node);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }

    private void RemoveVobFromMap(IntPtr vobHandle)
    {
      try
      {
        MappedVobList.Remove(vobHandle);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }

    public void InitializeDefaultTreeNode()
    {
      VobTreeNode rootNode = new VobTreeNode(IntPtr.Zero);
      rootNode.Text = "World";
      vobTreeView.Nodes.Add(rootNode);
    }

    public void LockRedraw()
    {
      if (++RedrawLockedCount == 1)
        vobTreeView.BeginUpdate();
    }

    public void UnlockRedraw()
    {
      if (RedrawLockedCount == 0)
        return;

      if (--RedrawLockedCount == 0)
        vobTreeView.EndUpdate();
    }

    public void AddVobNode(IntPtr vobHandle, IntPtr vobParentHandle)
    {
      LockRedraw();
      VobTreeNode node = new VobTreeNode(vobHandle);
      VobTreeNode parentNode = SearchNode(vobParentHandle);
      parentNode.Nodes.Add(node);
      RegisterVobInMap(vobHandle, node);
      UnlockRedraw();
    }

    public void MoveVobNode(IntPtr vobHandle, IntPtr vobParentHandle)
    {
      LockRedraw();
      VobTreeNode node = SearchNode(vobHandle, false);
      if (node != null)
      {
        VobTreeNode parentNode = (VobTreeNode)node.Parent;
        parentNode.Nodes.Remove(node);
        VobTreeNode newParentNode = SearchNode(vobParentHandle, false);
        newParentNode.Nodes.Add(node);
        RemoveVobFromMap(vobHandle);
        RegisterVobInMap(vobHandle, node);
      }
      else
        AddVobNode(vobHandle, vobParentHandle);

      UnlockRedraw();
    }

    public void RemoveVobNode(IntPtr vobHandle)
    {
      LockRedraw();
      vobTreeView.BeginUpdate();
      VobTreeNode node = SearchNode(vobHandle, false);
      if (node == null)
        return;

      while (node.Nodes.Count > 0)
      {
        VobTreeNode childNode = (VobTreeNode)node.Nodes[0];
        RemoveVobNode(childNode.VobHandle);
      }

      VobTreeNode parentNode = (VobTreeNode)node.Parent;
      parentNode.Nodes.Remove(node);
      RemoveVobFromMap(vobHandle);
      UnlockRedraw();
    }

    public VobTreeNode SearchNode(IntPtr vobHandle, bool rootIsDefault = true)
    {
      try
      {
        return MappedVobList[vobHandle];
      }
      catch
      {
        return rootIsDefault ? (VobTreeNode)vobTreeView.Nodes[0] : null;
      }
    }
  }



  public class VobTreeNode : TreeNode
  {
    public IntPtr VobHandle;

    public VobTreeNode(IntPtr vobHandle)
    {
      VobHandle = vobHandle;
      if (VobHandle == IntPtr.Zero)
        return;

      try
      {
        string vobType = IngameWorldEditor_UI.Core_GetVobType(VobHandle);
        string vobName = IngameWorldEditor_UI.Core_GetVobName(VobHandle);
        Text = string.Format("{0}: {1}", vobType, vobName);
      }
      catch (Exception e)
      {
        Text = "[Invalid object]";
        Console.WriteLine(e.Message);
      }
    }
  }
}
