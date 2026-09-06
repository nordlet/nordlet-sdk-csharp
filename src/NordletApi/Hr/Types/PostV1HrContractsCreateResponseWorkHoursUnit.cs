using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrContractsCreateResponseWorkHoursUnit.PostV1HrContractsCreateResponseWorkHoursUnitSerializer)
)]
[Serializable]
public readonly record struct PostV1HrContractsCreateResponseWorkHoursUnit : IStringEnum
{
    public static readonly PostV1HrContractsCreateResponseWorkHoursUnit Day = new(Values.Day);

    public static readonly PostV1HrContractsCreateResponseWorkHoursUnit Week = new(Values.Week);

    public PostV1HrContractsCreateResponseWorkHoursUnit(string value)
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
    public static PostV1HrContractsCreateResponseWorkHoursUnit FromCustom(string value)
    {
        return new PostV1HrContractsCreateResponseWorkHoursUnit(value);
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
        PostV1HrContractsCreateResponseWorkHoursUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrContractsCreateResponseWorkHoursUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrContractsCreateResponseWorkHoursUnit value) =>
        value.Value;

    public static explicit operator PostV1HrContractsCreateResponseWorkHoursUnit(string value) =>
        new(value);

    internal class PostV1HrContractsCreateResponseWorkHoursUnitSerializer
        : JsonConverter<PostV1HrContractsCreateResponseWorkHoursUnit>
    {
        public override PostV1HrContractsCreateResponseWorkHoursUnit Read(
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
            return new PostV1HrContractsCreateResponseWorkHoursUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrContractsCreateResponseWorkHoursUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrContractsCreateResponseWorkHoursUnit ReadAsPropertyName(
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
            return new PostV1HrContractsCreateResponseWorkHoursUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrContractsCreateResponseWorkHoursUnit value,
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
        public const string Day = "day";

        public const string Week = "week";
    }
}
