using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ActsCreateSalesResponseType.ActsCreateSalesResponseTypeSerializer))]
[Serializable]
public readonly record struct ActsCreateSalesResponseType : IStringEnum
{
    public static readonly ActsCreateSalesResponseType Goods = new(Values.Goods);

    public static readonly ActsCreateSalesResponseType Services = new(Values.Services);

    public ActsCreateSalesResponseType(string value)
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
    public static ActsCreateSalesResponseType FromCustom(string value)
    {
        return new ActsCreateSalesResponseType(value);
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

    public static bool operator ==(ActsCreateSalesResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActsCreateSalesResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActsCreateSalesResponseType value) => value.Value;

    public static explicit operator ActsCreateSalesResponseType(string value) => new(value);

    internal class ActsCreateSalesResponseTypeSerializer
        : JsonConverter<ActsCreateSalesResponseType>
    {
        public override ActsCreateSalesResponseType Read(
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
            return new ActsCreateSalesResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ActsCreateSalesResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ActsCreateSalesResponseType ReadAsPropertyName(
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
            return new ActsCreateSalesResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ActsCreateSalesResponseType value,
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
