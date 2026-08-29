using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankFeedsConnectionsListResponseRowsItemStatus.PostV1BankFeedsConnectionsListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1BankFeedsConnectionsListResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1BankFeedsConnectionsListResponseRowsItemStatus Pending = new(
        Values.Pending
    );

    public static readonly PostV1BankFeedsConnectionsListResponseRowsItemStatus Active = new(
        Values.Active
    );

    public static readonly PostV1BankFeedsConnectionsListResponseRowsItemStatus Expired = new(
        Values.Expired
    );

    public static readonly PostV1BankFeedsConnectionsListResponseRowsItemStatus Revoked = new(
        Values.Revoked
    );

    public static readonly PostV1BankFeedsConnectionsListResponseRowsItemStatus Error = new(
        Values.Error
    );

    public PostV1BankFeedsConnectionsListResponseRowsItemStatus(string value)
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
    public static PostV1BankFeedsConnectionsListResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1BankFeedsConnectionsListResponseRowsItemStatus(value);
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
        PostV1BankFeedsConnectionsListResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankFeedsConnectionsListResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankFeedsConnectionsListResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator PostV1BankFeedsConnectionsListResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class PostV1BankFeedsConnectionsListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1BankFeedsConnectionsListResponseRowsItemStatus>
    {
        public override PostV1BankFeedsConnectionsListResponseRowsItemStatus Read(
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
            return new PostV1BankFeedsConnectionsListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankFeedsConnectionsListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1BankFeedsConnectionsListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsListResponseRowsItemStatus value,
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
