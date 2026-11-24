using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatAccountsReportsResponseAccountsItemSide.VatAccountsReportsResponseAccountsItemSideSerializer)
)]
[Serializable]
public readonly record struct VatAccountsReportsResponseAccountsItemSide : IStringEnum
{
    public static readonly VatAccountsReportsResponseAccountsItemSide Payable = new(Values.Payable);

    public static readonly VatAccountsReportsResponseAccountsItemSide Receivable = new(
        Values.Receivable
    );

    public VatAccountsReportsResponseAccountsItemSide(string value)
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
    public static VatAccountsReportsResponseAccountsItemSide FromCustom(string value)
    {
        return new VatAccountsReportsResponseAccountsItemSide(value);
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
        VatAccountsReportsResponseAccountsItemSide value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VatAccountsReportsResponseAccountsItemSide value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VatAccountsReportsResponseAccountsItemSide value) =>
        value.Value;

    public static explicit operator VatAccountsReportsResponseAccountsItemSide(string value) =>
        new(value);

    internal class VatAccountsReportsResponseAccountsItemSideSerializer
        : JsonConverter<VatAccountsReportsResponseAccountsItemSide>
    {
        public override VatAccountsReportsResponseAccountsItemSide Read(
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
            return new VatAccountsReportsResponseAccountsItemSide(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatAccountsReportsResponseAccountsItemSide value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatAccountsReportsResponseAccountsItemSide ReadAsPropertyName(
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
            return new VatAccountsReportsResponseAccountsItemSide(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatAccountsReportsResponseAccountsItemSide value,
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
        public const string Payable = "payable";

        public const string Receivable = "receivable";
    }
}
