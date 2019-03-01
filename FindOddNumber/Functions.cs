using System.Linq;

namespace FindOddNumber
{
    public class Functions
    {
        public static int FinOddNumber(int[] array)
        {
            var retval = 0;
            var itemGroups = array.ToList().GroupBy(g => g);
            foreach (var item in itemGroups)
            {
                if (item.Count() % 2 != 0)
                    retval = item.Key;
            }
            return retval;
        }
    }
}
