namespace Pyrus.BLL
{
    public class PyrusTester : IPyrusTester
    {
        public int[] Distinct(int[] src)
        {
            var distinctValues = new List<int>();

            for (var i = 0; i < src.Length; i++)
            {
                if (!distinctValues.Contains(src[i]))
                    distinctValues.Add(src[i]);
            }
            return distinctValues.ToArray();
        }

        public IEnumerable<T> FilterLast<T>(IEnumerable<T> source, Int32 n)
        {
            var queue = new LinkedList<T>(source);

            for (var i = 0; i < n; i++)
            {
                queue.RemoveLast();
            }

            return queue;
        }
    }
}
