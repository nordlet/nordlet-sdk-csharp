using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankSettlementsCommissionResponseMatchStatus.PostV1BankSettlementsCommissionResponseMatchStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1BankSettlementsCommissionResponseMatchStatus : IStringEnum
{
    public static readonly PostV1BankSettlementsCommissionResponseMatchStatus Unmatched = new(
        Values.Unmatched
    );

    public static readonly PostV1BankSettlementsCommissionResponseMatchStatus Matched = new(
        Values.Matched
    );

    public static readonly PostV1BankSettlementsCommissionResponseMatchStatus Manual = new(
        Values.Manual
    );

    public PostV1BankSettlementsCommissionResponseMatchStatus(string value)
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
    public static PostV1BankSettlementsCommissionResponseMatchStatus FromCustom(string value)
    {
        return new PostV1BankSettlementsCommissionResponseMatchStatus(value);
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
        PostV1BankSettlementsCommissionResponseMatchStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankSettlementsCommissionResponseMatchStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankSettlementsCommissionResponseMatchStatus value
    ) => value.Value;

    public static explicit operator PostV1BankSettlementsCommissionResponseMatchStatus(
        string value
    ) => new(value);

    internal class PostV1BankSettlementsCommissionResponseMatchStatusSerializer
        : JsonConverter<PostV1BankSettlementsCommissionResponseMatchStatus>
    {
        public override PostV1BankSettlementsCommissionResponseMatchStatus Read(
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
            return new PostV1BankSettlementsCommissionResponseMatchStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankSettlementsCommissionResponseMatchStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankSettlementsCommissionResponseMatchStatus ReadAsPropertyName(
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
            return new PostV1BankSettlementsCommissionResponseMatchStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankSettlementsCommissionResponseMatchStatus value,
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
        public const string Unmatched = "unmatched";

        public const string Matched = "matched";

        public const string Manual = "manual";
    }
}
