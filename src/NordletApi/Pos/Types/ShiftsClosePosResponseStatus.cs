using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ShiftsClosePosResponseStatus.ShiftsClosePosResponseStatusSerializer))]
[Serializable]
public readonly record struct ShiftsClosePosResponseStatus : IStringEnum
{
    public static readonly ShiftsClosePosResponseStatus Open = new(Values.Open);

    public static readonly ShiftsClosePosResponseStatus Closed = new(Values.Closed);

    public ShiftsClosePosResponseStatus(string value)
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
    public static ShiftsClosePosResponseStatus FromCustom(string value)
    {
        return new ShiftsClosePosResponseStatus(value);
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

    public static bool operator ==(ShiftsClosePosResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ShiftsClosePosResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ShiftsClosePosResponseStatus value) => value.Value;

    public static explicit operator ShiftsClosePosResponseStatus(string value) => new(value);

    internal class ShiftsClosePosResponseStatusSerializer
        : JsonConverter<ShiftsClosePosResponseStatus>
    {
        public override ShiftsClosePosResponseStatus Read(
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
            return new ShiftsClosePosResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ShiftsClosePosResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ShiftsClosePosResponseStatus ReadAsPropertyName(
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
            return new ShiftsClosePosResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ShiftsClosePosResponseStatus value,
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
        public const string Open = "open";

        public const string Closed = "closed";
    }
}
