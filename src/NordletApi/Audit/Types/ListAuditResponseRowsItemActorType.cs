using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ListAuditResponseRowsItemActorType.ListAuditResponseRowsItemActorTypeSerializer)
)]
[Serializable]
public readonly record struct ListAuditResponseRowsItemActorType : IStringEnum
{
    public static readonly ListAuditResponseRowsItemActorType User = new(Values.User);

    public static readonly ListAuditResponseRowsItemActorType ApiKey = new(Values.ApiKey);

    public static readonly ListAuditResponseRowsItemActorType System = new(Values.System);

    public ListAuditResponseRowsItemActorType(string value)
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
    public static ListAuditResponseRowsItemActorType FromCustom(string value)
    {
        return new ListAuditResponseRowsItemActorType(value);
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

    public static bool operator ==(ListAuditResponseRowsItemActorType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListAuditResponseRowsItemActorType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListAuditResponseRowsItemActorType value) => value.Value;

    public static explicit operator ListAuditResponseRowsItemActorType(string value) => new(value);

    internal class ListAuditResponseRowsItemActorTypeSerializer
        : JsonConverter<ListAuditResponseRowsItemActorType>
    {
        public override ListAuditResponseRowsItemActorType Read(
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
            return new ListAuditResponseRowsItemActorType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListAuditResponseRowsItemActorType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListAuditResponseRowsItemActorType ReadAsPropertyName(
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
            return new ListAuditResponseRowsItemActorType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListAuditResponseRowsItemActorType value,
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
