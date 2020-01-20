// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Net.Http;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents the contents of a file to be uploaded. Must be posted using multipart/form-data in the usual way that files are uploaded via the browser.</summary>
    public sealed class InputFile
    {
        /// <summary>HTTP file content.</summary>
        public StreamContent Content { get; private set; }
        /// <summary>File name.</summary>
        public string Filename { get; private set; }
        /// <summary>New InputFile.</summary>
        /// <param name="streamcontent">HTTP file content.</param>
        /// <param name="filename">File name.</param>
        public InputFile(StreamContent streamcontent, string filename)
        {
            Content = streamcontent;
            Filename = filename;
        }
        /// <summary>New InputFile.</summary>
        /// <param name="streamfile">Stream file.</param>
        /// <param name="filename">File name.</param>
        public InputFile(MemoryStream streamfile, string filename)
        {
            Content = new StreamContent(streamfile);
            Filename = filename;
        }
        /// <summary>New InputFile.</summary>
        /// <param name="file">File.</param>
        /// <param name="filename">File name.</param>
        public InputFile(byte[] file, string filename)
        {
            Content = new StreamContent(new MemoryStream(file));
            Filename = filename;
        }
    }
    [System.AttributeUsage(System.AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    internal sealed class InputFileAttribute : System.Attribute { }
    /// <summary>This object represents a attachfile.</summary>
    public sealed class AttachFile
    {
        internal string Name { get; }
        internal InputFile File { get; }
        /// <summary>New AttachFile</summary>
        /// <param name="name">File attach name.</param>
        /// <param name="inputFile">This object represents the contents of a file to be uploaded.</param>
        public AttachFile(string name, InputFile inputFile)
        {
            Name = name;
            File = inputFile;
        }
    }
    [System.AttributeUsage(System.AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    internal sealed class AttachFileAttribute : System.Attribute
    {
        public string PropertyName { get; }
        public bool IsArray { get; }
        public AttachFileAttribute(string propertyName)
        {
            PropertyName = propertyName;
            IsArray = false;
        }
        public AttachFileAttribute(string propertyName, bool isArray)
        {
            PropertyName = propertyName;
            IsArray = isArray;
        }
    }
}
