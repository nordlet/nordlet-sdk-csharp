using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankFeedsAccountsConfigureResponseSyncSchedule.PostV1BankFeedsAccountsConfigureResponseSyncScheduleSerializer)
)]
[Serializable]
public readonly record struct PostV1BankFeedsAccountsConfigureResponseSyncSchedule : IStringEnum
{
    public static readonly PostV1BankFeedsAccountsConfigureResponseSyncSchedule Manual = new(
        Values.Manual
    );

    public static readonly PostV1BankFeedsAccountsConfigureResponseSyncSchedule Daily = new(
        Values.Daily
    );

    public static readonly PostV1BankFeedsAccountsConfigureResponseSyncSchedule Weekly = new(
        Values.Weekly
    );

    public static readonly PostV1BankFeedsAccountsConfigureResponseSyncSchedule Monthly = new(
        Values.Monthly
    );

    public PostV1BankFeedsAccountsConfigureResponseSyncSchedule(string value)
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
    public static PostV1BankFeedsAccountsConfigureResponseSyncSchedule FromCustom(string value)
    {
        return new PostV1BankFeedsAccountsConfigureResponseSyncSchedule(value);
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
        PostV1BankFeedsAccountsConfigureResponseSyncSchedule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankFeedsAccountsConfigureResponseSyncSchedule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankFeedsAccountsConfigureResponseSyncSchedule value
    ) => value.Value;

    public static explicit operator PostV1BankFeedsAccountsConfigureResponseSyncSchedule(
        string value
    ) => new(value);

    internal class PostV1BankFeedsAccountsConfigureResponseSyncScheduleSerializer
        : JsonConverter<PostV1BankFeedsAccountsConfigureResponseSyncSchedule>
    {
        public override PostV1BankFeedsAccountsConfigureResponseSyncSchedule Read(
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
            return new PostV1BankFeedsAccountsConfigureResponseSyncSchedule(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankFeedsAccountsConfigureResponseSyncSchedule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankFeedsAccountsConfigureResponseSyncSchedule ReadAsPropertyName(
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
            return new PostV1BankFeedsAccountsConfigureResponseSyncSchedule(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankFeedsAccountsConfigureResponseSyncSchedule value,
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
