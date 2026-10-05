using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ActsUpdateSalesResponseType.ActsUpdateSalesResponseTypeSerializer))]
[Serializable]
public readonly record struct ActsUpdateSalesResponseType : IStringEnum
{
    public static readonly ActsUpdateSalesResponseType Goods = new(Values.Goods);

    public static readonly ActsUpdateSalesResponseType Services = new(Values.Services);

    public ActsUpdateSalesResponseType(string value)
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
    public static ActsUpdateSalesResponseType FromCustom(string value)
    {
        return new ActsUpdateSalesResponseType(value);
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

    public static bool operator ==(ActsUpdateSalesResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActsUpdateSalesResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActsUpdateSalesResponseType value) => value.Value;

    public static explicit operator ActsUpdateSalesResponseType(string value) => new(value);

    internal class ActsUpdateSalesResponseTypeSerializer
        : JsonConverter<ActsUpdateSalesResponseType>
    {
        public override ActsUpdateSalesResponseType Read(
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
            return new ActsUpdateSalesResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ActsUpdateSalesResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ActsUpdateSalesResponseType ReadAsPropertyName(
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
            return new ActsUpdateSalesResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ActsUpdateSalesResponseType value,
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
