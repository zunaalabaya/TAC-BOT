﻿// Decompiled with JetBrains decompiler
// Type: ChangeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FE644F5D-682F-4D6E-964D-A0DD77A288F7
// Assembly location: C:\Users\André\Desktop\Assembly-CSharp.dll

using UnityEngine;

public class ChangeState : MonoBehaviour
{
  public ChangeState.StateTypes State;

  public ChangeState()
  {
    base.\u002Ector();
  }

  public enum StateTypes
  {
    Stand,
    Down,
  }
}