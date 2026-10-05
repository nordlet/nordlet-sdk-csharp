using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsListBillingResponseRowsItemType.TransactionsListBillingResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct TransactionsListBillingResponseRowsItemType : IStringEnum
{
    public static readonly TransactionsListBillingResponseRowsItemType TrialGrant = new(
        Values.TrialGrant
    );

    public static readonly TransactionsListBillingResponseRowsItemType Topup = new(Values.Topup);

    public static readonly TransactionsListBillingResponseRowsItemType Usage = new(Values.Usage);

    public static readonly TransactionsListBillingResponseRowsItemType Activation = new(
        Values.Activation
    );

    public static readonly TransactionsListBillingResponseRowsItemType Adjustment = new(
        Values.Adjustment
    );

    public TransactionsListBillingResponseRowsItemType(string value)
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
    public static TransactionsListBillingResponseRowsItemType FromCustom(string value)
    {
        return new TransactionsListBillingResponseRowsItemType(value);
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
        TransactionsListBillingResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TransactionsListBillingResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsListBillingResponseRowsItemType value) =>
        value.Value;

    public static explicit operator TransactionsListBillingResponseRowsItemType(string value) =>
        new(value);

    internal class TransactionsListBillingResponseRowsItemTypeSerializer
        : JsonConverter<TransactionsListBillingResponseRowsItemType>
    {
        public override TransactionsListBillingResponseRowsItemType Read(
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
            return new TransactionsListBillingResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsListBillingResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsListBillingResponseRowsItemType ReadAsPropertyName(
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
            return new TransactionsListBillingResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsListBillingResponseRowsItemType value,
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
