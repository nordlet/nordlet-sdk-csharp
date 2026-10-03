using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsCertificatesDeleteRequestFieldKey.PostV1DeclarationsCertificatesDeleteRequestFieldKeySerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsCertificatesDeleteRequestFieldKey : IStringEnum
{
    public static readonly PostV1DeclarationsCertificatesDeleteRequestFieldKey Certificate = new(
        Values.Certificate
    );

    public static readonly PostV1DeclarationsCertificatesDeleteRequestFieldKey PrivateKey = new(
        Values.PrivateKey
    );

    public PostV1DeclarationsCertificatesDeleteRequestFieldKey(string value)
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
    public static PostV1DeclarationsCertificatesDeleteRequestFieldKey FromCustom(string value)
    {
        return new PostV1DeclarationsCertificatesDeleteRequestFieldKey(value);
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
        PostV1DeclarationsCertificatesDeleteRequestFieldKey value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsCertificatesDeleteRequestFieldKey value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsCertificatesDeleteRequestFieldKey value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsCertificatesDeleteRequestFieldKey(
        string value
    ) => new(value);

    internal class PostV1DeclarationsCertificatesDeleteRequestFieldKeySerializer
        : JsonConverter<PostV1DeclarationsCertificatesDeleteRequestFieldKey>
    {
        public override PostV1DeclarationsCertificatesDeleteRequestFieldKey Read(
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
            return new PostV1DeclarationsCertificatesDeleteRequestFieldKey(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsCertificatesDeleteRequestFieldKey value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsCertificatesDeleteRequestFieldKey ReadAsPropertyName(
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
            return new PostV1DeclarationsCertificatesDeleteRequestFieldKey(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsCertificatesDeleteRequestFieldKey value,
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
        public const string Certificate = "certificate";

        public const string PrivateKey = "privateKey";
    }
}
