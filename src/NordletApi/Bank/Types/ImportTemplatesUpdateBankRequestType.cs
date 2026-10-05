using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ImportTemplatesUpdateBankRequestType.ImportTemplatesUpdateBankRequestTypeSerializer)
)]
[Serializable]
public readonly record struct ImportTemplatesUpdateBankRequestType : IStringEnum
{
    public static readonly ImportTemplatesUpdateBankRequestType Stripe = new(Values.Stripe);

    public static readonly ImportTemplatesUpdateBankRequestType Iso20022 = new(Values.Iso20022);

    public static readonly ImportTemplatesUpdateBankRequestType BankConnection = new(
        Values.BankConnection
    );

    public ImportTemplatesUpdateBankRequestType(string value)
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
    public static ImportTemplatesUpdateBankRequestType FromCustom(string value)
    {
        return new ImportTemplatesUpdateBankRequestType(value);
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

    public static bool operator ==(ImportTemplatesUpdateBankRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ImportTemplatesUpdateBankRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ImportTemplatesUpdateBankRequestType value) =>
        value.Value;

    public static explicit operator ImportTemplatesUpdateBankRequestType(string value) =>
        new(value);

    internal class ImportTemplatesUpdateBankRequestTypeSerializer
        : JsonConverter<ImportTemplatesUpdateBankRequestType>
    {
        public override ImportTemplatesUpdateBankRequestType Read(
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
            return new ImportTemplatesUpdateBankRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ImportTemplatesUpdateBankRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ImportTemplatesUpdateBankRequestType ReadAsPropertyName(
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
            return new ImportTemplatesUpdateBankRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ImportTemplatesUpdateBankRequestType value,
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
        public const string Stripe = "stripe";

        public const string Iso20022 = "iso20022";

        public const string BankConnection = "bank_connection";
    }
}
