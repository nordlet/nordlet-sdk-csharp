using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoiceTemplatesCreateSalesResponseSupplyType.InvoiceTemplatesCreateSalesResponseSupplyTypeSerializer)
)]
[Serializable]
public readonly record struct InvoiceTemplatesCreateSalesResponseSupplyType : IStringEnum
{
    public static readonly InvoiceTemplatesCreateSalesResponseSupplyType Goods = new(Values.Goods);

    public static readonly InvoiceTemplatesCreateSalesResponseSupplyType Services = new(
        Values.Services
    );

    public static readonly InvoiceTemplatesCreateSalesResponseSupplyType Digital = new(
        Values.Digital
    );

    public InvoiceTemplatesCreateSalesResponseSupplyType(string value)
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
    public static InvoiceTemplatesCreateSalesResponseSupplyType FromCustom(string value)
    {
        return new InvoiceTemplatesCreateSalesResponseSupplyType(value);
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
        InvoiceTemplatesCreateSalesResponseSupplyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoiceTemplatesCreateSalesResponseSupplyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTemplatesCreateSalesResponseSupplyType value) =>
        value.Value;

    public static explicit operator InvoiceTemplatesCreateSalesResponseSupplyType(string value) =>
        new(value);

    internal class InvoiceTemplatesCreateSalesResponseSupplyTypeSerializer
        : JsonConverter<InvoiceTemplatesCreateSalesResponseSupplyType>
    {
        public override InvoiceTemplatesCreateSalesResponseSupplyType Read(
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
            return new InvoiceTemplatesCreateSalesResponseSupplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceTemplatesCreateSalesResponseSupplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceTemplatesCreateSalesResponseSupplyType ReadAsPropertyName(
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
            return new InvoiceTemplatesCreateSalesResponseSupplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceTemplatesCreateSalesResponseSupplyType value,
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
