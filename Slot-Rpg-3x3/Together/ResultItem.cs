using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSlotMachine.Together
{
   public class ResultItem
    {

        public string Matrix;
        public string LineWinString;
        public long ValueWinLine;
        public int NumberNormalSpecialSpin;
        public long ValueNormalSpecialSpin;
        public int NumberBonusSpin;
        public long ValueBonus;
        public int NumberFreeSpin;
        public long ValueFreeSpin;
        public long Total;
        public int Jackpot;
        public string ModelFreeString;
        public string ExtendMatrixDescription;


        //public string MatrixAfterJump;//co the bo buoc nay chuyen ma tran tren thanh ma tran cuoi
        //public List<PosJumpWill> PosJumpWill;

        public ResultItem(string Matrix, string LineWinString, long ValueWinLine, long ValueBonus, int NumberFreeSpin, long ValueFreeSpin, long Total, int Jackpot, string ExtendMatrixDescription, string ModelFreeString)
        {
            this.Matrix = Matrix;
            this.LineWinString = LineWinString;
            this.ValueWinLine = ValueWinLine;
            this.ValueBonus = ValueBonus;
            this.NumberFreeSpin = NumberFreeSpin;
            this.ValueFreeSpin = ValueFreeSpin;
            this.Total = Total;
            this.Jackpot = Jackpot;
            this.ExtendMatrixDescription = ExtendMatrixDescription;
            this.ModelFreeString = ModelFreeString;
        }

        public string GetString()
        {
            string toString = this.Matrix + "-" + this.Jackpot + "-" + this.ExtendMatrixDescription + "-" + this.ModelFreeString;
            return toString;
        }
    }

    public class PosJumpWill
    {
        //star == 0 --> new
        public int StartPos;
        //end == 0 --> remove
        public int EndPos;

        public PosJumpWill(int start, int end)
        {
            this.StartPos = start;
            this.EndPos = end;
        }
    }

    public class PrizeLine  // tra ve chung cac game
    {
        public int LineID;
        public int PrizeValue;
        public List<int> Items;

        public PrizeLine(int LineID, int PrizeValue, List<int> Items)
        {
            this.LineID = LineID;
            this.PrizeValue = PrizeValue;
            this.Items = Items;
        }
    }
}
