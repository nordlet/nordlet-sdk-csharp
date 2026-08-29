using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BillingTransactionsListResponseRowsItemType.PostV1BillingTransactionsListResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BillingTransactionsListResponseRowsItemType : IStringEnum
{
    public static readonly PostV1BillingTransactionsListResponseRowsItemType TrialGrant = new(
        Values.TrialGrant
    );

    public static readonly PostV1BillingTransactionsListResponseRowsItemType Topup = new(
        Values.Topup
    );

    public static readonly PostV1BillingTransactionsListResponseRowsItemType Usage = new(
        Values.Usage
    );

    public static readonly PostV1BillingTransactionsListResponseRowsItemType Activation = new(
        Values.Activation
    );

    public static readonly PostV1BillingTransactionsListResponseRowsItemType Adjustment = new(
        Values.Adjustment
    );

    public PostV1BillingTransactionsListResponseRowsItemType(string value)
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
    public static PostV1BillingTransactionsListResponseRowsItemType FromCustom(string value)
    {
        return new PostV1BillingTransactionsListResponseRowsItemType(value);
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
        PostV1BillingTransactionsListResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BillingTransactionsListResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BillingTransactionsListResponseRowsItemType value
    ) => value.Value;

    public static explicit operator PostV1BillingTransactionsListResponseRowsItemType(
        string value
    ) => new(value);

    internal class PostV1BillingTransactionsListResponseRowsItemTypeSerializer
        : JsonConverter<PostV1BillingTransactionsListResponseRowsItemType>
    {
        public override PostV1BillingTransactionsListResponseRowsItemType Read(
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
            return new PostV1BillingTransactionsListResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BillingTransactionsListResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BillingTransactionsListResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1BillingTransactionsListResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BillingTransactionsListResponseRowsItemType value,
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
        public const string TrialGrant = "trial_grant";

        public const string Topup = "topup";

        public const string Usage = "usage";

        public const string Activation = "activation";

        public const string Adjustment = "adjustment";
    }
}
