using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsCertificatesListResponseRowsItemHealth.PostV1DeclarationsCertificatesListResponseRowsItemHealthSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsCertificatesListResponseRowsItemHealth : IStringEnum
{
    public static readonly PostV1DeclarationsCertificatesListResponseRowsItemHealth Ok = new(
        Values.Ok
    );

    public static readonly PostV1DeclarationsCertificatesListResponseRowsItemHealth Expiring = new(
        Values.Expiring
    );

    public static readonly PostV1DeclarationsCertificatesListResponseRowsItemHealth Expired = new(
        Values.Expired
    );

    public static readonly PostV1DeclarationsCertificatesListResponseRowsItemHealth Unknown = new(
        Values.Unknown
    );

    public PostV1DeclarationsCertificatesListResponseRowsItemHealth(string value)
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
    public static PostV1DeclarationsCertificatesListResponseRowsItemHealth FromCustom(string value)
    {
        return new PostV1DeclarationsCertificatesListResponseRowsItemHealth(value);
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
        PostV1DeclarationsCertificatesListResponseRowsItemHealth value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsCertificatesListResponseRowsItemHealth value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsCertificatesListResponseRowsItemHealth value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsCertificatesListResponseRowsItemHealth(
        string value
    ) => new(value);

    internal class PostV1DeclarationsCertificatesListResponseRowsItemHealthSerializer
        : JsonConverter<PostV1DeclarationsCertificatesListResponseRowsItemHealth>
    {
        public override PostV1DeclarationsCertificatesListResponseRowsItemHealth Read(
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
            return new PostV1DeclarationsCertificatesListResponseRowsItemHealth(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsCertificatesListResponseRowsItemHealth value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsCertificatesListResponseRowsItemHealth ReadAsPropertyName(
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
            return new PostV1DeclarationsCertificatesListResponseRowsItemHealth(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsCertificatesListResponseRowsItemHealth value,
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
