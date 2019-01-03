using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace importer
{
    class InjectionHelpers
    {
        /*
        DataTable crashTable = new DataTable();
        DataColumn county = crashTable.Columns.Add("county", typeof(String));
        DataColumn crashYear = crashTable.Columns.Add("crashYear", typeof(int));
        DataColumn month = crashTable.Columns.Add("month", typeof(int));
        DataColumn hour = crashTable.Columns.Add("hour", typeof(int));
        DataColumn numVehicle = crashTable.Columns.Add("numVehicle", typeof(int));
        DataColumn crashSeverity = crashTable.Columns.Add("crashSeverity", typeof(int));
        DataColumn noSeatbelt = crashTable.Columns.Add("noSeatbelt", typeof(int));
        DataColumn truckInvolved = crashTable.Columns.Add("truckInvolved", typeof(int));
        DataColumn speeding = crashTable.Columns.Add("speeding", typeof(int));
        DataColumn failedToYeild = crashTable.Columns.Add("failedToYeild", typeof(int));
        DataColumn snowOrSleet = crashTable.Columns.Add("snowOrSleet", typeof(int));
        DataColumn rollover = crashTable.Columns.Add("rollover", typeof(int));
        DataColumn intersection = crashTable.Columns.Add("intersection", typeof(int));
        DataColumn curve = crashTable.Columns.Add("curve", typeof(int));
        DataColumn hill = crashTable.Columns.Add("hill", typeof(int));
        DataColumn laneDeparture = crashTable.Columns.Add("laneDeparture", typeof(int));
        DataColumn point = crashTable.Columns.Add("point", typeof(double));
        */






        /*
         * Method that reads in csv file.
         */
        public DataTable CsvReader(string fileName)
        {
            DataTable crashTable = new DataTable();
            crashTable.Clear();
            using (var sr = new StreamReader(new FileStream(fileName, FileMode.Open)))
            {
                
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    crashTable.Columns.Add(header);
                    Console.WriteLine(header.ToString());
                }

                while (!sr.EndOfStream)
                {
                    String[] rows = sr.ReadLine().Split(',');
                    for (int i = 0; i < headers.Length; i++)
                    {
                        crashTable.Rows.Add(rows[i]);
                    }



                }

            }
            Console.WriteLine(crashTable.Columns.Count);
            Console.WriteLine(crashTable.Rows.Count);

            return crashTable;
        }

        /*
         * Method to convert all the string values in the lists that are suppose
         * to be int into int.
         */

        /*
         * Convert lat and lon to double.
         */


        /*
         * Method that takes columns 1,2, and 3 from the csv file and 
         * puts them together as a data and time field.
         */

        /*
         * Method that takes columns 5 and 6 and determines what value 
         * 5 is going to be based on column 6. 
         * 0 = minor injury
         * 1 = serious injury
         * 2 = fatal
         */

        /*
         * Method that takes columns 18 and 19 from the csv file 
         * and puts them together as a sys.geography lat and long point.
         */
    }
}