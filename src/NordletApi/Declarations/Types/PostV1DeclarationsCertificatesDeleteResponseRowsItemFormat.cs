using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat.PostV1DeclarationsCertificatesDeleteResponseRowsItemFormatSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat
    : IStringEnum
{
    public static readonly PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat Pem = new(
        Values.Pem
    );

    public static readonly PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat PemKey = new(
        Values.PemKey
    );

    public static readonly PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat Pfx = new(
        Values.Pfx
    );

    public PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat(string value)
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
    public static PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat(value);
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
        PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat(
        string value
    ) => new(value);

    internal class PostV1DeclarationsCertificatesDeleteResponseRowsItemFormatSerializer
        : JsonConverter<PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat>
    {
        public override PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat Read(
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
            return new PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat ReadAsPropertyName(
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
            return new PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsCertificatesDeleteResponseRowsItemFormat value,
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
