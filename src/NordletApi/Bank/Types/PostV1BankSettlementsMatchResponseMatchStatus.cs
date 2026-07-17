using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankSettlementsMatchResponseMatchStatus.PostV1BankSettlementsMatchResponseMatchStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1BankSettlementsMatchResponseMatchStatus : IStringEnum
{
    public static readonly PostV1BankSettlementsMatchResponseMatchStatus Unmatched = new(
        Values.Unmatched
    );

    public static readonly PostV1BankSettlementsMatchResponseMatchStatus Matched = new(
        Values.Matched
    );

    public static readonly PostV1BankSettlementsMatchResponseMatchStatus Manual = new(
        Values.Manual
    );

    public PostV1BankSettlementsMatchResponseMatchStatus(string value)
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
    public static PostV1BankSettlementsMatchResponseMatchStatus FromCustom(string value)
    {
        return new PostV1BankSettlementsMatchResponseMatchStatus(value);
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
        PostV1BankSettlementsMatchResponseMatchStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankSettlementsMatchResponseMatchStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankSettlementsMatchResponseMatchStatus value) =>
        value.Value;

    public static explicit operator PostV1BankSettlementsMatchResponseMatchStatus(string value) =>
        new(value);

    internal class PostV1BankSettlementsMatchResponseMatchStatusSerializer
        : JsonConverter<PostV1BankSettlementsMatchResponseMatchStatus>
    {
        public override PostV1BankSettlementsMatchResponseMatchStatus Read(
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
            return new PostV1BankSettlementsMatchResponseMatchStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankSettlementsMatchResponseMatchStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankSettlementsMatchResponseMatchStatus ReadAsPropertyName(
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
            return new PostV1BankSettlementsMatchResponseMatchStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankSettlementsMatchResponseMatchStatus value,
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
