using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoiceTemplatesUpdateSalesResponseSupplyType.InvoiceTemplatesUpdateSalesResponseSupplyTypeSerializer)
)]
[Serializable]
public readonly record struct InvoiceTemplatesUpdateSalesResponseSupplyType : IStringEnum
{
    public static readonly InvoiceTemplatesUpdateSalesResponseSupplyType Goods = new(Values.Goods);

    public static readonly InvoiceTemplatesUpdateSalesResponseSupplyType Services = new(
        Values.Services
    );

    public static readonly InvoiceTemplatesUpdateSalesResponseSupplyType Digital = new(
        Values.Digital
    );

    public InvoiceTemplatesUpdateSalesResponseSupplyType(string value)
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
    public static InvoiceTemplatesUpdateSalesResponseSupplyType FromCustom(string value)
    {
        return new InvoiceTemplatesUpdateSalesResponseSupplyType(value);
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
        InvoiceTemplatesUpdateSalesResponseSupplyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoiceTemplatesUpdateSalesResponseSupplyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTemplatesUpdateSalesResponseSupplyType value) =>
        value.Value;

    public static explicit operator InvoiceTemplatesUpdateSalesResponseSupplyType(string value) =>
        new(value);

    internal class InvoiceTemplatesUpdateSalesResponseSupplyTypeSerializer
        : JsonConverter<InvoiceTemplatesUpdateSalesResponseSupplyType>
    {
        public override InvoiceTemplatesUpdateSalesResponseSupplyType Read(
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
            return new InvoiceTemplatesUpdateSalesResponseSupplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceTemplatesUpdateSalesResponseSupplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceTemplatesUpdateSalesResponseSupplyType ReadAsPropertyName(
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
            return new InvoiceTemplatesUpdateSalesResponseSupplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceTemplatesUpdateSalesResponseSupplyType value,
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
