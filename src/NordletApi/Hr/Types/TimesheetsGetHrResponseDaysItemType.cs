using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TimesheetsGetHrResponseDaysItemType.TimesheetsGetHrResponseDaysItemTypeSerializer)
)]
[Serializable]
public readonly record struct TimesheetsGetHrResponseDaysItemType : IStringEnum
{
    public static readonly TimesheetsGetHrResponseDaysItemType Work = new(Values.Work);

    public static readonly TimesheetsGetHrResponseDaysItemType BusinessTrip = new(
        Values.BusinessTrip
    );

    public static readonly TimesheetsGetHrResponseDaysItemType Vacation = new(Values.Vacation);

    public static readonly TimesheetsGetHrResponseDaysItemType Sick = new(Values.Sick);

    public static readonly TimesheetsGetHrResponseDaysItemType Holiday = new(Values.Holiday);

    public static readonly TimesheetsGetHrResponseDaysItemType Unpaid = new(Values.Unpaid);

    public TimesheetsGetHrResponseDaysItemType(string value)
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
    public static TimesheetsGetHrResponseDaysItemType FromCustom(string value)
    {
        return new TimesheetsGetHrResponseDaysItemType(value);
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

    public static bool operator ==(TimesheetsGetHrResponseDaysItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimesheetsGetHrResponseDaysItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimesheetsGetHrResponseDaysItemType value) =>
        value.Value;

    public static explicit operator TimesheetsGetHrResponseDaysItemType(string value) => new(value);

    internal class TimesheetsGetHrResponseDaysItemTypeSerializer
        : JsonConverter<TimesheetsGetHrResponseDaysItemType>
    {
        public override TimesheetsGetHrResponseDaysItemType Read(
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
            return new TimesheetsGetHrResponseDaysItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TimesheetsGetHrResponseDaysItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TimesheetsGetHrResponseDaysItemType ReadAsPropertyName(
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
            return new TimesheetsGetHrResponseDaysItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TimesheetsGetHrResponseDaysItemType value,
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
