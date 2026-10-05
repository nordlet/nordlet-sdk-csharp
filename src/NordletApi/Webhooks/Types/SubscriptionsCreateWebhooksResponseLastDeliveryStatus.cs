using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubscriptionsCreateWebhooksResponseLastDeliveryStatus.SubscriptionsCreateWebhooksResponseLastDeliveryStatusSerializer)
)]
[Serializable]
public readonly record struct SubscriptionsCreateWebhooksResponseLastDeliveryStatus : IStringEnum
{
    public static readonly SubscriptionsCreateWebhooksResponseLastDeliveryStatus Pending = new(
        Values.Pending
    );

    public static readonly SubscriptionsCreateWebhooksResponseLastDeliveryStatus Delivered = new(
        Values.Delivered
    );

    public static readonly SubscriptionsCreateWebhooksResponseLastDeliveryStatus Failed = new(
        Values.Failed
    );

    public SubscriptionsCreateWebhooksResponseLastDeliveryStatus(string value)
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
    public static SubscriptionsCreateWebhooksResponseLastDeliveryStatus FromCustom(string value)
    {
        return new SubscriptionsCreateWebhooksResponseLastDeliveryStatus(value);
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
        SubscriptionsCreateWebhooksResponseLastDeliveryStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubscriptionsCreateWebhooksResponseLastDeliveryStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SubscriptionsCreateWebhooksResponseLastDeliveryStatus value
    ) => value.Value;

    public static explicit operator SubscriptionsCreateWebhooksResponseLastDeliveryStatus(
        string value
    ) => new(value);

    internal class SubscriptionsCreateWebhooksResponseLastDeliveryStatusSerializer
        : JsonConverter<SubscriptionsCreateWebhooksResponseLastDeliveryStatus>
    {
        public override SubscriptionsCreateWebhooksResponseLastDeliveryStatus Read(
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
            return new SubscriptionsCreateWebhooksResponseLastDeliveryStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubscriptionsCreateWebhooksResponseLastDeliveryStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubscriptionsCreateWebhooksResponseLastDeliveryStatus ReadAsPropertyName(
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
            return new SubscriptionsCreateWebhooksResponseLastDeliveryStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubscriptionsCreateWebhooksResponseLastDeliveryStatus value,
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

        public const string Delivered = "delivered";

        public const string Failed = "failed";
    }
}
