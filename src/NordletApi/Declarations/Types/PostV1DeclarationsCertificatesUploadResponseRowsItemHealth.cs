using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsCertificatesUploadResponseRowsItemHealth.PostV1DeclarationsCertificatesUploadResponseRowsItemHealthSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsCertificatesUploadResponseRowsItemHealth
    : IStringEnum
{
    public static readonly PostV1DeclarationsCertificatesUploadResponseRowsItemHealth Ok = new(
        Values.Ok
    );

    public static readonly PostV1DeclarationsCertificatesUploadResponseRowsItemHealth Expiring =
        new(Values.Expiring);

    public static readonly PostV1DeclarationsCertificatesUploadResponseRowsItemHealth Expired = new(
        Values.Expired
    );

    public static readonly PostV1DeclarationsCertificatesUploadResponseRowsItemHealth Unknown = new(
        Values.Unknown
    );

    public PostV1DeclarationsCertificatesUploadResponseRowsItemHealth(string value)
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
    public static PostV1DeclarationsCertificatesUploadResponseRowsItemHealth FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsCertificatesUploadResponseRowsItemHealth(value);
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
        PostV1DeclarationsCertificatesUploadResponseRowsItemHealth value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsCertificatesUploadResponseRowsItemHealth value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsCertificatesUploadResponseRowsItemHealth value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsCertificatesUploadResponseRowsItemHealth(
        string value
    ) => new(value);

    internal class PostV1DeclarationsCertificatesUploadResponseRowsItemHealthSerializer
        : JsonConverter<PostV1DeclarationsCertificatesUploadResponseRowsItemHealth>
    {
        public override PostV1DeclarationsCertificatesUploadResponseRowsItemHealth Read(
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
            return new PostV1DeclarationsCertificatesUploadResponseRowsItemHealth(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsCertificatesUploadResponseRowsItemHealth value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsCertificatesUploadResponseRowsItemHealth ReadAsPropertyName(
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
            return new PostV1DeclarationsCertificatesUploadResponseRowsItemHealth(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsCertificatesUploadResponseRowsItemHealth value,
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
        public const string Ok = "ok";

        public const string Expiring = "expiring";

        public const string Expired = "expired";

        public const string Unknown = "unknown";
    }
}
