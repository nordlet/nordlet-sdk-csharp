using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule.PostV1BankFeedsConnectionsGetResponseAccountsItemSyncScheduleSerializer)
)]
[Serializable]
public readonly record struct PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule
    : IStringEnum
{
    public static readonly PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule Manual =
        new(Values.Manual);

    public static readonly PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule Daily =
        new(Values.Daily);

    public static readonly PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule Weekly =
        new(Values.Weekly);

    public static readonly PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule Monthly =
        new(Values.Monthly);

    public PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule(string value)
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
    public static PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule FromCustom(
        string value
    )
    {
        return new PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule(value);
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
        PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule value
    ) => value.Value;

    public static explicit operator PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule(
        string value
    ) => new(value);

    internal class PostV1BankFeedsConnectionsGetResponseAccountsItemSyncScheduleSerializer
        : JsonConverter<PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule>
    {
        public override PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule Read(
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
            return new PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule ReadAsPropertyName(
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
            return new PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsGetResponseAccountsItemSyncSchedule value,
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
