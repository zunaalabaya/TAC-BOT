﻿// Decompiled with JetBrains decompiler
// Type: SRPG.UnitLearnAbilityElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 85BFDF7F-5712-4D45-9CD6-3465C703DFDF
// Assembly location: S:\Desktop\Assembly-CSharp.dll

using GR;
using System.Collections.Generic;
using UnityEngine;

namespace SRPG
{
  public class UnitLearnAbilityElement : MonoBehaviour, IFlowInterface
  {
    public Transform SkillParent;
    public GameObject SkillTemplate;
    private List<GameObject> mSkills;

    public UnitLearnAbilityElement()
    {
      base.\u002Ector();
    }

    public void Start()
    {
      if (!Object.op_Inequality((Object) this.SkillTemplate, (Object) null))
        return;
      this.SkillTemplate.SetActive(false);
    }

    public void Activated(int pinID)
    {
    }

    public void Refresh()
    {
      AbilityData dataOfClass = DataSource.FindDataOfClass<AbilityData>(((Component) this).get_gameObject(), (AbilityData) null);
      if (dataOfClass != null)
      {
        this.mSkills = new List<GameObject>(dataOfClass.LearningSkills.Length);
        for (int index = 0; index < dataOfClass.LearningSkills.Length; ++index)
        {
          if (dataOfClass.LearningSkills[index] != null && dataOfClass.Rank >= dataOfClass.LearningSkills[index].locklv)
          {
            GameObject gameObject = (GameObject) Object.Instantiate<GameObject>((M0) this.SkillTemplate);
            SkillParam skillParam = MonoSingleton<GameManager>.Instance.GetSkillParam(dataOfClass.LearningSkills[index].iname);
            DataSource.Bind<SkillParam>(gameObject, skillParam);
            gameObject.get_transform().SetParent(this.SkillParent, false);
            gameObject.SetActive(true);
            this.mSkills.Add(gameObject);
          }
        }
      }
      ((Component) this).get_gameObject().SetActive(true);
      GameParameter.UpdateAll(((Component) this).get_gameObject());
    }
  }
}
