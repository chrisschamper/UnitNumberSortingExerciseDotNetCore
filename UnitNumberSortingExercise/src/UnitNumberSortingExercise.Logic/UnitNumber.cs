using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitNumberSortingExercise.Logic
{
    public class UnitNumber
    {
        //match on numbers
        //followed by possible letters
        //then white space using positive lookahead
        public int RoomNumber { get { return Convert.ToInt32(Regex.Match(_initialString, @"\d+(?=.*\s)").Value); } }

        //match on a positive lookahead number
        //followed by letters
        //followed by a work break
        //followed by positive lookahead white space
        public string Letter { get { return Regex.Match(_initialString, @"(?<=\d)[A-Za-z]+\b(?=\s)").Value; } } 

        private string _initialString = String.Empty;

        public UnitNumber(string input)
        {
            _initialString = input;
        }

        public override string ToString()
        {
            return _initialString;
        }
    }
}
