namespace JanKenPo
{
    internal struct Scissors : IShape
    {
        public readonly int CompareTo(IShape? other)
        {
            return other switch
            {
                Rock => 1,
                Paper => -1,
                Scissors => 0,
                _ => throw new ApplicationException("Ops! Something go wrong. Sorry.")
            };
        }
    }
}
