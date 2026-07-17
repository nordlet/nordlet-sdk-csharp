using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReportsTrialBalanceResponseRowsItemType.PostV1ReportsTrialBalanceResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1ReportsTrialBalanceResponseRowsItemType : IStringEnum
{
    public static readonly PostV1ReportsTrialBalanceResponseRowsItemType Asset = new(Values.Asset);

    public static readonly PostV1ReportsTrialBalanceResponseRowsItemType Liability = new(
        Values.Liability
    );

    public static readonly PostV1ReportsTrialBalanceResponseRowsItemType Equity = new(
        Values.Equity
    );

    public static readonly PostV1ReportsTrialBalanceResponseRowsItemType Income = new(
        Values.Income
    );

    public static readonly PostV1ReportsTrialBalanceResponseRowsItemType Expense = new(
        Values.Expense
    );

    public PostV1ReportsTrialBalanceResponseRowsItemType(string value)
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
    public static PostV1ReportsTrialBalanceResponseRowsItemType FromCustom(string value)
    {
        return new PostV1ReportsTrialBalanceResponseRowsItemType(value);
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
        PostV1ReportsTrialBalanceResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReportsTrialBalanceResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReportsTrialBalanceResponseRowsItemType value) =>
        value.Value;

    public static explicit operator PostV1ReportsTrialBalanceResponseRowsItemType(string value) =>
        new(value);

    internal class PostV1ReportsTrialBalanceResponseRowsItemTypeSerializer
        : JsonConverter<PostV1ReportsTrialBalanceResponseRowsItemType>
    {
        public override PostV1ReportsTrialBalanceResponseRowsItemType Read(
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
            return new PostV1ReportsTrialBalanceResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReportsTrialBalanceResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReportsTrialBalanceResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1ReportsTrialBalanceResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReportsTrialBalanceResponseRowsItemType value,
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
        public const string Asset = "asset";

        public const string Liability = "liability";

        public const string Equity = "equity";

        public const string Income = "income";

        public const string Expense = "expense";
    }
}
