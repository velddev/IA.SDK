namespace IA.SDK.Interfaces
{
    public interface IEmbedField
    {
        string Name { get; }
        string Value { get; }

        bool IsInline { get; }
    }
}