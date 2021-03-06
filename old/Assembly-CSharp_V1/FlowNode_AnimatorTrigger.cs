﻿// Decompiled with JetBrains decompiler
// Type: FlowNode_AnimatorTrigger
// Assembly: Assembly-CSharp, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9BA76916-D0BD-4DB6-A90B-FE0BCC53E511
// Assembly location: C:\Users\André\Desktop\Assembly-CSharp.dll

using UnityEngine;

[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
[FlowNode.NodeType("Animator/Trigger", 32741)]
[FlowNode.Pin(10, "Input", FlowNode.PinTypes.Input, 0)]
public class FlowNode_AnimatorTrigger : FlowNode
{
  [FlowNode.ShowInInfo]
  public string TriggerName = "None";
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;
  public bool UpdateAnimator;

  public override string GetCaption()
  {
    return base.GetCaption() + ":" + this.TriggerName;
  }

  public override void OnActivate(int pinID)
  {
    Animator component = (Animator) (!Object.op_Inequality((Object) this.Target, (Object) null) ? ((Component) this).get_gameObject() : this.Target).GetComponent<Animator>();
    if (Object.op_Inequality((Object) component, (Object) null))
    {
      component.SetTrigger(this.TriggerName);
      if (this.UpdateAnimator)
        component.Update(0.0f);
    }
    this.ActivateOutputLinks(1);
  }
}
