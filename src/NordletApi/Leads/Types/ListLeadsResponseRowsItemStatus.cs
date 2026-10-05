using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ListLeadsResponseRowsItemStatus.ListLeadsResponseRowsItemStatusSerializer))]
[Serializable]
public readonly record struct ListLeadsResponseRowsItemStatus : IStringEnum
{
    public static readonly ListLeadsResponseRowsItemStatus New = new(Values.New);

    public static readonly ListLeadsResponseRowsItemStatus Contacted = new(Values.Contacted);

    public static readonly ListLeadsResponseRowsItemStatus Qualified = new(Values.Qualified);

    public static readonly ListLeadsResponseRowsItemStatus Lost = new(Values.Lost);

    public static readonly ListLeadsResponseRowsItemStatus Converted = new(Values.Converted);

    public ListLeadsResponseRowsItemStatus(string value)
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
    public static ListLeadsResponseRowsItemStatus FromCustom(string value)
    {
        return new ListLeadsResponseRowsItemStatus(value);
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

    public static bool operator ==(ListLeadsResponseRowsItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListLeadsResponseRowsItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListLeadsResponseRowsItemStatus value) => value.Value;

    public static explicit operator ListLeadsResponseRowsItemStatus(string value) => new(value);

    internal class ListLeadsResponseRowsItemStatusSerializer
        : JsonConverter<ListLeadsResponseRowsItemStatus>
    {
        public override ListLeadsResponseRowsItemStatus Read(
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
            return new ListLeadsResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListLeadsResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListLeadsResponseRowsItemStatus ReadAsPropertyName(
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
            return new ListLeadsResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListLeadsResponseRowsItemStatus value,
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
        public const string New = "new";

        public const string Contacted = "contacted";

        public const string Qualified = "qualified";

        public const string Lost = "lost";

        public const string Converted = "converted";
    }
}
