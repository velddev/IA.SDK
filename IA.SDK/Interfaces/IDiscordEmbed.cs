using System;

namespace IA.SDK.Interfaces
{
    public interface IDiscordEmbed
    {
        IEmbedAuthor Author { get; }

        Color Color { get; set; }

        string Description { get; set; }

        IEmbedFooter Footer { get; set; }

        string ImageUrl { get; set; }

        string Title { get; set; }

        string Url { get; set; }

        IDiscordEmbed AddField(Action<IEmbedField> field);
    }
}