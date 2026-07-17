using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrTimesheetsListResponseRowsItemDaysItemType.PostV1HrTimesheetsListResponseRowsItemDaysItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrTimesheetsListResponseRowsItemDaysItemType : IStringEnum
{
    public static readonly PostV1HrTimesheetsListResponseRowsItemDaysItemType Work = new(
        Values.Work
    );

    public static readonly PostV1HrTimesheetsListResponseRowsItemDaysItemType BusinessTrip = new(
        Values.BusinessTrip
    );

    public static readonly PostV1HrTimesheetsListResponseRowsItemDaysItemType Vacation = new(
        Values.Vacation
    );

    public static readonly PostV1HrTimesheetsListResponseRowsItemDaysItemType Sick = new(
        Values.Sick
    );

    public static readonly PostV1HrTimesheetsListResponseRowsItemDaysItemType Holiday = new(
        Values.Holiday
    );

    public static readonly PostV1HrTimesheetsListResponseRowsItemDaysItemType Unpaid = new(
        Values.Unpaid
    );

    public PostV1HrTimesheetsListResponseRowsItemDaysItemType(string value)
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
    public static PostV1HrTimesheetsListResponseRowsItemDaysItemType FromCustom(string value)
    {
        return new PostV1HrTimesheetsListResponseRowsItemDaysItemType(value);
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
        PostV1HrTimesheetsListResponseRowsItemDaysItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrTimesheetsListResponseRowsItemDaysItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1HrTimesheetsListResponseRowsItemDaysItemType value
    ) => value.Value;

    public static explicit operator PostV1HrTimesheetsListResponseRowsItemDaysItemType(
        string value
    ) => new(value);

    internal class PostV1HrTimesheetsListResponseRowsItemDaysItemTypeSerializer
        : JsonConverter<PostV1HrTimesheetsListResponseRowsItemDaysItemType>
    {
        public override PostV1HrTimesheetsListResponseRowsItemDaysItemType Read(
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
            return new PostV1HrTimesheetsListResponseRowsItemDaysItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrTimesheetsListResponseRowsItemDaysItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrTimesheetsListResponseRowsItemDaysItemType ReadAsPropertyName(
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
            return new PostV1HrTimesheetsListResponseRowsItemDaysItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrTimesheetsListResponseRowsItemDaysItemType value,
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
