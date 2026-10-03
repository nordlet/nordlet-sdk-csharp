using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerOwnersCreateResponsePartnerLiability.PostV1LedgerOwnersCreateResponsePartnerLiabilitySerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerOwnersCreateResponsePartnerLiability : IStringEnum
{
    public static readonly PostV1LedgerOwnersCreateResponsePartnerLiability General = new(
        Values.General
    );

    public static readonly PostV1LedgerOwnersCreateResponsePartnerLiability Limited = new(
        Values.Limited
    );

    public PostV1LedgerOwnersCreateResponsePartnerLiability(string value)
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
    public static PostV1LedgerOwnersCreateResponsePartnerLiability FromCustom(string value)
    {
        return new PostV1LedgerOwnersCreateResponsePartnerLiability(value);
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
        PostV1LedgerOwnersCreateResponsePartnerLiability value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerOwnersCreateResponsePartnerLiability value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1LedgerOwnersCreateResponsePartnerLiability value
    ) => value.Value;

    public static explicit operator PostV1LedgerOwnersCreateResponsePartnerLiability(
        string value
    ) => new(value);

    internal class PostV1LedgerOwnersCreateResponsePartnerLiabilitySerializer
        : JsonConverter<PostV1LedgerOwnersCreateResponsePartnerLiability>
    {
        public override PostV1LedgerOwnersCreateResponsePartnerLiability Read(
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
            return new PostV1LedgerOwnersCreateResponsePartnerLiability(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerOwnersCreateResponsePartnerLiability value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerOwnersCreateResponsePartnerLiability ReadAsPropertyName(
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
            return new PostV1LedgerOwnersCreateResponsePartnerLiability(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerOwnersCreateResponsePartnerLiability value,
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
        public const string General = "general";

        public const string Limited = "limited";
    }
}
