using NewSlotMachine.Together;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSlotMachine.Server
{
    public class RewardCollection : List<SlotReward>
    {
       

        public RewardCollection()
        {
            this.Clear();
        }

        private void Init()
        {
            this.Add(new SlotReward(0,"5 4 6 5 4  4 2 6 7 1  3 5 1 6 1"));
            this.Add(new SlotReward(0, "2 2 5 3 6  6 5 5 4 1  7 4 7 1 4"));
            this.Add(new SlotReward(0, "3 2 2 5 4  7 3 6 4 7  3 3 2 2 6"));
            this.Add(new SlotReward(0, "1 7 4 3 4  7 5 5 6 6  1 3 3 6 4"));
            this.Add(new SlotReward(0, "3 4 5 1 5  7 7 6 4 6  1 7 5 1 7"));
            this.Add(new SlotReward(0, "2 5 1 2 1  7 6 3 7 5  2 7 6 2 5"));
            this.Add(new SlotReward(0, " 5 1 3 5 7  2 1 4 3 5  5 6 6 1 2"));
            this.Add(new SlotReward(0, " 5 4 3 7 7  7 2 6 1 7  1 6 6 5 3"));
            this.Add(new SlotReward(0, "2 5 3 4 7  6 5 3 4 4  2 7 6 4 3"));
            this.Add(new SlotReward(0, "2 4 6 1 4  7 6 7 2 2  4 5 1 7 5"));
            this.Add(new SlotReward(0, "3 3 2 4 7  6 6 7 1 1  1 1 3 5 4"));
            this.Add(new SlotReward(0, "3 1 6 5 7  6 4 2 2 4  4 7 1 6 5"));
            this.Add(new SlotReward(0, "7 6 1 4 4  2 7 2 1 7  7 1 5 6 5"));
            this.Add(new SlotReward(0, " 7 4 7 3 4  7 7 6 2 6  3 7 7 2 2"));
            this.Add(new SlotReward(0, " 1 7 4 1 7  7 2 6 2 4  5 7 5 6 4"));
            this.Add(new SlotReward(0, " 3 4 7 7 4  6 2 1 2 4  6 4 6 2 1"));
            this.Add(new SlotReward(0, " 4 2 6 3 2  7 5 3 7 7  6 5 2 4 5"));
            this.Add(new SlotReward(0, "2 4 6 2 5  6 2 4 1 7  6 4 5 1 1"));
            this.Add(new SlotReward(0, "5 4 7 5 6  4 5 1 7 2  2 2 3 3 5"));
            this.Add(new SlotReward(0, " 2 6 3 7 5  1 4 7 1 6  6 6 4 3 2"));
            this.Add(new SlotReward(0, "7 3 7 2 5  3 1 6 2 5  3 3 7 6 4"));
            this.Add(new SlotReward(0, "7 7 6 5 7  5 5 4 2 1  3 7 4 1 2"));
            this.Add(new SlotReward(0, "4 6 2 2 6  7 2 7 6 4  5 3 5 3 1"));
            this.Add(new SlotReward(0, "4 5 1 2 4  2 6 6 3 3  1 6 1 3 5"));
            this.Add(new SlotReward(0, "7 7 6 2 4  5 3 6 7 2  7 1 7 5 6"));
            this.Add(new SlotReward(0, "5 6 3 2 7  4 4 6 6 1  1 3 3 4 7"));
            this.Add(new SlotReward(0, " 2 3 3 2 7  4 2 5 4 2  1 6 7 4 2"));

            this.Add(new SlotReward(200, "6 7 5 3 2  7 4 2 6 4  3 7 6 7 4"));
            this.Add(new SlotReward(200, "4 6 6 7 1  7 1 2 3 6  4 1 4 7 5"));
            this.Add(new SlotReward(200, " 6 1 7 4 4  6 4 6 5 5  5 7 2 4 6"));
            this.Add(new SlotReward(200, "7 7 6 6 6  4 6 2 7 3  4 3 7 2 3"));
            this.Add(new SlotReward(200, "1 6 5 7 2  1 7 6 6 5  6 2 1 7 4"));
            this.Add(new SlotReward(200, "7 6 6 7 5  2 7 1 6 3  6 5 4 3 7"));
            this.Add(new SlotReward(200, "6 3 4 6 3  2 6 5 3 5  2 6 6 1 2"));
            this.Add(new SlotReward(200, "6 7 3 5 2  7 7 6 6 4  7 7 7 1 3"));
            this.Add(new SlotReward(200, "6 4 6 5 5  7 1 2 4 2  2 6 4 3 3"));
            this.Add(new SlotReward(200, "6 7 6 6 4  4 5 7 3 4  3 7 5 1 5"));
            this.Add(new SlotReward(200, "1 2 7 6 6  2 2 5 1 4  6 3 5 5 3"));
            this.Add(new SlotReward(200, "2 6 3 3 7  6 4 6 3 4  5 4 1 3 5"));
            this.Add(new SlotReward(200, "6 2 5 6 5  6 1 1 3 5  7 6 4 1 3"));
            this.Add(new SlotReward(200, "4 4 7 7 6  2 7 6 4 7  5 6 2 7 7"));
            this.Add(new SlotReward(200, "2 6 2 6 4  4 7 3 4 1  6 3 1 6 1"));
            this.Add(new SlotReward(200, "6 5 3 6 2  7 4 2 4 3  6 4 2 4 6"));
            this.Add(new SlotReward(200, "2 4 6 5 3  5 7 1 6 4  1 2 3 5 6"));

            this.Add(new SlotReward(200, "1 6 3 7 2  3 3 6 1 5  2 7 6 4 7", 200));
            this.Add(new SlotReward(200, "6 4 3 7 2  1 4 5 7 6  1 3 2 3 2", 200));
            this.Add(new SlotReward(200, "4 5 2 2 7  6 7 3 6 3  6 3 4 6 5", 200));
            this.Add(new SlotReward(200, "2 3 6 7 7  3 4 3 7 1  7 5 1 2 6", 200));
            this.Add(new SlotReward(200, "5 5 2 4 2  5 7 4 1 3  1 7 3 3 2", 200));
            this.Add(new SlotReward(200, "6 3 2 5 4  6 3 1 2 7  3 6 3 2 1", 200));
            this.Add(new SlotReward(200, "2 3 1 3 1  7 6 2 5 7  5 2 1 7 3", 200));
            this.Add(new SlotReward(200, "3 6 3 3 7  2 5 7 7 5  7 5 4 1 1", 200));
            this.Add(new SlotReward(200, "2 3 5 3 7  6 1 3 3 5  1 2 5 1 2", 200));
            this.Add(new SlotReward(200, "  4 4 3 1 3  7 7 2 6 4  5 3 2 7 5", 200));
            this.Add(new SlotReward(200, "  4 1 5 1 7  5 4 3 6 3  3 5 2 3 4", 200));
            this.Add(new SlotReward(200, "  6 3 2 1 7  3 1 7 5 2  4 1 3 2 6", 200));
            this.Add(new SlotReward(200, "  1 1 5 3 4  7 5 3 1 4  3 1 5 7 6", 200));
            this.Add(new SlotReward(200, "  4 7 6 3 1  2 1 4 2 3  7 3 5 1 2", 200));
            this.Add(new SlotReward(200, "  5 4 1 7 7  6 3 3 6 3  5 2 4 4 3", 200));
            this.Add(new SlotReward(200, "  5 6 3 1 2  3 6 6 5 5  3 7 4 5 3", 200));
            this.Add(new SlotReward(200, "  5 2 7 3 3  3 7 1 5 7  3 5 2 3 6", 200));
            this.Add(new SlotReward(200, "  6 1 5 4 7  7 5 7 7 3  6 2 3 3 1", 200));
            this.Add(new SlotReward(200, "  3 2 5 4 5  4 3 3 1 1  6 7 2 7 1", 200));
            this.Add(new SlotReward(200, "  3 4 6 7 5  2 3 5 7 3  6 7 6 3 3", 200));
            this.Add(new SlotReward(200, "  6 4 5 4 1  6 7 3 4 7  3 4 5 1 3", 200));
            this.Add(new SlotReward(200, "  1 7 2 3 6  1 6 3 1 2  3 4 2 7 7", 200));
            this.Add(new SlotReward(200, "  1 5 3 6 7  4 6 3 3 3  1 2 2 7 6", 200));
            this.Add(new SlotReward(200, "  7 1 5 1 3  7 5 5 7 3  6 6 3 3 7", 200));


            this.Add(new SlotReward(300, "  3 5 4 3 6  2 7 4 2 6  5 1 5 7 3"));
            this.Add(new SlotReward(300, "  4 5 5 1 3  7 6 4 5 3  2 3 7 6 5"));
            this.Add(new SlotReward(300, "  1 4 5 7 5  6 4 7 7 4  6 5 2 1 3"));
            this.Add(new SlotReward(300, "  5 2 3 5 7  1 4 5 7 6  2 1 5 3 6"));
            this.Add(new SlotReward(300, "  7 5 1 3 2  3 7 1 1 6  5 7 4 3 5"));
            this.Add(new SlotReward(300, "  7 3 2 2 5  3 4 5 7 5  7 7 2 5 6"));
            this.Add(new SlotReward(300, "  2 7 3 4 5  3 6 5 6 1  5 7 4 1 2"));
            this.Add(new SlotReward(300, "  5 6 2 2 5  6 7 4 7 3  5 7 3 5 3"));
            this.Add(new SlotReward(300, "  7 3 2 2 7  5 2 6 7 7  1 2 5 5 1"));
            this.Add(new SlotReward(300, "  4 2 2 5 1  3 7 1 2 6  5 7 5 6 1"));
            this.Add(new SlotReward(300, "  3 6 1 2 7  5 4 2 3 7  7 4 5 5 3"));
            this.Add(new SlotReward(300, "  5 2 2 3 4  7 3 7 3 4  4 3 2 5 5"));
            this.Add(new SlotReward(300, "  2 7 7 6 5  7 5 5 1 1  4 6 2 6 1"));
            this.Add(new SlotReward(300, "  2 2 3 5 3  5 2 6 6 4  7 5 4 7 4"));
            this.Add(new SlotReward(300, "  3 1 6 6 5  5 3 7 1 3  4 2 5 5 2"));
            this.Add(new SlotReward(300, "  5 6 4 7 3  4 2 4 3 1  6 7 4 5 5"));


            this.Add(new SlotReward(400, "  1 5 6 3 3  6 6 6 5 4  5 4 7 7 2"));
            this.Add(new SlotReward(400, "  2 5 4 7 4  6 3 4 7 5  4 6 4 2 6"));
            this.Add(new SlotReward(400, "  4 3 7 6 3  3 7 4 7 1  3 7 4 4 6"));
            this.Add(new SlotReward(400, "  6 2 4 5 3  4 1 3 5 6  1 2 4 4 7"));
            this.Add(new SlotReward(400, "  1 6 1 6 7  6 3 4 2 7  1 7 3 2 5"));
            this.Add(new SlotReward(400, "  6 5 2 3 4  4 6 2 6 2  3 4 2 5 4"));
            this.Add(new SlotReward(400, "  1 4 7 6 1  7 7 4 5 4  4 6 3 3 2"));
            this.Add(new SlotReward(400, "  4 5 5 4 3  6 3 7 2 7  4 1 4 1 5"));
            this.Add(new SlotReward(400, "  5 1 3 4 1  4 2 3 4 1  6 4 2 2 6"));
            this.Add(new SlotReward(400, "  6 1 1 3 3  2 3 6 2 4  5 5 4 4 1"));
            this.Add(new SlotReward(400, "  5 4 6 3 4  2 6 2 1 7  3 4 2 4 2"));
            this.Add(new SlotReward(400, "  6 4 2 7 1  6 1 3 7 6  4 2 5 1 4"));
            this.Add(new SlotReward(400, "  3 4 4 3 5  1 2 6 4 7  2 4 2 5 4"));
            this.Add(new SlotReward(400, "  7 6 3 2 7  3 1 1 2 4  5 6 6 6 3"));
            this.Add(new SlotReward(400, "  6 2 7 1 2  1 7 4 3 4  6 4 2 2 6"));
            this.Add(new SlotReward(400, "  5 6 7 7 7  3 4 6 5 2  7 6 4 2 6"));
            this.Add(new SlotReward(400, "  1 6 4 1 4  5 7 3 2 2  1 2 5 4 7"));
            this.Add(new SlotReward(400, "  5 5 2 4 6  4 3 2 5 1  5 4 6 7 1"));
            this.Add(new SlotReward(400, "  6 3 5 1 6  1 6 5 1 7  4 5 5 3 4"));


            this.Add(new SlotReward(500, "  2 3 5 5 6  2 4 7 3 4  1 2 1 1 5"));
            this.Add(new SlotReward(500, "  1 6 2 2 3  4 6 4 1 5  7 6 1 3 7"));
            this.Add(new SlotReward(500, "  2 7 4 2 5  3 2 3 1 1  7 7 1 6 2"));
            this.Add(new SlotReward(500, "  1 6 6 1 3  3 1 4 2 2  4 3 1 2 6"));
            this.Add(new SlotReward(500, "  1 5 4 1 3  4 7 7 7 2  1 6 1 6 3"));
            this.Add(new SlotReward(500, "  7 7 6 4 6  6 7 5 1 5  1 1 1 3 5"));
            this.Add(new SlotReward(500, "  4 1 6 6 5  1 2 4 7 5  3 4 1 5 6"));
            this.Add(new SlotReward(500, "  2 5 5 2 6  1 6 4 1 4  7 5 6 5 3"));
            this.Add(new SlotReward(500, "  5 3 2 1 5  5 2 6 1 5  1 1 2 2 6"));
            this.Add(new SlotReward(500, "  6 7 1 1 1  6 5 7 5 3  7 6 3 7 2"));
            this.Add(new SlotReward(500, "  1 5 3 1 3  4 4 1 7 5  6 5 2 7 5"));


            this.Add(new SlotReward(600, "  3 3 1 7 7  4 1 7 3 3  6 5 3 1 6",600));
            this.Add(new SlotReward(600, "  3 6 3 1 7  5 3 3 1 1  2 2 7 3 7", 600));
            this.Add(new SlotReward(600, "  3 4 5 4 2  2 6 3 2 3  3 3 5 1 1", 600));
            this.Add(new SlotReward(600, "  3 3 1 7 7  4 6 4 3 7  3 3 1 3 6", 600));
            this.Add(new SlotReward(600, "  1 7 5 2 7  3 1 3 3 7  4 4 3 3 7", 600));
            this.Add(new SlotReward(600, "  4 7 3 3 3  3 3 1 6 7  2 5 7 1 4", 600));
            this.Add(new SlotReward(600, "  6 1 4 3 7  3 2 7 2 3  7 2 5 2 7", 600));
            this.Add(new SlotReward(600, "  4 5 1 4 5  3 1 3 7 3  5 6 1 4 6", 600));
            this.Add(new SlotReward(600, "  4 3 2 3 3  5 2 7 3 1  4 5 4 6 3", 600));


            this.Add(new SlotReward(600, "  5 6 1 7 3  6 3 3 1 2  5 5 3 6 4", 400));
            this.Add(new SlotReward(600, "  5 7 3 5 2  3 4 2 3 6  3 4 6 6 1", 400));
            this.Add(new SlotReward(600, "  2 7 6 6 7  1 5 2 5 6  3 2 3 6 3", 400));
            this.Add(new SlotReward(600, "  2 6 3 6 2  3 5 6 3 1  1 7 3 7 1", 400));
            this.Add(new SlotReward(600, "  3 3 7 4 7  3 6 6 4 6  4 7 2 3 5", 400));
            this.Add(new SlotReward(600, "  6 2 6 3 1  4 5 3 7 1  1 3 4 6 7", 400));
            this.Add(new SlotReward(600, "  5 7 6 7 5  1 6 3 3 3  1 7 3 4 6", 400));
            this.Add(new SlotReward(600, "  1 7 6 2 1  4 6 3 2 7  6 3 3 2 3", 400));

            this.Add(new SlotReward(600, "  4 3 5 3 3  6 6 4 4 1  6 7 2 7 2",200));
            this.Add(new SlotReward(600, "  5 4 2 5 4  4 1 3 3 3  1 6 4 7 2", 200));
            this.Add(new SlotReward(600, "  4 3 7 7 5  3 5 2 2 4  6 2 3 4 4", 200));
            this.Add(new SlotReward(600, "  1 7 2 1 6  5 2 4 3 3  6 7 3 6 6", 200));

            this.Add(new SlotReward(600, "  1 5 1 3 6  3 2 7 4 7  7 5 5 4 5"));
            this.Add(new SlotReward(600, "  6 6 6 7 1  7 6 5 3 3  5 1 4 6 2"));
            this.Add(new SlotReward(600, "  6 7 5 6 5  2 6 4 5 2  1 5 5 3 4"));
            this.Add(new SlotReward(600, "  2 5 7 3 5  7 5 7 2 6  5 3 5 7 4"));
            this.Add(new SlotReward(600, "  5 4 5 1 3  6 4 5 5 3  1 4 5 3 3"));
            this.Add(new SlotReward(600, "  4 5 5 3 3  7 7 6 7 3  5 1 7 4 6"));
            this.Add(new SlotReward(600, "  2 5 4 4 5  1 7 5 3 5  6 4 2 6 1"));


            this.Add(new SlotReward(700, "  5 3 7 3 5  2 2 4 6 3  7 5 7 2 5",400));
            this.Add(new SlotReward(700, "  7 3 3 2 5  1 5 7 3 3  3 2 5 2 1", 400));
            this.Add(new SlotReward(700, "  5 4 1 6 5  3 3 1 4 7  3 2 4 5 3", 400));
            this.Add(new SlotReward(700, "  3 5 1 7 3  2 3 5 4 3  7 4 1 7 5", 400));
            this.Add(new SlotReward(700, "  5 6 3 3 5  1 7 3 2 3  7 5 7 2 4", 400));
            this.Add(new SlotReward(700, "  3 5 5 6 3  6 1 1 6 5  3 1 3 3 6", 400));
            this.Add(new SlotReward(700, "  3 5 3 5 3  2 6 2 7 7  5 1 7 5 7", 400));
            this.Add(new SlotReward(700, "  4 2 3 5 2  6 3 5 3 5  1 2 7 7 5", 400));
            this.Add(new SlotReward(700, "  5 6 4 3 7  2 1 3 6 1  1 3 4 5 5", 400));
            this.Add(new SlotReward(700, "  6 5 7 5 4  6 3 5 1 3  3 6 4 4 3", 400));
            this.Add(new SlotReward(700, "  2 4 3 6 5  3 5 4 3 7  3 6 5 2 5", 400));

            this.Add(new SlotReward(700, "  1 3 4 4 3  3 1 3 2 5  5 6 1 2 1", 200));
            this.Add(new SlotReward(700, "  5 4 1 1 3  7 5 3 1 4  3 6 2 2 1", 200));
            this.Add(new SlotReward(700, "  2 5 3 1 5  2 7 3 5 3  1 3 1 6 5", 200));
            this.Add(new SlotReward(700, "  1 6 1 2 7  4 3 3 2 7  3 1 6 7 2", 200));
            this.Add(new SlotReward(700, "  5 4 6 3 2  4 3 1 5 1  4 6 3 1 3", 200));
            this.Add(new SlotReward(700, "  7 4 1 1 1  3 2 6 7 7  2 3 7 3 5", 200));
            this.Add(new SlotReward(700, "  6 3 5 7 3  2 1 1 5 3  1 7 3 4 6", 200));
            this.Add(new SlotReward(700, "  4 7 3 1 7  3 7 6 3 2  5 7 1 3 1", 200));


            this.Add(new SlotReward(700, "  4 2 2 6 5  5 6 3 3 1  6 5 5 4 4"));
            this.Add(new SlotReward(700, "  6 1 4 6 2  1 7 5 3 6  1 3 6 2 1"));
            this.Add(new SlotReward(700, "  2 3 6 5 6  3 1 6 6 7  5 4 1 6 5"));
            this.Add(new SlotReward(700, "  5 7 2 1 2  5 4 5 2 4  6 5 4 3 4"));
            this.Add(new SlotReward(700, "  1 6 2 4 4  3 5 5 1 4  2 6 6 6 5"));

            this.Add(new SlotReward(800, "  2 5 2 7 4  2 7 6 5 6  1 6 4 6 2"));
            this.Add(new SlotReward(800, "  6 6 6 4 3  7 1 1 2 4  6 5 1 2 6"));
            this.Add(new SlotReward(800, "  6 7 7 3 6  5 4 3 7 6  7 6 2 5 7"));
            this.Add(new SlotReward(800, "  2 4 4 4 7  2 4 7 1 5  3 2 7 3 2"));

            this.Add(new SlotReward(800, "  6 7 3 4 6  4 5 6 3 6  6 7 5 2 3",200));
            this.Add(new SlotReward(800, "  4 6 7 3 3  4 7 2 5 2  7 3 6 5 7", 200));
            this.Add(new SlotReward(800, "   7 5 7 5 3  5 1 3 2 4  1 3 3 7 2", 200));
            this.Add(new SlotReward(800, "   3 2 3 6 6  5 3 5 7 6  2 5 5 3 4", 200));
            this.Add(new SlotReward(800, "   3 1 3 2 1  3 5 7 3 7  1 7 4 7 7", 200));

            this.Add(new SlotReward(800, "  3 4 1 1 3  7 1 1 3 2  4 5 7 2 4", 400));
            this.Add(new SlotReward(800, "  5 4 6 4 1  1 3 4 2 1  3 2 2 7 3", 400));
            this.Add(new SlotReward(800, "  3 7 6 7 3  7 1 3 6 6  6 7 2 4 4", 400));
            this.Add(new SlotReward(800, "  1 3 4 3 3  5 4 7 7 4  6 6 7 1 5", 400));
            this.Add(new SlotReward(800, "  4 5 4 4 2  7 3 3 2 2  4 3 7 6 3", 400));

            this.Add(new SlotReward(800, "  3 3 7 6 3  6 5 6 2 4  7 7 3 7 1", 600));

            this.Add(new SlotReward(800, "  5 3 2 4 3  4 6 2 1 5  3 7 1 5 3"));
            this.Add(new SlotReward(800, "  4 4 1 3 5  7 2 3 1 2  7 5 6 3 3"));
            this.Add(new SlotReward(800, "  6 1 7 4 7  6 4 7 1 3  4 5 3 3 5"));
            this.Add(new SlotReward(800, "  7 4 5 3 7  4 4 3 1 3  6 2 6 5 4"));
            this.Add(new SlotReward(800, "  3 7 3 1 6  6 1 1 3 4  7 3 1 6 2"));
            this.Add(new SlotReward(800, "  6 5 2 7 5  3 4 3 7 2  6 3 4 5 7"));

            this.Add(new SlotReward(800, "  5 3 2 4 3  4 6 2 1 5  3 7 1 5 3",800));
            this.Add(new SlotReward(800, "  4 4 1 3 5  7 2 3 1 2  7 5 6 3 3", 800));
            this.Add(new SlotReward(800, "  6 1 7 4 7  6 4 7 1 3  4 5 3 3 5", 800));
            this.Add(new SlotReward(800, "  7 4 5 3 7  4 4 3 1 3  6 2 6 5 4", 800));
            this.Add(new SlotReward(800, "  3 7 3 1 6  6 1 1 3 4  7 3 1 6 2", 800));
            this.Add(new SlotReward(800, "  6 5 2 7 5  3 4 3 7 2  6 3 4 5 7", 800));

            this.Add(new SlotReward(900, "  4 2 1 1 1  6 6 4 7 3  5 5 2 4 6"));
            this.Add(new SlotReward(900, "  6 5 2 5 6  4 1 1 6 4  7 2 3 5 1"));
            this.Add(new SlotReward(900, "  4 5 7 5 6  7 6 5 2 3  7 4 4 3 5"));
            this.Add(new SlotReward(900, "  5 1 5 3 4  5 6 7 7 4  4 4 5 1 1"));
            this.Add(new SlotReward(900, "  7 4 7 7 2  1 3 4 6 4  6 1 3 1 7"));
            this.Add(new SlotReward(900, "  7 6 6 6 3  4 5 5 4 1  5 1 5 7 6"));
            this.Add(new SlotReward(900, "  2 6 1 7 1  5 5 1 2 5  2 2 6 4 3"));

            this.Add(new SlotReward(900, "  6 4 2 3 4  5 6 5 6 2  7 5 3 6 3",200));
            this.Add(new SlotReward(900, "  4 6 5 6 4  5 2 7 5 3  1 3 3 4 7", 200));
            this.Add(new SlotReward(900, "  1 7 7 3 6  2 1 6 4 3  7 6 3 1 1", 200));

            this.Add(new SlotReward(900, "  1 1 6 5 7  4 3 3 5 3  3 4 6 5 1", 400));
            this.Add(new SlotReward(900, "  3 6 1 3 7  4 1 3 2 4  5 7 3 3 1", 400));
            this.Add(new SlotReward(900, "  5 7 1 7 7  5 5 1 2 1  3 4 3 1 3", 400));
            this.Add(new SlotReward(900, "  2 6 1 1 3  1 3 6 3 2  4 2 5 4 2", 400));

            this.Add(new SlotReward(900, "  4 6 3 5 5  3 6 3 3 4  5 4 3 5 1",600));
            this.Add(new SlotReward(900, "  3 5 5 6 7  4 6 3 3 3  5 6 5 7 3", 600));

            this.Add(new SlotReward(1000, "  2 6 7 6 2  7 1 3 6 2  1 5 4 6 1"));
            this.Add(new SlotReward(1000, "  6 6 3 1 6  5 5 3 4 6  6 1 6 2 7"));
            this.Add(new SlotReward(1000, "  3 4 2 1 4  1 3 6 7 3  7 3 1 4 1"));
            this.Add(new SlotReward(1000, "  7 3 2 1 6  5 1 7 6 4  6 1 6 4 6"));

            this.Add(new SlotReward(1000, "  6 1 4 4 3  5 4 6 4 7  3 4 3 3 2",200));
            this.Add(new SlotReward(1000, "  6 1 3 6 5  7 6 2 3 3  5 4 4 4 1", 200));
            this.Add(new SlotReward(1000, "  5 2 3 4 4  2 7 4 3 7  5 2 5 7 3", 200));
            this.Add(new SlotReward(1000, "  1 2 3 4 4  2 1 4 2 7  5 3 6 3 2", 200));

            this.Add(new SlotReward(1000, "  6 7 6 6 7  2 2 6 6 3  1 3 3 1 3", 400));
            this.Add(new SlotReward(1000, "  7 7 7 7 1  3 7 5 5 3  4 3 1 6 4", 400));
            this.Add(new SlotReward(1000, "  3 3 6 1 3  6 7 7 5 5  1 5 5 4 6", 400));
            this.Add(new SlotReward(1000, "  5 7 7 1 5  5 4 7 5 4  3 3 6 3 2", 400));
            this.Add(new SlotReward(1000, "  3 4 3 6 3  6 5 5 7 6  2 4 2 5 3", 400));

            this.Add(new SlotReward(1000, "  6 4 1 7 3  5 7 6 6 6  3 3 1 5 3", 600));
            this.Add(new SlotReward(1000, "  3 7 7 6 6  6 6 1 4 4  3 3 4 3 7", 600));
            this.Add(new SlotReward(1000, "  3 2 6 7 4  2 1 5 5 3  4 4 3 3 3", 600));

            this.Add(new SlotReward(1000, "  6 4 6 6 5  2 2 3 1 1  2 3 4 2 3", 800));
            this.Add(new SlotReward(1000, "  4 4 6 3 5  7 5 3 6 5  3 6 2 6 1", 800));
            this.Add(new SlotReward(1000, "  5 1 7 7 4  1 3 6 6 7  6 3 3 5 3", 800));

            this.Add(new SlotReward(1000, "  1 2 7 1 3  7 3 6 5 2  3 6 5 4 3", 1000));
            this.Add(new SlotReward(1000, "  2 7 7 2 5  2 4 3 5 4  3 3 6 4 5", 1000));
            this.Add(new SlotReward(1000, "  3 5 1 7 3  2 3 7 1 4  7 1 2 6 7", 1000));
            this.Add(new SlotReward(1000, "  7 3 3 4 1  4 2 6 6 3  2 6 5 3 1", 1000));
            this.Add(new SlotReward(1000, "  3 3 3 2 5  4 3 5 4 1  3 1 2 6 4", 1000));

            this.Add(new SlotReward(1100, "  5 4 6 3 7  3 7 5 5 1  6 4 4 4 1"));
            this.Add(new SlotReward(1100, "  7 4 3 7 6  3 1 4 4 1  5 5 5 6 4"));

            this.Add(new SlotReward(1100, "  4 3 1 1 7  5 4 5 6 5  2 6 1 3 3",200));
            this.Add(new SlotReward(1100, "  3 3 3 4 5  2 1 5 1 5  2 6 6 5 5", 200));
            this.Add(new SlotReward(1100, "  2 5 5 3 4  5 7 2 7 6  3 2 3 5 5", 200));

            this.Add(new SlotReward(1100, "  7 6 3 5 4  5 7 4 3 3  4 5 4 7 3", 400));
            this.Add(new SlotReward(1100, "  1 3 3 2 7  1 3 6 3 7  5 6 1 1 6", 400));

            this.Add(new SlotReward(1100, "  5 6 1 3 1  3 5 3 1 7  6 2 3 1 3", 600));

            this.Add(new SlotReward(1100, "  4 1 3 3 1  5 4 6 3 1  7 5 7 5 3", 800));
            this.Add(new SlotReward(1100, "  5 1 4 5 3  5 6 3 2 7  7 3 1 5 5", 800));
            this.Add(new SlotReward(1100, "  1 7 1 5 5  5 3 3 4 3  5 4 2 7 7", 800));
            this.Add(new SlotReward(1100, "  5 5 5 6 3  3 3 6 4 7  3 2 5 2 3", 800));
            this.Add(new SlotReward(1100, "  2 5 3 2 3  4 6 3 2 5  3 6 3 5 1", 800));

    
            this.Add(new SlotReward(1200, "  5 1 4 1 6  5 5 4 6 6  5 5 2 4 5"));
            this.Add(new SlotReward(1200, "  4 4 5 5 7  3 5 4 2 4  7 5 5 1 6"));
            this.Add(new SlotReward(1200, "  4 2 5 4 4  7 2 3 7 1  4 7 3 1 1"));
            this.Add(new SlotReward(1200, "  5 4 4 7 1  4 1 7 4 3  5 7 6 5 4"));
            this.Add(new SlotReward(1200, "  3 5 5 4 4  6 5 4 1 6  7 6 4 2 3"));
            this.Add(new SlotReward(1200, "  2 3 6 2 6  3 1 4 1 4  1 7 4 6 4"));

            this.Add(new SlotReward(1200, "  1 4 3 6 5  1 1 4 3 7  5 2 1 5 3",200));
            this.Add(new SlotReward(1200, "  3 3 3 4 4  1 7 1 1 4  7 1 7 5 7", 200));
            this.Add(new SlotReward(1200, "  3 1 4 6 3  6 7 1 1 1  6 7 4 3 5", 200));
            this.Add(new SlotReward(1200, "  3 3 7 6 6  3 6 4 2 2  6 1 3 4 4", 200));
            this.Add(new SlotReward(1200, "  3 1 2 7 4  4 1 3 1 5  7 6 6 3 1", 200));

            this.Add(new SlotReward(1200, "  4 6 5 4 6  2 4 4 6 3  3 7 3 2 3", 400));

            this.Add(new SlotReward(1200, "  3 2 6 5 3  3 3 5 2 5  2 3 5 4 7", 600));
            this.Add(new SlotReward(1200, "  1 3 3 6 6  2 3 7 5 2  4 3 4 4 3", 800));
            this.Add(new SlotReward(1200, "  6 3 3 1 3  1 3 6 5 4  2 2 3 5 6", 1000));
            this.Add(new SlotReward(1200, "  5 5 7 4 3  5 3 1 6 2  5 3 3 7 2", 1200));

            this.Add(new SlotReward(1300, "  1 2 5 6 5  5 2 1 7 5  3 4 6 1 6"));
            this.Add(new SlotReward(1300, "  3 7 1 1 1  6 1 6 3 6  6 5 3 7 2",200));
            this.Add(new SlotReward(1300, "  5 1 3 6 5  3 1 6 2 3  1 6 5 6 4", 400));
            this.Add(new SlotReward(1300, "  4 3 2 2 3  1 5 2 5 6  3 1 3 1 6", 800));
            this.Add(new SlotReward(1300, "  6 3 4 4 3  5 3 3 5 6  7 2 5 7 6", 1000));


            this.Add(new SlotReward(1300, "", 200));
            this.Add(new SlotReward(1300, "", 200));
            this.Add(new SlotReward(1300, "", 200));
            this.Add(new SlotReward(1300, "", 200));
            this.Add(new SlotReward(1300, "", 200));





        }
    }
}
