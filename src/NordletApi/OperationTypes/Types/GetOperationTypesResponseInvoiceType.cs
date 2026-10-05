using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GetOperationTypesResponseInvoiceType.GetOperationTypesResponseInvoiceTypeSerializer)
)]
[Serializable]
public readonly record struct GetOperationTypesResponseInvoiceType : IStringEnum
{
    public static readonly GetOperationTypesResponseInvoiceType Invoice = new(Values.Invoice);

    public static readonly GetOperationTypesResponseInvoiceType CreditNote = new(Values.CreditNote);

    public static readonly GetOperationTypesResponseInvoiceType Proforma = new(Values.Proforma);

    public static readonly GetOperationTypesResponseInvoiceType Advance = new(Values.Advance);

    public GetOperationTypesResponseInvoiceType(string value)
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
    public static GetOperationTypesResponseInvoiceType FromCustom(string value)
    {
        return new GetOperationTypesResponseInvoiceType(value);
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

    public static bool operator ==(GetOperationTypesResponseInvoiceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetOperationTypesResponseInvoiceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetOperationTypesResponseInvoiceType value) =>
        value.Value;

    public static explicit operator GetOperationTypesResponseInvoiceType(string value) =>
        new(value);

    internal class GetOperationTypesResponseInvoiceTypeSerializer
        : JsonConverter<GetOperationTypesResponseInvoiceType>
    {
        public override GetOperationTypesResponseInvoiceType Read(
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
            return new GetOperationTypesResponseInvoiceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetOperationTypesResponseInvoiceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetOperationTypesResponseInvoiceType ReadAsPropertyName(
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
            return new GetOperationTypesResponseInvoiceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetOperationTypesResponseInvoiceType value,
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
        public const string Invoice = "invoice";

        public const string CreditNote = "credit_note";

        public const string Proforma = "proforma";

        public const string Advance = "advance";
    }
}
