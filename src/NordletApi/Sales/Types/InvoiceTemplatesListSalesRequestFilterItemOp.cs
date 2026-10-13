using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoiceTemplatesListSalesRequestFilterItemOp.InvoiceTemplatesListSalesRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct InvoiceTemplatesListSalesRequestFilterItemOp : IStringEnum
{
    public static readonly InvoiceTemplatesListSalesRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly InvoiceTemplatesListSalesRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly InvoiceTemplatesListSalesRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly InvoiceTemplatesListSalesRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly InvoiceTemplatesListSalesRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly InvoiceTemplatesListSalesRequestFilterItemOp In = new(Values.In);

    public InvoiceTemplatesListSalesRequestFilterItemOp(string value)
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
    public static InvoiceTemplatesListSalesRequestFilterItemOp FromCustom(string value)
    {
        return new InvoiceTemplatesListSalesRequestFilterItemOp(value);
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
        InvoiceTemplatesListSalesRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoiceTemplatesListSalesRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTemplatesListSalesRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator InvoiceTemplatesListSalesRequestFilterItemOp(string value) =>
        new(value);

    internal class InvoiceTemplatesListSalesRequestFilterItemOpSerializer
        : JsonConverter<InvoiceTemplatesListSalesRequestFilterItemOp>
    {
        public override InvoiceTemplatesListSalesRequestFilterItemOp Read(
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
            return new InvoiceTemplatesListSalesRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceTemplatesListSalesRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceTemplatesListSalesRequestFilterItemOp ReadAsPropertyName(
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
            return new InvoiceTemplatesListSalesRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceTemplatesListSalesRequestFilterItemOp value,
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
        public const string Eq = "eq";

        public const string Ne = "ne";

        public const string Contains = "contains";

        public const string Gte = "gte";

        public const string Lte = "lte";

        public const string In = "in";
    }
}
