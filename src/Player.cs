namespace JanKenPo
{
    internal class Player
    {
        private readonly Random _random = new();
        private readonly IShape[] _shapes = [new Rock(), new Paper(), new Scissors()];

        public IShape Play() =>
            _shapes[_random.Next(0, _shapes.Length - 1)];

        public int CheckResult(IShape left, IShape right) =>
            left.CompareTo(right);
    }
}
