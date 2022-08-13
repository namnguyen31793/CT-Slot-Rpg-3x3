using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSlotMachine.Model
{
    public class RewardModel
    {
        public TYPE_RESULT type;
        public int multiValue;
        public int point;

        public RewardModel(TYPE_RESULT type, int multiValue, int point = 0) {
            this.type = type;
            this.multiValue = multiValue;
            this.point = point;
        }
    }

    public enum TYPE_RESULT : int
    {
        NONE = 0,
        DAMAGE = 1,
        DEF = 2,
        HEAL = 3,
        MISS = 4,
    }
}
