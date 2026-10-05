using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ActsUpdateSalesRequestType.ActsUpdateSalesRequestTypeSerializer))]
[Serializable]
public readonly record struct ActsUpdateSalesRequestType : IStringEnum
{
    public static readonly ActsUpdateSalesRequestType Goods = new(Values.Goods);

    public static readonly ActsUpdateSalesRequestType Services = new(Values.Services);

    public ActsUpdateSalesRequestType(string value)
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
    public static ActsUpdateSalesRequestType FromCustom(string value)
    {
        return new ActsUpdateSalesRequestType(value);
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

    public static bool operator ==(ActsUpdateSalesRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActsUpdateSalesRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActsUpdateSalesRequestType value) => value.Value;

    public static explicit operator ActsUpdateSalesRequestType(string value) => new(value);

    internal class ActsUpdateSalesRequestTypeSerializer : JsonConverter<ActsUpdateSalesRequestType>
    {
        public override ActsUpdateSalesRequestType Read(
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
            return new ActsUpdateSalesRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ActsUpdateSalesRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ActsUpdateSalesRequestType ReadAsPropertyName(
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
            return new ActsUpdateSalesRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ActsUpdateSalesRequestType value,
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
