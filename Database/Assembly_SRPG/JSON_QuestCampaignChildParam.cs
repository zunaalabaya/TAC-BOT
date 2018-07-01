﻿namespace SRPG
{
    using System;

    [Serializable]
    public class JSON_QuestCampaignChildParam
    {
        public string iname;
        public int scope;
        public int quest_type;
        public int quest_mode;
        public string quest_id;
        public string unit;
        public int drop_rate;
        public int drop_num;
        public int exp_player;
        public int exp_unit;
        public int ap_rate;

        public JSON_QuestCampaignChildParam()
        {
            base..ctor();
            return;
        }
    }
}
