using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(VatDetailReportsRequestSide.VatDetailReportsRequestSideSerializer))]
[Serializable]
public readonly record struct VatDetailReportsRequestSide : IStringEnum
{
    public static readonly VatDetailReportsRequestSide Sales = new(Values.Sales);

    public static readonly VatDetailReportsRequestSide Purchases = new(Values.Purchases);

    public VatDetailReportsRequestSide(string value)
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
    public static VatDetailReportsRequestSide FromCustom(string value)
    {
        return new VatDetailReportsRequestSide(value);
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

    public static bool operator ==(VatDetailReportsRequestSide value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VatDetailReportsRequestSide value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VatDetailReportsRequestSide value) => value.Value;

    public static explicit operator VatDetailReportsRequestSide(string value) => new(value);

    internal class VatDetailReportsRequestSideSerializer
        : JsonConverter<VatDetailReportsRequestSide>
    {
        public override VatDetailReportsRequestSide Read(
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
            return new VatDetailReportsRequestSide(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatDetailReportsRequestSide value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatDetailReportsRequestSide ReadAsPropertyName(
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
            return new VatDetailReportsRequestSide(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatDetailReportsRequestSide value,
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
        public const string Sales = "sales";

        public const string Purchases = "purchases";
    }
}
