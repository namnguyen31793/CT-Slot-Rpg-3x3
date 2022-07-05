using NewSlotMachine.Together;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRandom;

namespace NewSlotMachine.NewRule
{
    public class MatrixControl
    {
        //matrix pos
        //  1    2    3  

        public static List<int> RandomMatrixNormal()
        {
            List<int> listItem = new List<int>();

            //random 3 item
            for (int i = 0; i < Utils.LENGTH_MATIRX; i++)
            {
                int id = RandomHelper.NextInt(Utils.LENGTH_ID_ITEM_NORMAL) + 1;
                listItem.Add(id);
            }
            return listItem;
        }

    }
}
