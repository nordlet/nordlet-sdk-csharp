using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoiceTemplatesGetSalesResponseSupplyType.InvoiceTemplatesGetSalesResponseSupplyTypeSerializer)
)]
[Serializable]
public readonly record struct InvoiceTemplatesGetSalesResponseSupplyType : IStringEnum
{
    public static readonly InvoiceTemplatesGetSalesResponseSupplyType Goods = new(Values.Goods);

    public static readonly InvoiceTemplatesGetSalesResponseSupplyType Services = new(
        Values.Services
    );

    public static readonly InvoiceTemplatesGetSalesResponseSupplyType Digital = new(Values.Digital);

    public InvoiceTemplatesGetSalesResponseSupplyType(string value)
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
    public static InvoiceTemplatesGetSalesResponseSupplyType FromCustom(string value)
    {
        return new InvoiceTemplatesGetSalesResponseSupplyType(value);
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
        InvoiceTemplatesGetSalesResponseSupplyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoiceTemplatesGetSalesResponseSupplyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTemplatesGetSalesResponseSupplyType value) =>
        value.Value;

    public static explicit operator InvoiceTemplatesGetSalesResponseSupplyType(string value) =>
        new(value);

    internal class InvoiceTemplatesGetSalesResponseSupplyTypeSerializer
        : JsonConverter<InvoiceTemplatesGetSalesResponseSupplyType>
    {
        public override InvoiceTemplatesGetSalesResponseSupplyType Read(
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
            return new InvoiceTemplatesGetSalesResponseSupplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceTemplatesGetSalesResponseSupplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceTemplatesGetSalesResponseSupplyType ReadAsPropertyName(
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
            return new InvoiceTemplatesGetSalesResponseSupplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceTemplatesGetSalesResponseSupplyType value,
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
