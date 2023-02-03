using Pyrus.BLL;

namespace Pyrus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPyrusTester pyrusTester = new PyrusTester();
            Demo(pyrusTester);
        }

        static private void Demo(IPyrusTester pyrusTester)
        {
            var arr = new int[] { 1, 2, 5, 3, 3, 2 };
            Console.Write("arr: ");
            ShowList(arr);
            var distinctArr = pyrusTester.Distinct(arr);
            Console.Write("distinctArr: ");
            ShowList(distinctArr);

            var lastCount = 3;
            Console.Write($"filterLastArr {lastCount}: ");
            var newArr = pyrusTester.FilterLast(arr, lastCount);
            ShowList(newArr);
        }

        static private void ShowList(IEnumerable<int> list)
        {
            var arr = list.ToArray();
            Console.Write('[');
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i != arr.Length - 1)
                    Console.Write(',');
            }

            Console.WriteLine(']');
        }
    }
}