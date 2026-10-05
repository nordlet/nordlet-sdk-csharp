using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ActsCreateSalesRequestType.ActsCreateSalesRequestTypeSerializer))]
[Serializable]
public readonly record struct ActsCreateSalesRequestType : IStringEnum
{
    public static readonly ActsCreateSalesRequestType Goods = new(Values.Goods);

    public static readonly ActsCreateSalesRequestType Services = new(Values.Services);

    public ActsCreateSalesRequestType(string value)
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
    public static ActsCreateSalesRequestType FromCustom(string value)
    {
        return new ActsCreateSalesRequestType(value);
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

    public static bool operator ==(ActsCreateSalesRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActsCreateSalesRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActsCreateSalesRequestType value) => value.Value;

    public static explicit operator ActsCreateSalesRequestType(string value) => new(value);

    internal class ActsCreateSalesRequestTypeSerializer : JsonConverter<ActsCreateSalesRequestType>
    {
        public override ActsCreateSalesRequestType Read(
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
            return new ActsCreateSalesRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ActsCreateSalesRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ActsCreateSalesRequestType ReadAsPropertyName(
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
            return new ActsCreateSalesRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ActsCreateSalesRequestType value,
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
