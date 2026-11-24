using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatAccountsReportsResponseAccountsItemRulesItem.VatAccountsReportsResponseAccountsItemRulesItemSerializer)
)]
[Serializable]
public readonly record struct VatAccountsReportsResponseAccountsItemRulesItem : IStringEnum
{
    public static readonly VatAccountsReportsResponseAccountsItemRulesItem SalesVatPayable = new(
        Values.SalesVatPayable
    );

    public static readonly VatAccountsReportsResponseAccountsItemRulesItem SalesOssVatPayable = new(
        Values.SalesOssVatPayable
    );

    public static readonly VatAccountsReportsResponseAccountsItemRulesItem PurchasesVatReceivable =
        new(Values.PurchasesVatReceivable);

    public VatAccountsReportsResponseAccountsItemRulesItem(string value)
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
    public static VatAccountsReportsResponseAccountsItemRulesItem FromCustom(string value)
    {
        return new VatAccountsReportsResponseAccountsItemRulesItem(value);
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
        VatAccountsReportsResponseAccountsItemRulesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VatAccountsReportsResponseAccountsItemRulesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VatAccountsReportsResponseAccountsItemRulesItem value) =>
        value.Value;

    public static explicit operator VatAccountsReportsResponseAccountsItemRulesItem(string value) =>
        new(value);

    internal class VatAccountsReportsResponseAccountsItemRulesItemSerializer
        : JsonConverter<VatAccountsReportsResponseAccountsItemRulesItem>
    {
        public override VatAccountsReportsResponseAccountsItemRulesItem Read(
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
            return new VatAccountsReportsResponseAccountsItemRulesItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatAccountsReportsResponseAccountsItemRulesItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatAccountsReportsResponseAccountsItemRulesItem ReadAsPropertyName(
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
            return new VatAccountsReportsResponseAccountsItemRulesItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatAccountsReportsResponseAccountsItemRulesItem value,
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
        public const string SalesVatPayable = "sales.vatPayable";

        public const string SalesOssVatPayable = "sales.ossVatPayable";

        public const string PurchasesVatReceivable = "purchases.vatReceivable";
    }
}
