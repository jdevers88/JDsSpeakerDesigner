using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Model
{
    public class Driver
    {
        public string Brand { get;set;}
        public string Model {get; set;}
        public double Vas { get; set; }
        public double Qts { get; set; }
        public double Fs { get; set; }
        public double Sd { get; set; }
        public double Xmax { get; set; }
        public double Qes { get; set; }
        public string Filename { get; set; }

        public static Driver Load(string pFileName)
        {
            Driver lDriver = new Driver(pFileName );

            return lDriver;
        }

        public static DriverSaveResult Save(string pFileName, Driver pDriver)
        { 

            try
            {
               // pDriver.SaveDriver();

                return DriverSaveResult.Success;
            }
            catch 
            {
                return DriverSaveResult.Fail;
            }

        }

       
        public Driver(string pFileName)
        {
            string lsDriver = File.ReadAllText(pFileName );

            Brand = getKeyValue("Brand", lsDriver);
            Model = getKeyValue("Model", lsDriver);
            Vas = double.Parse(getKeyValue("Vas", lsDriver)) * 1000;
            Qts = double.Parse(getKeyValue("Qts", lsDriver));
            Fs = double.Parse(getKeyValue("Fs", lsDriver));
            Sd = double.Parse(getKeyValue("Sd", lsDriver)) * 10000;
            Qes = double.Parse(getKeyValue("Qes", lsDriver));
            Xmax = double.Parse(getKeyValue("Xmax", lsDriver)) * 1000;
        }

        public string getKeyValue(string key, string FileText)
        {
            String lString = FileText.Substring(FileText.IndexOf(key) + key.Length + 1);
            lString = lString.Substring(0, lString.IndexOf('\n'));

            return lString;
        }
    }
     public enum DriverSaveResult
        { 
            Success,
            Fail
        }
}
