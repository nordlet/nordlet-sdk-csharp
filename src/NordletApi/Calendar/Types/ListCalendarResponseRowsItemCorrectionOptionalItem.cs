using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ListCalendarResponseRowsItemCorrectionOptionalItem.ListCalendarResponseRowsItemCorrectionOptionalItemSerializer)
)]
[Serializable]
public readonly record struct ListCalendarResponseRowsItemCorrectionOptionalItem : IStringEnum
{
    public static readonly ListCalendarResponseRowsItemCorrectionOptionalItem Reason = new(
        Values.Reason
    );

    public static readonly ListCalendarResponseRowsItemCorrectionOptionalItem ReasonCode = new(
        Values.ReasonCode
    );

    public static readonly ListCalendarResponseRowsItemCorrectionOptionalItem AuthorityReference =
        new(Values.AuthorityReference);

    public static readonly ListCalendarResponseRowsItemCorrectionOptionalItem DiscoveredOn = new(
        Values.DiscoveredOn
    );

    public ListCalendarResponseRowsItemCorrectionOptionalItem(string value)
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
    public static ListCalendarResponseRowsItemCorrectionOptionalItem FromCustom(string value)
    {
        return new ListCalendarResponseRowsItemCorrectionOptionalItem(value);
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
        ListCalendarResponseRowsItemCorrectionOptionalItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListCalendarResponseRowsItemCorrectionOptionalItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListCalendarResponseRowsItemCorrectionOptionalItem value
    ) => value.Value;

    public static explicit operator ListCalendarResponseRowsItemCorrectionOptionalItem(
        string value
    ) => new(value);

    internal class ListCalendarResponseRowsItemCorrectionOptionalItemSerializer
        : JsonConverter<ListCalendarResponseRowsItemCorrectionOptionalItem>
    {
        public override ListCalendarResponseRowsItemCorrectionOptionalItem Read(
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
            return new ListCalendarResponseRowsItemCorrectionOptionalItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListCalendarResponseRowsItemCorrectionOptionalItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListCalendarResponseRowsItemCorrectionOptionalItem ReadAsPropertyName(
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
            return new ListCalendarResponseRowsItemCorrectionOptionalItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListCalendarResponseRowsItemCorrectionOptionalItem value,
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
        public const string Reason = "reason";

        public const string ReasonCode = "reasonCode";

        public const string AuthorityReference = "authorityReference";

        public const string DiscoveredOn = "discoveredOn";
    }
}
