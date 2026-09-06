using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule.PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncScheduleSerializer)
)]
[Serializable]
public readonly record struct PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule
    : IStringEnum
{
    public static readonly PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule Manual =
        new(Values.Manual);

    public static readonly PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule Daily =
        new(Values.Daily);

    public static readonly PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule Weekly =
        new(Values.Weekly);

    public static readonly PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule Monthly =
        new(Values.Monthly);

    public PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule(string value)
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
    public static PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule FromCustom(
        string value
    )
    {
        return new PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule(value);
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
        PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule value
    ) => value.Value;

    public static explicit operator PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule(
        string value
    ) => new(value);

    internal class PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncScheduleSerializer
        : JsonConverter<PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule>
    {
        public override PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule Read(
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
            return new PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule ReadAsPropertyName(
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
            return new PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsCompleteResponseAccountsItemSyncSchedule value,
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
        public const string Manual = "manual";

        public const string Daily = "daily";

        public const string Weekly = "weekly";

        public const string Monthly = "monthly";
    }
}
