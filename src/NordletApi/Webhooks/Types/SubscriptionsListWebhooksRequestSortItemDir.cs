using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubscriptionsListWebhooksRequestSortItemDir.SubscriptionsListWebhooksRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct SubscriptionsListWebhooksRequestSortItemDir : IStringEnum
{
    public static readonly SubscriptionsListWebhooksRequestSortItemDir Asc = new(Values.Asc);

    public static readonly SubscriptionsListWebhooksRequestSortItemDir Desc = new(Values.Desc);

    public SubscriptionsListWebhooksRequestSortItemDir(string value)
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
    public static SubscriptionsListWebhooksRequestSortItemDir FromCustom(string value)
    {
        return new SubscriptionsListWebhooksRequestSortItemDir(value);
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
        SubscriptionsListWebhooksRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubscriptionsListWebhooksRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubscriptionsListWebhooksRequestSortItemDir value) =>
        value.Value;

    public static explicit operator SubscriptionsListWebhooksRequestSortItemDir(string value) =>
        new(value);

    internal class SubscriptionsListWebhooksRequestSortItemDirSerializer
        : JsonConverter<SubscriptionsListWebhooksRequestSortItemDir>
    {
        public override SubscriptionsListWebhooksRequestSortItemDir Read(
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
            return new SubscriptionsListWebhooksRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubscriptionsListWebhooksRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubscriptionsListWebhooksRequestSortItemDir ReadAsPropertyName(
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
            return new SubscriptionsListWebhooksRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubscriptionsListWebhooksRequestSortItemDir value,
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
        public const string Asc = "asc";

        public const string Desc = "desc";
    }
}
