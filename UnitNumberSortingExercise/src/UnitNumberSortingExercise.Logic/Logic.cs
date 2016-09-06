using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitNumberSortingExercise.Logic
{
    public static class Logic
    {
        public static string Sort(string input)
        {
            var list = input.Split('\n');

            var units = list.Where(r => r != String.Empty)
                            .ToList()
                            .Select(r => new UnitNumber(r));

            var sb = new StringBuilder();
            units.OrderBy(r => r.RoomNumber)
                .ThenBy(r => r.Letter)
                .ToList()
                .ForEach(r => {
                    sb.Append(r.ToString());
                    sb.Append("\n");
                });
            return sb.ToString();
        }
    }
}
