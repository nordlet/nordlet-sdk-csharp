using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ActsIssueSalesResponseType.ActsIssueSalesResponseTypeSerializer))]
[Serializable]
public readonly record struct ActsIssueSalesResponseType : IStringEnum
{
    public static readonly ActsIssueSalesResponseType Goods = new(Values.Goods);

    public static readonly ActsIssueSalesResponseType Services = new(Values.Services);

    public ActsIssueSalesResponseType(string value)
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
    public static ActsIssueSalesResponseType FromCustom(string value)
    {
        return new ActsIssueSalesResponseType(value);
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

    public static bool operator ==(ActsIssueSalesResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActsIssueSalesResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActsIssueSalesResponseType value) => value.Value;

    public static explicit operator ActsIssueSalesResponseType(string value) => new(value);

    internal class ActsIssueSalesResponseTypeSerializer : JsonConverter<ActsIssueSalesResponseType>
    {
        public override ActsIssueSalesResponseType Read(
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
            return new ActsIssueSalesResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ActsIssueSalesResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ActsIssueSalesResponseType ReadAsPropertyName(
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
            return new ActsIssueSalesResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ActsIssueSalesResponseType value,
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
        public const string Goods = "goods";

        public const string Services = "services";
    }
}
