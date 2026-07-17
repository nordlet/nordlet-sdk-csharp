using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsSubmissionsCreateRequestObligation.PostV1DeclarationsSubmissionsCreateRequestObligationSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsSubmissionsCreateRequestObligation : IStringEnum
{
    public static readonly PostV1DeclarationsSubmissionsCreateRequestObligation LtIsaf = new(
        Values.LtIsaf
    );

    public PostV1DeclarationsSubmissionsCreateRequestObligation(string value)
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
    public static PostV1DeclarationsSubmissionsCreateRequestObligation FromCustom(string value)
    {
        return new PostV1DeclarationsSubmissionsCreateRequestObligation(value);
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
        PostV1DeclarationsSubmissionsCreateRequestObligation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsSubmissionsCreateRequestObligation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsSubmissionsCreateRequestObligation value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsSubmissionsCreateRequestObligation(
        string value
    ) => new(value);

    internal class PostV1DeclarationsSubmissionsCreateRequestObligationSerializer
        : JsonConverter<PostV1DeclarationsSubmissionsCreateRequestObligation>
    {
        public override PostV1DeclarationsSubmissionsCreateRequestObligation Read(
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
            return new PostV1DeclarationsSubmissionsCreateRequestObligation(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsSubmissionsCreateRequestObligation value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsSubmissionsCreateRequestObligation ReadAsPropertyName(
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
            return new PostV1DeclarationsSubmissionsCreateRequestObligation(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsSubmissionsCreateRequestObligation value,
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
        public const string LtIsaf = "lt-isaf";
    }
}
