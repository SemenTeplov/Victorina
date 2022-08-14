using System;
using System.IO;
using System.Collections.Generic;

namespace Victorina
{
    class TableResults
    {
        public TableResults() 
        {
            arrStr = File.ReadAllLines(@"Results.txt");
            results = new List<Result>();
            ind = 0;

            foreach (var text in arrStr)
            {
                string[] str = text.Split(" ");
                result = new Result(str[0], str[1]);
                results.Add(result);
            }
        }

        public void GetList()
        {
            foreach (var r in results)
            {
                Console.WriteLine(r.getLogin() + " " + r.getPoint());
            }
        }
        public void GetList(int num)
        {
            if (results.Count < num)
            {
                GetList();
            }
            else
            {
                for (int elem = 0; elem < num; elem++)
                {
                    Console.WriteLine(results[elem].getLogin() +
                        " " + results[elem].getPoint());
                }
            }
        }
        public void SaveResult(Result resUser)
        {
            result = new Result(resUser.getLogin(), resUser.getPoint());

            for (int elem = 0; elem < results.Count; elem++)
            {
                if (Convert.ToInt32(results[elem].getPoint()) <=
                    Convert.ToInt32(result.getPoint()))
                {
                    ind = elem;
                }
                if (results[elem].getLogin() == result.getLogin())
                {
                    results.Remove(results[elem]);
                }
            }

            results.Insert(ind, resUser);
            arrStr = new string[results.Count];

            for (int elem = 0; elem < results.Count; elem++)
            {
                arrStr[elem] = results[elem].getLogin() + " " 
                    + results[elem].getPoint();
            }

            File.WriteAllLines(@"Results.txt", arrStr);
        }

        private string[] arrStr;
        private List<Result> results;
        private Result result;
        private int ind;
    }
}
