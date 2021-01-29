using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework
{
    interface IOrderService
    {
        void Sold(Player player, Game game);
        void CampaignApply(Player player);
    }
}
