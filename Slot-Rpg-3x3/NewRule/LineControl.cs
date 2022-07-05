using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSlotMachine.NewRule
{
    public class LineControl
    {

        static Dictionary<int, List<int>> dictionaryLineWin = new Dictionary<int, List<int>>(){
            { 1, new List<int>(){ 1, 2, 3, 4, 5}},
        };

        public static List<int> GetLineByMatrix(int lineId, List<int> matrix, out List<int> listCheck)
        {
            List<int> listPos = new List<int>();
            listCheck = new List<int>();
            if (dictionaryLineWin.TryGetValue(lineId, out listPos))
            {
                if (listPos.Count > 0)
                {
                    for (int i = 0; i < listPos.Count; i++) {
                        listCheck.Add(matrix[listPos[i] - 1]);
                    }
                    return listPos;
                }
                else
                {
                return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
