using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrTimesheetsUpsertRequestDaysItemType.PostV1HrTimesheetsUpsertRequestDaysItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrTimesheetsUpsertRequestDaysItemType : IStringEnum
{
    public static readonly PostV1HrTimesheetsUpsertRequestDaysItemType Work = new(Values.Work);

    public static readonly PostV1HrTimesheetsUpsertRequestDaysItemType BusinessTrip = new(
        Values.BusinessTrip
    );

    public static readonly PostV1HrTimesheetsUpsertRequestDaysItemType Vacation = new(
        Values.Vacation
    );

    public static readonly PostV1HrTimesheetsUpsertRequestDaysItemType Sick = new(Values.Sick);

    public static readonly PostV1HrTimesheetsUpsertRequestDaysItemType Holiday = new(
        Values.Holiday
    );

    public static readonly PostV1HrTimesheetsUpsertRequestDaysItemType Unpaid = new(Values.Unpaid);

    public PostV1HrTimesheetsUpsertRequestDaysItemType(string value)
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
    public static PostV1HrTimesheetsUpsertRequestDaysItemType FromCustom(string value)
    {
        return new PostV1HrTimesheetsUpsertRequestDaysItemType(value);
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
        PostV1HrTimesheetsUpsertRequestDaysItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrTimesheetsUpsertRequestDaysItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrTimesheetsUpsertRequestDaysItemType value) =>
        value.Value;

    public static explicit operator PostV1HrTimesheetsUpsertRequestDaysItemType(string value) =>
        new(value);

    internal class PostV1HrTimesheetsUpsertRequestDaysItemTypeSerializer
        : JsonConverter<PostV1HrTimesheetsUpsertRequestDaysItemType>
    {
        public override PostV1HrTimesheetsUpsertRequestDaysItemType Read(
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
            return new PostV1HrTimesheetsUpsertRequestDaysItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrTimesheetsUpsertRequestDaysItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrTimesheetsUpsertRequestDaysItemType ReadAsPropertyName(
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
            return new PostV1HrTimesheetsUpsertRequestDaysItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrTimesheetsUpsertRequestDaysItemType value,
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
