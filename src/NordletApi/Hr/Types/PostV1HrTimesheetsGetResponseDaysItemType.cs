using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrTimesheetsGetResponseDaysItemType.PostV1HrTimesheetsGetResponseDaysItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrTimesheetsGetResponseDaysItemType : IStringEnum
{
    public static readonly PostV1HrTimesheetsGetResponseDaysItemType Work = new(Values.Work);

    public static readonly PostV1HrTimesheetsGetResponseDaysItemType BusinessTrip = new(
        Values.BusinessTrip
    );

    public static readonly PostV1HrTimesheetsGetResponseDaysItemType Vacation = new(
        Values.Vacation
    );

    public static readonly PostV1HrTimesheetsGetResponseDaysItemType Sick = new(Values.Sick);

    public static readonly PostV1HrTimesheetsGetResponseDaysItemType Holiday = new(Values.Holiday);

    public static readonly PostV1HrTimesheetsGetResponseDaysItemType Unpaid = new(Values.Unpaid);

    public PostV1HrTimesheetsGetResponseDaysItemType(string value)
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
    public static PostV1HrTimesheetsGetResponseDaysItemType FromCustom(string value)
    {
        return new PostV1HrTimesheetsGetResponseDaysItemType(value);
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
        PostV1HrTimesheetsGetResponseDaysItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrTimesheetsGetResponseDaysItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrTimesheetsGetResponseDaysItemType value) =>
        value.Value;

    public static explicit operator PostV1HrTimesheetsGetResponseDaysItemType(string value) =>
        new(value);

    internal class PostV1HrTimesheetsGetResponseDaysItemTypeSerializer
        : JsonConverter<PostV1HrTimesheetsGetResponseDaysItemType>
    {
        public override PostV1HrTimesheetsGetResponseDaysItemType Read(
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
            return new PostV1HrTimesheetsGetResponseDaysItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrTimesheetsGetResponseDaysItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrTimesheetsGetResponseDaysItemType ReadAsPropertyName(
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
            return new PostV1HrTimesheetsGetResponseDaysItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrTimesheetsGetResponseDaysItemType value,
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
