namespace JanKenPo
{
    internal interface IShape : IComparable<IShape>
    {
        
    }

    public struct None : IShape
    {
        int IComparable<IShape>.CompareTo(IShape? other)
        {
            throw new NotImplementedException();
        }
    }
}
