﻿namespace SRPG
{
    using System;

    [Serializable]
    public class JSON_TrophyParam
    {
        public string iname;
        public string name;
        public string expr;
        public string[] flg_quests;
        public int ymd_start;
        public string category;
        public int disp;
        public int type;
        public string[] sval;
        public int ival;
        public string reward_item1_iname;
        public string reward_item2_iname;
        public string reward_item3_iname;
        public int reward_item1_num;
        public int reward_item2_num;
        public int reward_item3_num;
        public int reward_gold;
        public int reward_coin;
        public int reward_exp;
        public int reward_stamina;
        public string reward_artifact1_iname;
        public string reward_artifact2_iname;
        public string reward_artifact3_iname;
        public int reward_artifact1_num;
        public int reward_artifact2_num;
        public int reward_artifact3_num;
        public string parent_iname;
        public int help;
        public string reward_cc_1_iname;
        public int reward_cc_1_num;
        public string reward_cc_2_iname;
        public int reward_cc_2_num;

        public JSON_TrophyParam()
        {
            base..ctor();
            return;
        }
    }
}
