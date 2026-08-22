using System;
using System.IO;

namespace Aspose.Cells.Cloud;

/// <summary>
/// Describes a file to attach to a multipart/form-data request. The content may come from a local
/// file path, an in-memory stream, or raw bytes. A plain <see cref="string"/> local path converts
/// implicitly to a <see cref="FileParameter"/>, so callers can keep passing path strings directly.
/// </summary>
public sealed class FileParameter
{
    /// <summary>The file name sent to the server (used as the multipart file name).</summary>
    public string FileName { get; }

    /// <summary>Local file path, when the content is read from disk.</summary>
    public string? LocalPath { get; }

    /// <summary>Content stream, when supplied by the caller.</summary>
    public Stream? Stream { get; }

    /// <summary>Content bytes, when supplied as an in-memory buffer.</summary>
    public byte[]? Bytes { get; }

    /// <summary>Optional MIME content type for the part.</summary>
    public string? ContentType { get; }

    private FileParameter(string fileName, string? localPath, Stream? stream, byte[]? bytes, string? contentType)
    {
        FileName = fileName;
        LocalPath = localPath;
        Stream = stream;
        Bytes = bytes;
        ContentType = contentType;
    }

    /// <summary>Creates a parameter backed by a local file path.</summary>
    public static FileParameter FromPath(string localPath, string? contentType = null)
    {
        if (string.IsNullOrEmpty(localPath))
        {
            throw new ArgumentException("localPath is required", nameof(localPath));
        }

        return new FileParameter(Path.GetFileName(localPath), localPath, null, null, contentType);
    }

    /// <summary>Creates a parameter backed by an in-memory stream.</summary>
    public static FileParameter FromStream(Stream stream, string fileName, string? contentType = null)
    {
        if (stream is null)
        {
            throw new ArgumentNullException(nameof(stream));
        }

        if (string.IsNullOrEmpty(fileName))
        {
            throw new ArgumentException("fileName is required", nameof(fileName));
        }

        return new FileParameter(fileName, null, stream, null, contentType);
    }

    /// <summary>Creates a parameter backed by raw bytes.</summary>
    public static FileParameter FromBytes(byte[] bytes, string fileName, string? contentType = null)
    {
        if (bytes is null)
        {
            throw new ArgumentNullException(nameof(bytes));
        }

        if (string.IsNullOrEmpty(fileName))
        {
            throw new ArgumentException("fileName is required", nameof(fileName));
        }

        return new FileParameter(fileName, null, null, bytes, contentType);
    }

    /// <summary>Implicitly converts a local file path into a <see cref="FileParameter"/>.</summary>
    public static implicit operator FileParameter(string localPath) => FromPath(localPath);
}
