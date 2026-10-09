using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ShiftsGetPosResponseStatus.ShiftsGetPosResponseStatusSerializer))]
[Serializable]
public readonly record struct ShiftsGetPosResponseStatus : IStringEnum
{
    public static readonly ShiftsGetPosResponseStatus Open = new(Values.Open);

    public static readonly ShiftsGetPosResponseStatus Closed = new(Values.Closed);

    public ShiftsGetPosResponseStatus(string value)
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
    public static ShiftsGetPosResponseStatus FromCustom(string value)
    {
        return new ShiftsGetPosResponseStatus(value);
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

    public static bool operator ==(ShiftsGetPosResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ShiftsGetPosResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ShiftsGetPosResponseStatus value) => value.Value;

    public static explicit operator ShiftsGetPosResponseStatus(string value) => new(value);

    internal class ShiftsGetPosResponseStatusSerializer : JsonConverter<ShiftsGetPosResponseStatus>
    {
        public override ShiftsGetPosResponseStatus Read(
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
            return new ShiftsGetPosResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ShiftsGetPosResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ShiftsGetPosResponseStatus ReadAsPropertyName(
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
            return new ShiftsGetPosResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ShiftsGetPosResponseStatus value,
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
