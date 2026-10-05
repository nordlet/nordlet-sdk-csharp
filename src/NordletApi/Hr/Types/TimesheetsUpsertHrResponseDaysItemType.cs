using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TimesheetsUpsertHrResponseDaysItemType.TimesheetsUpsertHrResponseDaysItemTypeSerializer)
)]
[Serializable]
public readonly record struct TimesheetsUpsertHrResponseDaysItemType : IStringEnum
{
    public static readonly TimesheetsUpsertHrResponseDaysItemType Work = new(Values.Work);

    public static readonly TimesheetsUpsertHrResponseDaysItemType BusinessTrip = new(
        Values.BusinessTrip
    );

    public static readonly TimesheetsUpsertHrResponseDaysItemType Vacation = new(Values.Vacation);

    public static readonly TimesheetsUpsertHrResponseDaysItemType Sick = new(Values.Sick);

    public static readonly TimesheetsUpsertHrResponseDaysItemType Holiday = new(Values.Holiday);

    public static readonly TimesheetsUpsertHrResponseDaysItemType Unpaid = new(Values.Unpaid);

    public TimesheetsUpsertHrResponseDaysItemType(string value)
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
    public static TimesheetsUpsertHrResponseDaysItemType FromCustom(string value)
    {
        return new TimesheetsUpsertHrResponseDaysItemType(value);
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

    public static bool operator ==(TimesheetsUpsertHrResponseDaysItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimesheetsUpsertHrResponseDaysItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimesheetsUpsertHrResponseDaysItemType value) =>
        value.Value;

    public static explicit operator TimesheetsUpsertHrResponseDaysItemType(string value) =>
        new(value);

    internal class TimesheetsUpsertHrResponseDaysItemTypeSerializer
        : JsonConverter<TimesheetsUpsertHrResponseDaysItemType>
    {
        public override TimesheetsUpsertHrResponseDaysItemType Read(
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
            return new TimesheetsUpsertHrResponseDaysItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TimesheetsUpsertHrResponseDaysItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TimesheetsUpsertHrResponseDaysItemType ReadAsPropertyName(
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
            return new TimesheetsUpsertHrResponseDaysItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TimesheetsUpsertHrResponseDaysItemType value,
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
