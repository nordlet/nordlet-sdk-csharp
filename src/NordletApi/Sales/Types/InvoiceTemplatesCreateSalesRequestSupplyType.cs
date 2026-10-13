using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoiceTemplatesCreateSalesRequestSupplyType.InvoiceTemplatesCreateSalesRequestSupplyTypeSerializer)
)]
[Serializable]
public readonly record struct InvoiceTemplatesCreateSalesRequestSupplyType : IStringEnum
{
    public static readonly InvoiceTemplatesCreateSalesRequestSupplyType Goods = new(Values.Goods);

    public static readonly InvoiceTemplatesCreateSalesRequestSupplyType Services = new(
        Values.Services
    );

    public static readonly InvoiceTemplatesCreateSalesRequestSupplyType Digital = new(
        Values.Digital
    );

    public InvoiceTemplatesCreateSalesRequestSupplyType(string value)
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
    public static InvoiceTemplatesCreateSalesRequestSupplyType FromCustom(string value)
    {
        return new InvoiceTemplatesCreateSalesRequestSupplyType(value);
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

    public static bool operator ==(
        InvoiceTemplatesCreateSalesRequestSupplyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoiceTemplatesCreateSalesRequestSupplyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTemplatesCreateSalesRequestSupplyType value) =>
        value.Value;

    public static explicit operator InvoiceTemplatesCreateSalesRequestSupplyType(string value) =>
        new(value);

    internal class InvoiceTemplatesCreateSalesRequestSupplyTypeSerializer
        : JsonConverter<InvoiceTemplatesCreateSalesRequestSupplyType>
    {
        public override InvoiceTemplatesCreateSalesRequestSupplyType Read(
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
            return new InvoiceTemplatesCreateSalesRequestSupplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceTemplatesCreateSalesRequestSupplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceTemplatesCreateSalesRequestSupplyType ReadAsPropertyName(
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
            return new InvoiceTemplatesCreateSalesRequestSupplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceTemplatesCreateSalesRequestSupplyType value,
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

        public const string Digital = "digital";
    }
}
