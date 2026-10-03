using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsCertificatesUploadResponseRowsItemFormat.PostV1DeclarationsCertificatesUploadResponseRowsItemFormatSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsCertificatesUploadResponseRowsItemFormat
    : IStringEnum
{
    public static readonly PostV1DeclarationsCertificatesUploadResponseRowsItemFormat Pem = new(
        Values.Pem
    );

    public static readonly PostV1DeclarationsCertificatesUploadResponseRowsItemFormat PemKey = new(
        Values.PemKey
    );

    public static readonly PostV1DeclarationsCertificatesUploadResponseRowsItemFormat Pfx = new(
        Values.Pfx
    );

    public PostV1DeclarationsCertificatesUploadResponseRowsItemFormat(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static PostV1DeclarationsCertificatesUploadResponseRowsItemFormat FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsCertificatesUploadResponseRowsItemFormat(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(
        PostV1DeclarationsCertificatesUploadResponseRowsItemFormat value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsCertificatesUploadResponseRowsItemFormat value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsCertificatesUploadResponseRowsItemFormat value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsCertificatesUploadResponseRowsItemFormat(
        string value
    ) => new(value);

    internal class PostV1DeclarationsCertificatesUploadResponseRowsItemFormatSerializer
        : JsonConverter<PostV1DeclarationsCertificatesUploadResponseRowsItemFormat>
    {
        public override PostV1DeclarationsCertificatesUploadResponseRowsItemFormat Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new PostV1DeclarationsCertificatesUploadResponseRowsItemFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsCertificatesUploadResponseRowsItemFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsCertificatesUploadResponseRowsItemFormat ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new PostV1DeclarationsCertificatesUploadResponseRowsItemFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsCertificatesUploadResponseRowsItemFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pem = "pem";

        public const string PemKey = "pem-key";

        public const string Pfx = "pfx";
    }
}
