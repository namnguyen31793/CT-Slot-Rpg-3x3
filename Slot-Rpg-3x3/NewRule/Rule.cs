
using NewSlotMachine.Model;
using NewSlotMachine.Together;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRandom;

namespace NewSlotMachine.NewRule
{
   public class Rule
    {

        public async Task GenAsync()
        {
            Console.WriteLine("Start : " + DateTime.Now);
            List<ResultItem> resultList = new List<ResultItem>();
            for (int j = 0; j < 1000; j++)
            {
                var result = await Task.Run(() => GenResult());
                if (result != null)
                    resultList.Add(result);
            }
            Console.WriteLine("End : " + DateTime.Now);

            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i].NumberFreeSpin > 0)
                {
                    var result = resultList[i];
                    Console.WriteLine("Total Avg  :" + resultList.Average(x => x.Total));
                }
            }
        }
        private ResultItem GenResult()
        {
            List<int> matrix = MatrixControl.RandomMatrixNormal();
            ResultItem result = null;
            if (matrix != null)
            {
                result = CheckResultMatrix(matrix);
            }
            return result;
        }


        private ResultItem CheckResultMatrix(List<int> matrix)
        {
            List<PrizeLine> LineWin = new List<PrizeLine>();
            int total = 0;
            int totalDamage = 0;
            int totalDef = 0;
            int totalHealth = 0;
            int totalValueWinLine = 0;
            long totalValueBonus = 0;
            int totalNumFree = 0;
            int totalNumberJP = 0;
            long totalValueFreeSpin = 0;
            List<ResultItem> listModelFreeSpin = new List<ResultItem>();

            for (int i = 0; i < Utils.NUMBER_LINE; i++) {
                List<RewardModel> typeResult;
                List<PrizeLine> prizeLine = RewardControl.GetLineReward(matrix, out typeResult);
                //check list reward tra ve cac type gi
                if (prizeLine.Count > 0) {
                    foreach(var line in prizeLine)
                        LineWin.Add(line);
                    foreach (var result in typeResult) {
                        if (result.type == TYPE_RESULT.MISS) {
                            
                        }else if (result.type == TYPE_RESULT.HEAL) {
                            totalHealth += result.multiValue;
                        }else if (result.type == TYPE_RESULT.DEF) {
                            totalDef += result.multiValue;
                        }else if (result.type == TYPE_RESULT.DAMAGE) {
                            totalDamage += result.multiValue;
                        }
                    }
                }
            }
            RPGModel damage = new RPGModel() { DA = totalDamage, DF = totalDef, HE = totalHealth};

            string LineWinString = "";// Utils.GetStringLineId(LineWin);
            string StringExtend = JsonConvert.SerializeObject(damage);
            string ModelFreeString = "";// Utils.GetStringFreeResult(listModelFreeSpin);
            return new ResultItem(Utils.GetStringMatrix(matrix), LineWinString, totalValueWinLine, totalValueBonus, totalNumFree, totalValueFreeSpin, total, totalNumberJP, StringExtend, ModelFreeString);     
        }

    }
}
