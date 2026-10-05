using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(VatSummaryReportsRequestSide.VatSummaryReportsRequestSideSerializer))]
[Serializable]
public readonly record struct VatSummaryReportsRequestSide : IStringEnum
{
    public static readonly VatSummaryReportsRequestSide Sales = new(Values.Sales);

    public static readonly VatSummaryReportsRequestSide Purchases = new(Values.Purchases);

    public VatSummaryReportsRequestSide(string value)
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
    public static VatSummaryReportsRequestSide FromCustom(string value)
    {
        return new VatSummaryReportsRequestSide(value);
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

    public static bool operator ==(VatSummaryReportsRequestSide value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VatSummaryReportsRequestSide value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VatSummaryReportsRequestSide value) => value.Value;

    public static explicit operator VatSummaryReportsRequestSide(string value) => new(value);

    internal class VatSummaryReportsRequestSideSerializer
        : JsonConverter<VatSummaryReportsRequestSide>
    {
        public override VatSummaryReportsRequestSide Read(
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
            return new VatSummaryReportsRequestSide(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatSummaryReportsRequestSide value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatSummaryReportsRequestSide ReadAsPropertyName(
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
            return new VatSummaryReportsRequestSide(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatSummaryReportsRequestSide value,
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
