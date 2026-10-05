using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesListPurchasesResponseRowsItemStatus.InvoicesListPurchasesResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesListPurchasesResponseRowsItemStatus : IStringEnum
{
    public static readonly InvoicesListPurchasesResponseRowsItemStatus Draft = new(Values.Draft);

    public static readonly InvoicesListPurchasesResponseRowsItemStatus Registered = new(
        Values.Registered
    );

    public InvoicesListPurchasesResponseRowsItemStatus(string value)
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
    public static InvoicesListPurchasesResponseRowsItemStatus FromCustom(string value)
    {
        return new InvoicesListPurchasesResponseRowsItemStatus(value);
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
        InvoicesListPurchasesResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesListPurchasesResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListPurchasesResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator InvoicesListPurchasesResponseRowsItemStatus(string value) =>
        new(value);

    internal class InvoicesListPurchasesResponseRowsItemStatusSerializer
        : JsonConverter<InvoicesListPurchasesResponseRowsItemStatus>
    {
        public override InvoicesListPurchasesResponseRowsItemStatus Read(
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
            return new InvoicesListPurchasesResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesListPurchasesResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesListPurchasesResponseRowsItemStatus ReadAsPropertyName(
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
            return new InvoicesListPurchasesResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesListPurchasesResponseRowsItemStatus value,
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
        public const string Draft = "draft";

        public const string Registered = "registered";
    }
}
