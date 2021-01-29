using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignNo + " No'lu " + campaign.CampaignName + "  sisteme eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignNo + " No'lu " + campaign.CampaignName + "  sistemden silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignNo + " No'lu " + campaign.CampaignName + "  sistemde update edildi"); ;
        }
    }
}
