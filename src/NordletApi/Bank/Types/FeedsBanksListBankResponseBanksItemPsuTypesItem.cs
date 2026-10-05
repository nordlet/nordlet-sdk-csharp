using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsBanksListBankResponseBanksItemPsuTypesItem.FeedsBanksListBankResponseBanksItemPsuTypesItemSerializer)
)]
[Serializable]
public readonly record struct FeedsBanksListBankResponseBanksItemPsuTypesItem : IStringEnum
{
    public static readonly FeedsBanksListBankResponseBanksItemPsuTypesItem Business = new(
        Values.Business
    );

    public static readonly FeedsBanksListBankResponseBanksItemPsuTypesItem Personal = new(
        Values.Personal
    );

    public FeedsBanksListBankResponseBanksItemPsuTypesItem(string value)
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
    public static FeedsBanksListBankResponseBanksItemPsuTypesItem FromCustom(string value)
    {
        return new FeedsBanksListBankResponseBanksItemPsuTypesItem(value);
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
        FeedsBanksListBankResponseBanksItemPsuTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FeedsBanksListBankResponseBanksItemPsuTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FeedsBanksListBankResponseBanksItemPsuTypesItem value) =>
        value.Value;

    public static explicit operator FeedsBanksListBankResponseBanksItemPsuTypesItem(string value) =>
        new(value);

    internal class FeedsBanksListBankResponseBanksItemPsuTypesItemSerializer
        : JsonConverter<FeedsBanksListBankResponseBanksItemPsuTypesItem>
    {
        public override FeedsBanksListBankResponseBanksItemPsuTypesItem Read(
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
            return new FeedsBanksListBankResponseBanksItemPsuTypesItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsBanksListBankResponseBanksItemPsuTypesItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsBanksListBankResponseBanksItemPsuTypesItem ReadAsPropertyName(
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
            return new FeedsBanksListBankResponseBanksItemPsuTypesItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsBanksListBankResponseBanksItemPsuTypesItem value,
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
        public const string Business = "business";

        public const string Personal = "personal";
    }
}
