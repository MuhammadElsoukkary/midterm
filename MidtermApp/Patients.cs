using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MidtermApp
{
    public class Patients
    {
        // consant that manges the max age for a child
        public static readonly int MaxAge = 13;
        public Patients(int age,string fullName,string recordNumber)
        {
            // store in provate data fields:
            _age = age;
            _fullName = fullName;
            _recordNumber = recordNumber;

            string errMsg = "";
            // if statments for error handling 
            // checks if a record number was inputted
            if (recordNumber.Length == 0)
            {
                errMsg += "No record number was entred \n";
            }
            // checks if a something was entred for full name
            if (fullName.Length == 0)
            {
                errMsg += "No name was entred \n";
            }
            // checks the age entered 

            if (age > 120 || age < 0)
            {
                errMsg += "Invalid age entered\n";
            }

            // checks if record is a match and if it is not displays an error message
            if (!recordCheck.IsMatch(_recordNumber))
            {
                errMsg += "Invalid record number pattern; must be in 2 letters and 5 numbers with no 0 at start eg: AB-12345\n";
            }
            // throws an exception when issues occur
            if (errMsg != "")
            {
                throw new InvalidDataException(errMsg);
            }
           
         
            

           
        }
        // returns the vars used
        public int age
        {

            get
            {
                return _age;
            }
        }

        

        public string fullName
        {
            get
            {
                
                return _fullName;
            }
        }

        public string recordNumber
        {
            get
            {
                return _recordNumber;
            }
        }
        // formats string and allows for display of string when form is used
        public override string ToString()
        {
            return $" {fullName.ToUpper()}; Number recorded: ({recordNumber.ToUpper()}): Age {age}";
        }

        // And then the private (instance) data fields for each pateeint record object
        private int _age;

        private string  _fullName;

        private string _recordNumber;

        // regex pattren that helps with checking if user entered a correct pateint number
        private static Regex recordCheck = new Regex(@"^[A-Z]{2}[ -]?\d{5}$");

        

    }
}
