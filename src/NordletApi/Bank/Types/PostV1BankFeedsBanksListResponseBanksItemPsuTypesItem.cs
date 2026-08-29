using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem.PostV1BankFeedsBanksListResponseBanksItemPsuTypesItemSerializer)
)]
[Serializable]
public readonly record struct PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem : IStringEnum
{
    public static readonly PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem Business = new(
        Values.Business
    );

    public static readonly PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem Personal = new(
        Values.Personal
    );

    public PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem(string value)
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
    public static PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem FromCustom(string value)
    {
        return new PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem(value);
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
        PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem value
    ) => value.Value;

    public static explicit operator PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem(
        string value
    ) => new(value);

    internal class PostV1BankFeedsBanksListResponseBanksItemPsuTypesItemSerializer
        : JsonConverter<PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem>
    {
        public override PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem Read(
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
            return new PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem ReadAsPropertyName(
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
            return new PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankFeedsBanksListResponseBanksItemPsuTypesItem value,
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
