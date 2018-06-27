﻿// Decompiled with JetBrains decompiler
// Type: GiftIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FE644F5D-682F-4D6E-964D-A0DD77A288F7
// Assembly location: C:\Users\André\Desktop\Assembly-CSharp.dll

using GR;
using SRPG;
using UnityEngine;
using UnityEngine.UI;

public class GiftIcon : MonoBehaviour
{
  public GameManager.BadgeTypes BadgeType;
  public GameManager.BadgeCountTypes BadgeCount;
  public GameObject Badge_Gift;
  public Text Badge_Count;

  public GiftIcon()
  {
    base.\u002Ector();
  }

  private void Start()
  {
    if (!Object.op_Inequality((Object) this.Badge_Gift, (Object) null))
      return;
    this.Badge_Gift.SetActive(false);
  }

  private void Update()
  {
    GameManager instanceDirect = MonoSingleton<GameManager>.GetInstanceDirect();
    if (!Object.op_Inequality((Object) instanceDirect, (Object) null) || instanceDirect.CheckBusyBadges(this.BadgeType) || !Object.op_Inequality((Object) this.Badge_Gift, (Object) null))
      return;
    this.Badge_Gift.SetActive(instanceDirect.CheckBadges(this.BadgeType));
    if (!Object.op_Inequality((Object) this.Badge_Count, (Object) null))
      return;
    this.Badge_Count.set_text(instanceDirect.CheckBadgesNumber(this.BadgeCount).ToString());
  }
}