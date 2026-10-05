using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeliveriesListWebhooksResponseRowsItemStatus.DeliveriesListWebhooksResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct DeliveriesListWebhooksResponseRowsItemStatus : IStringEnum
{
    public static readonly DeliveriesListWebhooksResponseRowsItemStatus Pending = new(
        Values.Pending
    );

    public static readonly DeliveriesListWebhooksResponseRowsItemStatus Delivered = new(
        Values.Delivered
    );

    public static readonly DeliveriesListWebhooksResponseRowsItemStatus Failed = new(Values.Failed);

    public DeliveriesListWebhooksResponseRowsItemStatus(string value)
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
    public static DeliveriesListWebhooksResponseRowsItemStatus FromCustom(string value)
    {
        return new DeliveriesListWebhooksResponseRowsItemStatus(value);
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
        DeliveriesListWebhooksResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeliveriesListWebhooksResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DeliveriesListWebhooksResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator DeliveriesListWebhooksResponseRowsItemStatus(string value) =>
        new(value);

    internal class DeliveriesListWebhooksResponseRowsItemStatusSerializer
        : JsonConverter<DeliveriesListWebhooksResponseRowsItemStatus>
    {
        public override DeliveriesListWebhooksResponseRowsItemStatus Read(
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
            return new DeliveriesListWebhooksResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeliveriesListWebhooksResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeliveriesListWebhooksResponseRowsItemStatus ReadAsPropertyName(
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
            return new DeliveriesListWebhooksResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeliveriesListWebhooksResponseRowsItemStatus value,
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
