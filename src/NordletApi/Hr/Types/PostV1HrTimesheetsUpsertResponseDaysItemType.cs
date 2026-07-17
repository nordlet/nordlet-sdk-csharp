using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrTimesheetsUpsertResponseDaysItemType.PostV1HrTimesheetsUpsertResponseDaysItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrTimesheetsUpsertResponseDaysItemType : IStringEnum
{
    public static readonly PostV1HrTimesheetsUpsertResponseDaysItemType Work = new(Values.Work);

    public static readonly PostV1HrTimesheetsUpsertResponseDaysItemType BusinessTrip = new(
        Values.BusinessTrip
    );

    public static readonly PostV1HrTimesheetsUpsertResponseDaysItemType Vacation = new(
        Values.Vacation
    );

    public static readonly PostV1HrTimesheetsUpsertResponseDaysItemType Sick = new(Values.Sick);

    public static readonly PostV1HrTimesheetsUpsertResponseDaysItemType Holiday = new(
        Values.Holiday
    );

    public static readonly PostV1HrTimesheetsUpsertResponseDaysItemType Unpaid = new(Values.Unpaid);

    public PostV1HrTimesheetsUpsertResponseDaysItemType(string value)
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
    public static PostV1HrTimesheetsUpsertResponseDaysItemType FromCustom(string value)
    {
        return new PostV1HrTimesheetsUpsertResponseDaysItemType(value);
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
        PostV1HrTimesheetsUpsertResponseDaysItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrTimesheetsUpsertResponseDaysItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrTimesheetsUpsertResponseDaysItemType value) =>
        value.Value;

    public static explicit operator PostV1HrTimesheetsUpsertResponseDaysItemType(string value) =>
        new(value);

    internal class PostV1HrTimesheetsUpsertResponseDaysItemTypeSerializer
        : JsonConverter<PostV1HrTimesheetsUpsertResponseDaysItemType>
    {
        public override PostV1HrTimesheetsUpsertResponseDaysItemType Read(
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
            return new PostV1HrTimesheetsUpsertResponseDaysItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrTimesheetsUpsertResponseDaysItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrTimesheetsUpsertResponseDaysItemType ReadAsPropertyName(
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
            return new PostV1HrTimesheetsUpsertResponseDaysItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrTimesheetsUpsertResponseDaysItemType value,
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
