using NewSlotMachine.NewRule;
using NewSlotMachine.Together;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NewSlotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Rule testGen = new Rule();
            var t = Task.Run(() => testGen.GenAsync());
            t.Wait();
            //List<ResultItem> resultJackpot;
            //List<ResultItem> resultList = testGen.Test(out resultJackpot);

            //Console.WriteLine("+++++++++++++++List data:");
            //for (int i = 0; i < resultList.Count; i++)
            //{
            //    ResultItem test = resultList[i];
            //    Console.WriteLine(resultList[i].Matrix + "------- \t" + resultList[i].ValueWinLine + "------- \t" + resultList[i].LineWinString + "\t" + resultList[i].Total + "\t" + resultList[i].Jackpot);
            //}
            //Console.WriteLine("");
            //Console.WriteLine("+++++++++++++++List Jackpot:");
            //for (int i = 0; i < resultJackpot.Count; i++)
            //{
            //    Console.WriteLine(resultJackpot[i].Matrix + "\t" + resultJackpot[i].ValueWinLine + "\t" + resultJackpot[i].Total + "\t" + resultJackpot[i].Jackpot);
            //}
            Console.ReadKey();
        }
    }
}
