namespace JanKenPo
{
    internal struct Rock : IShape
    {
        public int CompareTo(IShape? other)
        {
            return other switch
            {
                Rock => 0,
                Paper => 1,
                Scissors => -1,
                _ => throw new ApplicationException("Ops! Something go wrong. Sorry.")
            };
        }
    }
}
