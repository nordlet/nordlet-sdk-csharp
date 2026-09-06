using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankFeedsAccountsConfigureRequestSyncSchedule.PostV1BankFeedsAccountsConfigureRequestSyncScheduleSerializer)
)]
[Serializable]
public readonly record struct PostV1BankFeedsAccountsConfigureRequestSyncSchedule : IStringEnum
{
    public static readonly PostV1BankFeedsAccountsConfigureRequestSyncSchedule Manual = new(
        Values.Manual
    );

    public static readonly PostV1BankFeedsAccountsConfigureRequestSyncSchedule Daily = new(
        Values.Daily
    );

    public static readonly PostV1BankFeedsAccountsConfigureRequestSyncSchedule Weekly = new(
        Values.Weekly
    );

    public static readonly PostV1BankFeedsAccountsConfigureRequestSyncSchedule Monthly = new(
        Values.Monthly
    );

    public PostV1BankFeedsAccountsConfigureRequestSyncSchedule(string value)
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
    public static PostV1BankFeedsAccountsConfigureRequestSyncSchedule FromCustom(string value)
    {
        return new PostV1BankFeedsAccountsConfigureRequestSyncSchedule(value);
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
        PostV1BankFeedsAccountsConfigureRequestSyncSchedule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankFeedsAccountsConfigureRequestSyncSchedule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankFeedsAccountsConfigureRequestSyncSchedule value
    ) => value.Value;

    public static explicit operator PostV1BankFeedsAccountsConfigureRequestSyncSchedule(
        string value
    ) => new(value);

    internal class PostV1BankFeedsAccountsConfigureRequestSyncScheduleSerializer
        : JsonConverter<PostV1BankFeedsAccountsConfigureRequestSyncSchedule>
    {
        public override PostV1BankFeedsAccountsConfigureRequestSyncSchedule Read(
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
            return new PostV1BankFeedsAccountsConfigureRequestSyncSchedule(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankFeedsAccountsConfigureRequestSyncSchedule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankFeedsAccountsConfigureRequestSyncSchedule ReadAsPropertyName(
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
            return new PostV1BankFeedsAccountsConfigureRequestSyncSchedule(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankFeedsAccountsConfigureRequestSyncSchedule value,
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
