namespace Meru.SDK
{
    public interface IProxy<T>
    {
        T ToNativeObject();
    }
}