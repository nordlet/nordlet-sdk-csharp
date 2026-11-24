using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(QueueListReviewResponseItemsItemKind.QueueListReviewResponseItemsItemKindSerializer)
)]
[Serializable]
public readonly record struct QueueListReviewResponseItemsItemKind : IStringEnum
{
    public static readonly QueueListReviewResponseItemsItemKind DraftWarning = new(
        Values.DraftWarning
    );

    public static readonly QueueListReviewResponseItemsItemKind BankTransactionUnbooked = new(
        Values.BankTransactionUnbooked
    );

    public static readonly QueueListReviewResponseItemsItemKind PartnerVatInvalid = new(
        Values.PartnerVatInvalid
    );

    public static readonly QueueListReviewResponseItemsItemKind FilingSettingsMissing = new(
        Values.FilingSettingsMissing
    );

    public static readonly QueueListReviewResponseItemsItemKind FileUnattached = new(
        Values.FileUnattached
    );

    public QueueListReviewResponseItemsItemKind(string value)
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
    public static QueueListReviewResponseItemsItemKind FromCustom(string value)
    {
        return new QueueListReviewResponseItemsItemKind(value);
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

    public static bool operator ==(QueueListReviewResponseItemsItemKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(QueueListReviewResponseItemsItemKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(QueueListReviewResponseItemsItemKind value) =>
        value.Value;

    public static explicit operator QueueListReviewResponseItemsItemKind(string value) =>
        new(value);

    internal class QueueListReviewResponseItemsItemKindSerializer
        : JsonConverter<QueueListReviewResponseItemsItemKind>
    {
        public override QueueListReviewResponseItemsItemKind Read(
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
            return new QueueListReviewResponseItemsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            QueueListReviewResponseItemsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override QueueListReviewResponseItemsItemKind ReadAsPropertyName(
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
            return new QueueListReviewResponseItemsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            QueueListReviewResponseItemsItemKind value,
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
        public const string DraftWarning = "draft_warning";

        public const string BankTransactionUnbooked = "bank_transaction_unbooked";

        public const string PartnerVatInvalid = "partner_vat_invalid";

        public const string FilingSettingsMissing = "filing_settings_missing";

        public const string FileUnattached = "file_unattached";
    }
}
