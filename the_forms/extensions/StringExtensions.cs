using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFood.extensions
{
    public static class StringExtensions
    {

        public static int extractCaloryValue(this string naehrwerteText)
        {
            const int DEFAULT_ERROR_VALUE = 0;
            if (string.IsNullOrEmpty(naehrwerteText))
            {
                return DEFAULT_ERROR_VALUE;
            }

            try

            {
                //Example : 'Calories: 200, Carbs: 40g, Protein: 5g, Fat: 2g'
                naehrwerteText = naehrwerteText.Trim();

                //[Calories: 200, Carbs: 40g, Protein: 5g, Fat: 2g]
                string[] naehrwerte = naehrwerteText.Split(',');

                //Calories: 200
                string caloryText = naehrwerte[0].Trim();

                //"200"
                string caloryValueStr = caloryText.Split(':')[1].Trim();

                return Convert.ToInt32(caloryValueStr);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return DEFAULT_ERROR_VALUE;
            }



        }
    }
}
