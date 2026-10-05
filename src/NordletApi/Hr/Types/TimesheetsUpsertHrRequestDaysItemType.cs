using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TimesheetsUpsertHrRequestDaysItemType.TimesheetsUpsertHrRequestDaysItemTypeSerializer)
)]
[Serializable]
public readonly record struct TimesheetsUpsertHrRequestDaysItemType : IStringEnum
{
    public static readonly TimesheetsUpsertHrRequestDaysItemType Work = new(Values.Work);

    public static readonly TimesheetsUpsertHrRequestDaysItemType BusinessTrip = new(
        Values.BusinessTrip
    );

    public static readonly TimesheetsUpsertHrRequestDaysItemType Vacation = new(Values.Vacation);

    public static readonly TimesheetsUpsertHrRequestDaysItemType Sick = new(Values.Sick);

    public static readonly TimesheetsUpsertHrRequestDaysItemType Holiday = new(Values.Holiday);

    public static readonly TimesheetsUpsertHrRequestDaysItemType Unpaid = new(Values.Unpaid);

    public TimesheetsUpsertHrRequestDaysItemType(string value)
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
    public static TimesheetsUpsertHrRequestDaysItemType FromCustom(string value)
    {
        return new TimesheetsUpsertHrRequestDaysItemType(value);
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

    public static bool operator ==(TimesheetsUpsertHrRequestDaysItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimesheetsUpsertHrRequestDaysItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimesheetsUpsertHrRequestDaysItemType value) =>
        value.Value;

    public static explicit operator TimesheetsUpsertHrRequestDaysItemType(string value) =>
        new(value);

    internal class TimesheetsUpsertHrRequestDaysItemTypeSerializer
        : JsonConverter<TimesheetsUpsertHrRequestDaysItemType>
    {
        public override TimesheetsUpsertHrRequestDaysItemType Read(
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
            return new TimesheetsUpsertHrRequestDaysItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TimesheetsUpsertHrRequestDaysItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TimesheetsUpsertHrRequestDaysItemType ReadAsPropertyName(
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
            return new TimesheetsUpsertHrRequestDaysItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TimesheetsUpsertHrRequestDaysItemType value,
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
        public const string Work = "work";

        public const string BusinessTrip = "business_trip";

        public const string Vacation = "vacation";

        public const string Sick = "sick";

        public const string Holiday = "holiday";

        public const string Unpaid = "unpaid";
    }
}
