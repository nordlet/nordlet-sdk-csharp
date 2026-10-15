using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ImportTemplatesListBuiltinBankResponseRowsItemType.ImportTemplatesListBuiltinBankResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct ImportTemplatesListBuiltinBankResponseRowsItemType : IStringEnum
{
    public static readonly ImportTemplatesListBuiltinBankResponseRowsItemType Stripe = new(
        Values.Stripe
    );

    public static readonly ImportTemplatesListBuiltinBankResponseRowsItemType Iso20022 = new(
        Values.Iso20022
    );

    public static readonly ImportTemplatesListBuiltinBankResponseRowsItemType BankConnection = new(
        Values.BankConnection
    );

    public static readonly ImportTemplatesListBuiltinBankResponseRowsItemType Revolut = new(
        Values.Revolut
    );

    public ImportTemplatesListBuiltinBankResponseRowsItemType(string value)
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
    public static ImportTemplatesListBuiltinBankResponseRowsItemType FromCustom(string value)
    {
        return new ImportTemplatesListBuiltinBankResponseRowsItemType(value);
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
        ImportTemplatesListBuiltinBankResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ImportTemplatesListBuiltinBankResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ImportTemplatesListBuiltinBankResponseRowsItemType value
    ) => value.Value;

    public static explicit operator ImportTemplatesListBuiltinBankResponseRowsItemType(
        string value
    ) => new(value);

    internal class ImportTemplatesListBuiltinBankResponseRowsItemTypeSerializer
        : JsonConverter<ImportTemplatesListBuiltinBankResponseRowsItemType>
    {
        public override ImportTemplatesListBuiltinBankResponseRowsItemType Read(
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
            return new ImportTemplatesListBuiltinBankResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ImportTemplatesListBuiltinBankResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ImportTemplatesListBuiltinBankResponseRowsItemType ReadAsPropertyName(
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
            return new ImportTemplatesListBuiltinBankResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ImportTemplatesListBuiltinBankResponseRowsItemType value,
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

        public const string Revolut = "revolut";
    }
}
