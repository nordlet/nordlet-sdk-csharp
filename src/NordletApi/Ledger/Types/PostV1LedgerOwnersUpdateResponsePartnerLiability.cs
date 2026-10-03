using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerOwnersUpdateResponsePartnerLiability.PostV1LedgerOwnersUpdateResponsePartnerLiabilitySerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerOwnersUpdateResponsePartnerLiability : IStringEnum
{
    public static readonly PostV1LedgerOwnersUpdateResponsePartnerLiability General = new(
        Values.General
    );

    public static readonly PostV1LedgerOwnersUpdateResponsePartnerLiability Limited = new(
        Values.Limited
    );

    public PostV1LedgerOwnersUpdateResponsePartnerLiability(string value)
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
    public static PostV1LedgerOwnersUpdateResponsePartnerLiability FromCustom(string value)
    {
        return new PostV1LedgerOwnersUpdateResponsePartnerLiability(value);
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
        PostV1LedgerOwnersUpdateResponsePartnerLiability value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerOwnersUpdateResponsePartnerLiability value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1LedgerOwnersUpdateResponsePartnerLiability value
    ) => value.Value;

    public static explicit operator PostV1LedgerOwnersUpdateResponsePartnerLiability(
        string value
    ) => new(value);

    internal class PostV1LedgerOwnersUpdateResponsePartnerLiabilitySerializer
        : JsonConverter<PostV1LedgerOwnersUpdateResponsePartnerLiability>
    {
        public override PostV1LedgerOwnersUpdateResponsePartnerLiability Read(
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
            return new PostV1LedgerOwnersUpdateResponsePartnerLiability(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerOwnersUpdateResponsePartnerLiability value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerOwnersUpdateResponsePartnerLiability ReadAsPropertyName(
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
            return new PostV1LedgerOwnersUpdateResponsePartnerLiability(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerOwnersUpdateResponsePartnerLiability value,
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
