using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AuditListResponseRowsItemActorType.PostV1AuditListResponseRowsItemActorTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1AuditListResponseRowsItemActorType : IStringEnum
{
    public static readonly PostV1AuditListResponseRowsItemActorType User = new(Values.User);

    public static readonly PostV1AuditListResponseRowsItemActorType ApiKey = new(Values.ApiKey);

    public static readonly PostV1AuditListResponseRowsItemActorType System = new(Values.System);

    public PostV1AuditListResponseRowsItemActorType(string value)
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
    public static PostV1AuditListResponseRowsItemActorType FromCustom(string value)
    {
        return new PostV1AuditListResponseRowsItemActorType(value);
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
        PostV1AuditListResponseRowsItemActorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AuditListResponseRowsItemActorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AuditListResponseRowsItemActorType value) =>
        value.Value;

    public static explicit operator PostV1AuditListResponseRowsItemActorType(string value) =>
        new(value);

    internal class PostV1AuditListResponseRowsItemActorTypeSerializer
        : JsonConverter<PostV1AuditListResponseRowsItemActorType>
    {
        public override PostV1AuditListResponseRowsItemActorType Read(
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
            return new PostV1AuditListResponseRowsItemActorType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AuditListResponseRowsItemActorType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AuditListResponseRowsItemActorType ReadAsPropertyName(
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
            return new PostV1AuditListResponseRowsItemActorType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AuditListResponseRowsItemActorType value,
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
        public const string User = "user";

        public const string ApiKey = "api_key";

        public const string System = "system";
    }
}
