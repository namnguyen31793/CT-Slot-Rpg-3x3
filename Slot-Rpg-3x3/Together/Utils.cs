using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSlotMachine.Together
{
    public class Utils
    {
        //co 3 item
        public static int LENGTH_ID_ITEM_NORMAL = 3;
        //co 2 item hệ số
        public static int LENGTH_ID_ITEM_CALCULATION = 2;
        public static int LENGTH_MATIRX = 9;
        public static int NUM_COLUMN_MATRIX = 3;
        public static int NUMBER_LINE = 1;

        public static int ID_ITEM_WILL = 11;
        public static int ID_ITEM_DAMAGE = 1;
        public static int ID_ITEM_DEF = 2;
        public static int ID_ITEM_HEALTH = 3;


        public static string GetStringMatrix(List<int> matrix) {
            string matrixString = "";
            for (int i = 0; i < matrix.Count; i++) {
                if (i == matrix.Count - 1) {
                    matrixString += matrix[i];
                } else {
                    matrixString += matrix[i]+",";
                }
            }
            return matrixString;
        }

        public static string GetStringFreeResult(List<ResultItem> listData) {
            string returnString = "";
            for (int i = 0; i < listData.Count; i++) {
                if (i == listData.Count - 1) {
                    returnString += listData[i].GetString();
                } else {
                    returnString += listData[i].GetString() + ";";
                }
            }
            return returnString;
        }

        public static string GetStringLineId(List<PrizeLine> listData) {
            string returnString = "";
            for (int i = 0; i < listData.Count; i++) {
                if (i == listData.Count - 1) {
                    returnString += listData[i].LineID;
                } else {
                    returnString += listData[i].LineID + ",";
                }
            }
            return returnString;
        }
    }

    public enum TYPE_CALCULATION : int {
        NONE = 0,
        SUM = 10,
        MULTI = 11,
    }
}
