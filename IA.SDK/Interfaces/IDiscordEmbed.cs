using System;
using System.Drawing;

namespace IA.SDK.Interfaces
{
    public interface IDiscordEmbedBuilder
    {
        IEmbedAuthor Author { get; }
        Color Color { get; set; }
        string Description { get; set; }
        IEmbedFooter Footer { get; set; }
        string Title { get; set; }
        string Url { get; set; }

        IDiscordEmbedBuilder AddField(Action<IEmbedField> field);
    }
}