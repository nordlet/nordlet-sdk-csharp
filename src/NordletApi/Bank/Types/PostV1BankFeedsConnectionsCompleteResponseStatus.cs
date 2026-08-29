using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankFeedsConnectionsCompleteResponseStatus.PostV1BankFeedsConnectionsCompleteResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1BankFeedsConnectionsCompleteResponseStatus : IStringEnum
{
    public static readonly PostV1BankFeedsConnectionsCompleteResponseStatus Pending = new(
        Values.Pending
    );

    public static readonly PostV1BankFeedsConnectionsCompleteResponseStatus Active = new(
        Values.Active
    );

    public static readonly PostV1BankFeedsConnectionsCompleteResponseStatus Expired = new(
        Values.Expired
    );

    public static readonly PostV1BankFeedsConnectionsCompleteResponseStatus Revoked = new(
        Values.Revoked
    );

    public static readonly PostV1BankFeedsConnectionsCompleteResponseStatus Error = new(
        Values.Error
    );

    public PostV1BankFeedsConnectionsCompleteResponseStatus(string value)
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
    public static PostV1BankFeedsConnectionsCompleteResponseStatus FromCustom(string value)
    {
        return new PostV1BankFeedsConnectionsCompleteResponseStatus(value);
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
        PostV1BankFeedsConnectionsCompleteResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankFeedsConnectionsCompleteResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankFeedsConnectionsCompleteResponseStatus value
    ) => value.Value;

    public static explicit operator PostV1BankFeedsConnectionsCompleteResponseStatus(
        string value
    ) => new(value);

    internal class PostV1BankFeedsConnectionsCompleteResponseStatusSerializer
        : JsonConverter<PostV1BankFeedsConnectionsCompleteResponseStatus>
    {
        public override PostV1BankFeedsConnectionsCompleteResponseStatus Read(
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
            return new PostV1BankFeedsConnectionsCompleteResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsCompleteResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankFeedsConnectionsCompleteResponseStatus ReadAsPropertyName(
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
            return new PostV1BankFeedsConnectionsCompleteResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsCompleteResponseStatus value,
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
        public const string Pending = "pending";

        public const string Active = "active";

        public const string Expired = "expired";

        public const string Revoked = "revoked";

        public const string Error = "error";
    }
}
