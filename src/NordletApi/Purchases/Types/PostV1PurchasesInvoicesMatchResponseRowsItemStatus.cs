using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesInvoicesMatchResponseRowsItemStatus.PostV1PurchasesInvoicesMatchResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesInvoicesMatchResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1PurchasesInvoicesMatchResponseRowsItemStatus Matched = new(
        Values.Matched
    );

    public static readonly PostV1PurchasesInvoicesMatchResponseRowsItemStatus NotReceived = new(
        Values.NotReceived
    );

    public static readonly PostV1PurchasesInvoicesMatchResponseRowsItemStatus OverInvoiced = new(
        Values.OverInvoiced
    );

    public static readonly PostV1PurchasesInvoicesMatchResponseRowsItemStatus PriceMismatch = new(
        Values.PriceMismatch
    );

    public static readonly PostV1PurchasesInvoicesMatchResponseRowsItemStatus NotOnOrder = new(
        Values.NotOnOrder
    );

    public static readonly PostV1PurchasesInvoicesMatchResponseRowsItemStatus NotInvoiced = new(
        Values.NotInvoiced
    );

    public PostV1PurchasesInvoicesMatchResponseRowsItemStatus(string value)
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
    public static PostV1PurchasesInvoicesMatchResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1PurchasesInvoicesMatchResponseRowsItemStatus(value);
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
        PostV1PurchasesInvoicesMatchResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesInvoicesMatchResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PurchasesInvoicesMatchResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator PostV1PurchasesInvoicesMatchResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class PostV1PurchasesInvoicesMatchResponseRowsItemStatusSerializer
        : JsonConverter<PostV1PurchasesInvoicesMatchResponseRowsItemStatus>
    {
        public override PostV1PurchasesInvoicesMatchResponseRowsItemStatus Read(
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
            return new PostV1PurchasesInvoicesMatchResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesMatchResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesInvoicesMatchResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1PurchasesInvoicesMatchResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesMatchResponseRowsItemStatus value,
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
        public const string Matched = "matched";

        public const string NotReceived = "not_received";

        public const string OverInvoiced = "over_invoiced";

        public const string PriceMismatch = "price_mismatch";

        public const string NotOnOrder = "not_on_order";

        public const string NotInvoiced = "not_invoiced";
    }
}
