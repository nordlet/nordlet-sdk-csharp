using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrContractsListResponseRowsItemSalaryType.PostV1HrContractsListResponseRowsItemSalaryTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrContractsListResponseRowsItemSalaryType : IStringEnum
{
    public static readonly PostV1HrContractsListResponseRowsItemSalaryType Monthly = new(
        Values.Monthly
    );

    public static readonly PostV1HrContractsListResponseRowsItemSalaryType Hourly = new(
        Values.Hourly
    );

    public static readonly PostV1HrContractsListResponseRowsItemSalaryType Weekly = new(
        Values.Weekly
    );

    public static readonly PostV1HrContractsListResponseRowsItemSalaryType Daily = new(
        Values.Daily
    );

    public static readonly PostV1HrContractsListResponseRowsItemSalaryType Yearly = new(
        Values.Yearly
    );

    public PostV1HrContractsListResponseRowsItemSalaryType(string value)
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
    public static PostV1HrContractsListResponseRowsItemSalaryType FromCustom(string value)
    {
        return new PostV1HrContractsListResponseRowsItemSalaryType(value);
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
        PostV1HrContractsListResponseRowsItemSalaryType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrContractsListResponseRowsItemSalaryType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrContractsListResponseRowsItemSalaryType value) =>
        value.Value;

    public static explicit operator PostV1HrContractsListResponseRowsItemSalaryType(string value) =>
        new(value);

    internal class PostV1HrContractsListResponseRowsItemSalaryTypeSerializer
        : JsonConverter<PostV1HrContractsListResponseRowsItemSalaryType>
    {
        public override PostV1HrContractsListResponseRowsItemSalaryType Read(
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
            return new PostV1HrContractsListResponseRowsItemSalaryType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrContractsListResponseRowsItemSalaryType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrContractsListResponseRowsItemSalaryType ReadAsPropertyName(
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
            return new PostV1HrContractsListResponseRowsItemSalaryType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrContractsListResponseRowsItemSalaryType value,
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
        public const string Monthly = "monthly";

        public const string Hourly = "hourly";

        public const string Weekly = "weekly";

        public const string Daily = "daily";

        public const string Yearly = "yearly";
    }
}
