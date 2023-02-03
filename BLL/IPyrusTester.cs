namespace Pyrus.BLL
{
    public interface IPyrusTester
    {
        public int[] Distinct(int[] src);

        public IEnumerable<T> FilterLast<T>(IEnumerable<T> source, Int32 n);
    }
}
