namespace JanKenPo
{
    internal struct Paper : IShape
    {
        public int CompareTo(IShape? other)
        {
            return other switch
            {
                Rock => -1,
                Paper => 0,
                Scissors => 1,
                _ => throw new ApplicationException("Ops! Something go wrong. Sorry.")
            };
        }
    }
}
