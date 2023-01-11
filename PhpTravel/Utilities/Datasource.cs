using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhpTravel.Utilities
{
    public class Datasource
    {
        public static object[] ValidBookingData()
        {

            string[] dataset1 = new string[3];
            dataset1[0] = "pune";
            dataset1[1] = "bangalore";
            dataset1[2] = "11-01-2023";

            string[] dataset2 = new string[3];
            dataset2[0] = "mumbai";
            dataset2[1] = "delhi";
            dataset2[2] = "12-01-2023";

            string[] dataset3 = new string[3];
            dataset3[0] = "belguam";
            dataset3[1] = "jaipuir";
            dataset3[2] = "13-01-2023";



            object[] alldataset = new object[3];//no of testcase

            alldataset[0] = dataset1;
            alldataset[1] = dataset2;
            alldataset[2] = dataset3;

            return alldataset;
        }



        public static object[] BookingValidData()
        {
             object[] data = ExcelUtil.GetSheetIntoObjectArray
                 (@"C:\Users\patilbs\Desktop\C#\AutomationPhpTravel\PhpTravel\TestData\Php_Data.xlsx"
                    , "BookingValidData");
           return data;
        }

        //public static object[] BookingInValidData()
        //{
        //    object[] data = ExcelUtil.GetSheetIntoObjectArray
        //        (@"C:\Users\patilbs\Desktop\C#\AutomationPhpTravel\PhpTravel\TestData\Php_Data.xlsx"
        //           , "BookingInValidData");
        //    return data;
        //}


    }
}
