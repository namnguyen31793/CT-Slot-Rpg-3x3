using NewSlotMachine.Model;
using NewSlotMachine.Together;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRandom;

namespace NewSlotMachine.NewRule
{
    public class RewardControl
    {
        //id loại
        //1-jackpot,2-will,3-bonus,4-free,5,6,7,8,9,10,11
        // tinh theo item dau tien trong dong
        //will thay the cac item tru ca item dac biet jackpot, bonus, free

        static int[] reward_ID_Damage = { 10, 25, 50 };
        static int[] reward_ID_Def = { 6, 15, 30 };
        static int[] reward_ID_Heal = { 6, 15, 30 };
        static int[] reward_ID_Damage_Small = { 5, 10, 20 };
        static int[] reward_ID_Def_Small = { 3, 6, 12 };
        static int[] reward_ID_Heal_Small = { 3, 6, 12 };

        public static List<PrizeLine> GetLineReward(List<int> matrix, out List<RewardModel> listTypeResult)
        {
            listTypeResult = new List<RewardModel>();
            List<PrizeLine> listModel = new List<PrizeLine>();
            List<ModelCheckCount> listCountItem = new List<ModelCheckCount>();

            /*Check cac to hop an*/
            for (int i = 1; i <= Utils.LENGTH_ID_ITEM_NORMAL; i++)
            {
                int idFirstItem = i;
                int countItem = 0;
                //check hang giua
                for (int j = 3; j < 6; j++)
                {
                    if (idFirstItem == matrix[j])
                    {
                        countItem += 1;
                    }
                }
                listCountItem.Add(new ModelCheckCount() { id = idFirstItem, count = countItem });
            }

            for (int i = 0; i < listCountItem.Count; i++)
            {
                if (listCountItem[i].count > 0)
                {
                    int multiValue = GetMuitlValue(listCountItem[i].id, listCountItem[i].count);
                    List<int> Items = listCountItem[i].Items;
                    int point = 0;
                    if (listCountItem[i].id <= 3)
                    {
                        point = 2;
                    }
                    else {
                        point = 1;
                    }

                    if (listCountItem[i].id == Utils.ID_ITEM_DAMAGE || listCountItem[i].id == Utils.ID_ITEM_DAMAGE_SMALL)
                    {
                        listTypeResult.Add(new RewardModel(TYPE_RESULT.DAMAGE, multiValue, point));
                    }
                    if (listCountItem[i].id == Utils.ID_ITEM_DEF || listCountItem[i].id == Utils.ID_ITEM_DEF_SMALL)
                    {
                        listTypeResult.Add(new RewardModel(TYPE_RESULT.DEF, multiValue, point));
                    }
                    if (listCountItem[i].id == Utils.ID_ITEM_HEALTH || listCountItem[i].id == Utils.ID_ITEM_HEALTH_SMALL)
                    {
                        listTypeResult.Add(new RewardModel(TYPE_RESULT.HEAL, multiValue, point));
                    }
                    listModel.Add(new PrizeLine(0, multiValue, Items));
                }
            }

            return listModel;
        }

        public static List<ModelCheckCount> RecursionMatrix(StartItemCheck startItem, List<int> matrix, List<int> listPos, int colum, out bool isMatch)
        {
            List<ModelCheckCount> listCountItem = new List<ModelCheckCount>();
            /* bien check xem co to hop duoc khong thi luot truoc to hop ket qua lai*/
            isMatch = false;
            int numberRowMax = 1;
            for (int i = 0; i < numberRowMax; i++)
            {
                StartItemCheck tempStartItem = new StartItemCheck() { idFirstItem = startItem.idFirstItem, idMatch = startItem.idMatch };
                int pos = (colum - 1) + (numberRowMax - (i + 1)) * Utils.NUM_COLUMN_MATRIX;
                int id = matrix[pos];
                if (tempStartItem.idMatch == -1)
                {
                    //if (id == Utils.ID_ITEM_JACKPOT || id == Utils.ID_ITEM_FREE)
                    //    continue;
                    //check cot 2, neu wild thi 3 giai wild 
                    if (colum == 2)
                    {
                        if (id != Utils.ID_ITEM_WILL)
                            tempStartItem.idMatch = id;
                    }
                    else
                    {
                        tempStartItem.idMatch = id;
                    }
                }
                //id startItem.idMatch == -1 thi la cot 2, dang item wild 
                if (tempStartItem.idMatch == id
                    || (tempStartItem.idMatch == -1))
                {
                    List<int> listPosNew = new List<int>();
                    listPosNew.AddRange(listPos);
                    listPosNew.Add(pos + 1);
                    isMatch = true;
                    /* neu khong phai cot cuoi cung thi de quy tiep*/
                    if (colum < Utils.NUM_COLUMN_MATRIX)
                    {
                        listCountItem.AddRange(RecursionMatrix(tempStartItem, matrix, listPosNew, colum + 1, out isMatch));
                        if (!isMatch)
                        {
                            isMatch = true;
                            listCountItem.Add(new ModelCheckCount { id = tempStartItem.idMatch, count = colum, Items = listPosNew });
                        }
                    }
                    /* neu la cot cuoi cung thi add model*/
                    else
                    {
                        listCountItem.Add(new ModelCheckCount { id = tempStartItem.idMatch, count = Utils.NUM_COLUMN_MATRIX, Items = listPosNew });
                        continue;
                    }
                }
                /* neu khong cung thi check vong for tiep theo va add item*/
                else
                {
                    continue;
                }
            }
            return listCountItem;
        }

        static int GetMuitlValue(int idItemCheck, int count)
        {
            switch (idItemCheck)
            {
                case 1:
                    return reward_ID_Damage[count - 1];
                case 2:
                    return reward_ID_Def[count - 1];
                case 3:
                    return reward_ID_Heal[count - 1];
                case 4:
                    return reward_ID_Damage_Small[count - 1];
                case 5:
                    return reward_ID_Def_Small[count - 1];
                case 6:
                    return reward_ID_Heal_Small[count - 1];
                default:
                    return 0;
            }
        }
    }

    public class ModelCheckCount
    {
        public int id;
        public int count;
        public List<int> Items;
    }
    public class StartItemCheck
    {
        public int idFirstItem;
        public int idMatch;
    }
    public class RPGModel
    {
        public int DA;//damage 
        public int DF;//def
        public int HE;//heal
        public int PDA;//point damage 
        public int PDF;//point def
        public int PHE;//point heal
    }
}
