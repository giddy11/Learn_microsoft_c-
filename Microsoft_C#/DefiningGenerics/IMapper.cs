namespace DefiningGenerics
{
    public interface IMapper<S, T>
    {
        T Map(S source);
    }
}
