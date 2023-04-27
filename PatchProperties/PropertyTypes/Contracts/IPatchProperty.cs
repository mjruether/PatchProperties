namespace PatchProperties.PropertyTypes.Contracts
{
    public interface IPatchProperty<T>
    {
        T Value { get; set; }
    }
}
