// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI
{
    /// <summary><b>Formatting options</b><br/>
    /// The Bot API supports basic formatting for messages.You can use bold and italic text, as well as inline links and pre-formatted code in your bots' messages. Telegram clients will render them accordingly. You can use either markdown-style or HTML-style formatting.</summary>
    public static class ParseMode
    {
        /// <summary>To use this mode, pass Markdown in the parse_mode field. Use the following syntax in your message:
        /// <para>*bold text* <br/>
        /// _italic text_<br/>
        /// [inline URL](http://www.example.com/)<br/>
        /// [inline mention of a user] (tg://user?id=123456789)<br/>
        /// `inline fixed-width code`<br/>
        /// ```block_language<br/>
        /// pre - formatted fixed-width code block<br/>
        /// ```</para></summary>
        public static string Markdown => "Markdown";
        /// <summary>To use this mode, pass HTML in the parse_mode field. The following tags are currently supported:
        /// <para>
        /// &lt;b&gt;bold&lt;/b&gt;, &lt;strong&gt;bold&lt;/strong&gt; <br/>
        /// &lt;i&gt;italic&lt;/i&gt;, &lt;em&gt;italic&lt;/em&gt; <br/>
        /// &lt;a href = "http://www.example.com/" &gt; inline URL&lt;/a&gt; <br/>
        /// &lt;a href = "tg://user?id=123456789" &gt; inline mention of a user&lt;/a&gt; <br/>
        /// &lt;code&gt;inline fixed-width code &lt;/ code &gt; <br/>
        /// &lt;pre &gt; pre - formatted fixed-width code block &lt;/ pre &gt;
        /// </para>
        /// <para>Please note:</para>
        /// <para>Only the tags mentioned above are currently supported. <br/>
        /// Tags must not be nested. <br/>
        /// All&lt;,&gt; and &amp; symbols that are not a part of a tag or an HTML entity must be replaced with the corresponding HTML entities (&lt; with &amp;lt;, &gt; with &amp;gt; and &amp; with &amp;amp;). <br/>
        /// All numerical HTML entities are supported. <br/>
        /// The API currently supports only the following named HTML entities: &amp;lt;, &amp;gt;, &amp;amp; and &amp;quot;.</para>
        /// </summary>
        public static string HTML => "HTML";
    }
}
