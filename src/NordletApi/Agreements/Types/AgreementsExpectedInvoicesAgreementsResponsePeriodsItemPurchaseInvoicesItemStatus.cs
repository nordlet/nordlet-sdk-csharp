using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus.AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatusSerializer)
)]
[Serializable]
public readonly record struct AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus
    : IStringEnum
{
    public static readonly AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus Draft =
        new(Values.Draft);

    public static readonly AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus Registered =
        new(Values.Registered);

    public static readonly AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus Reversed =
        new(Values.Reversed);

    public AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus(
        string value
    )
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
    public static AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus FromCustom(
        string value
    )
    {
        return new AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus(
            value
        );
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
        AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus value
    ) => value.Value;

    public static explicit operator AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus(
        string value
    ) => new(value);

    internal class AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatusSerializer
        : JsonConverter<AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus>
    {
        public override AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus Read(
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
            return new AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus ReadAsPropertyName(
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
            return new AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsExpectedInvoicesAgreementsResponsePeriodsItemPurchaseInvoicesItemStatus value,
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

        public const string Reversed = "reversed";
    }
}
