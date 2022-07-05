using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSlotMachine.Together
{
    public class SlotReward
    {
        public long totalReward;
        public long freeReward;
        public long bonusReward;
        public string itemsCollection;
        public long normalReward;

        public SlotReward(long totalReward, string itemsCollection, long freeReward = 0, long bonusReward = 0)
        {
            this.itemsCollection = itemsCollection;
            this.totalReward = totalReward;
            this.freeReward = freeReward;
            this.bonusReward = bonusReward;
            this.normalReward = totalReward - bonusReward - freeReward;
        }

    }
}
