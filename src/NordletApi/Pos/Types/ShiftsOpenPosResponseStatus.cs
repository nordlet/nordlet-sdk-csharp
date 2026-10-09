using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ShiftsOpenPosResponseStatus.ShiftsOpenPosResponseStatusSerializer))]
[Serializable]
public readonly record struct ShiftsOpenPosResponseStatus : IStringEnum
{
    public static readonly ShiftsOpenPosResponseStatus Open = new(Values.Open);

    public static readonly ShiftsOpenPosResponseStatus Closed = new(Values.Closed);

    public ShiftsOpenPosResponseStatus(string value)
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
    public static ShiftsOpenPosResponseStatus FromCustom(string value)
    {
        return new ShiftsOpenPosResponseStatus(value);
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

    public static bool operator ==(ShiftsOpenPosResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ShiftsOpenPosResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ShiftsOpenPosResponseStatus value) => value.Value;

    public static explicit operator ShiftsOpenPosResponseStatus(string value) => new(value);

    internal class ShiftsOpenPosResponseStatusSerializer
        : JsonConverter<ShiftsOpenPosResponseStatus>
    {
        public override ShiftsOpenPosResponseStatus Read(
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
            return new ShiftsOpenPosResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ShiftsOpenPosResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ShiftsOpenPosResponseStatus ReadAsPropertyName(
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
            return new ShiftsOpenPosResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ShiftsOpenPosResponseStatus value,
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
