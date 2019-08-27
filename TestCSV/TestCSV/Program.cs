using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TestCSV
{
    class Program
    {
        public static void Main(string[] args)
        {


            string filePath = "‪a.csv";
            Console.WriteLine(filePath);

            StreamReader sr = new StreamReader(filePath, Encoding.Default, false);

            List<FaultItem> faultList = new List<FaultItem>();
            string line = null;
            string[] itemArr = new string[6]; //上一行的数据
            line = sr.ReadLine();
            string[] strArr = line.Split(',');
            FaultItem fistItem = new FaultItem();
            fistItem.No = strArr[0];
            fistItem.problem = strArr[1];
            fistItem.type = strArr[2];
            fistItem.range = strArr[3];
            fistItem.picture = strArr[4];
            fistItem.steps = strArr[5];
            faultList.Add(fistItem);
            for (int i = 0; i < strArr.Length; i++)
            {
                itemArr[i] = strArr[i];
            }





            while((line=sr.ReadLine())!=null)
            {
                FaultItem item = new FaultItem();

                strArr = line.Split(',');

                for (int i = 0; i < itemArr.Length; i++)
                {
                    if (strArr[i].Equals(""))
                    {
                        strArr[i] = itemArr[i];

                    }
                }

                item.No = strArr[0];
                item.problem=strArr[1];
                item.type=strArr[2];
                item.range=strArr[3];
                item.picture=strArr[4];
                item.steps=strArr[5];
                faultList.Add(item);


                for (int i = 0; i < itemArr.Length; i++)
                {
                    itemArr[i] = strArr[i];
                }

            }

            foreach (FaultItem t_Item in faultList)
            {
                Console.WriteLine(t_Item);
            }

            sr.Close();
            Console.ReadLine();

        }
    }

    public class FaultItem
    {
        public string No;
        public string problem;
        public string type;
        public string range;
        public string picture;
        public string steps;
        public override string ToString()
        {
            return this.No + "****" + problem + "****" + type + "****" + range + "****" + picture + "****" + steps;
        }

    }



}
