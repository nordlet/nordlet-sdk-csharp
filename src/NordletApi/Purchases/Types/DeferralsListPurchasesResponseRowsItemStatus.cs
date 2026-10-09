using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeferralsListPurchasesResponseRowsItemStatus.DeferralsListPurchasesResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct DeferralsListPurchasesResponseRowsItemStatus : IStringEnum
{
    public static readonly DeferralsListPurchasesResponseRowsItemStatus Pending = new(
        Values.Pending
    );

    public static readonly DeferralsListPurchasesResponseRowsItemStatus Posted = new(Values.Posted);

    public static readonly DeferralsListPurchasesResponseRowsItemStatus Cancelled = new(
        Values.Cancelled
    );

    public DeferralsListPurchasesResponseRowsItemStatus(string value)
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
    public static DeferralsListPurchasesResponseRowsItemStatus FromCustom(string value)
    {
        return new DeferralsListPurchasesResponseRowsItemStatus(value);
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
        DeferralsListPurchasesResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeferralsListPurchasesResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DeferralsListPurchasesResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator DeferralsListPurchasesResponseRowsItemStatus(string value) =>
        new(value);

    internal class DeferralsListPurchasesResponseRowsItemStatusSerializer
        : JsonConverter<DeferralsListPurchasesResponseRowsItemStatus>
    {
        public override DeferralsListPurchasesResponseRowsItemStatus Read(
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
            return new DeferralsListPurchasesResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeferralsListPurchasesResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeferralsListPurchasesResponseRowsItemStatus ReadAsPropertyName(
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
            return new DeferralsListPurchasesResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeferralsListPurchasesResponseRowsItemStatus value,
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
        public const string Pending = "pending";

        public const string Posted = "posted";

        public const string Cancelled = "cancelled";
    }
}
