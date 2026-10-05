using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule.FeedsConnectionsCompleteBankResponseAccountsItemSyncScheduleSerializer)
)]
[Serializable]
public readonly record struct FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule
    : IStringEnum
{
    public static readonly FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule Manual =
        new(Values.Manual);

    public static readonly FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule Daily = new(
        Values.Daily
    );

    public static readonly FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule Weekly =
        new(Values.Weekly);

    public static readonly FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule Monthly =
        new(Values.Monthly);

    public FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule(string value)
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
    public static FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule FromCustom(
        string value
    )
    {
        return new FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule(value);
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
        FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule value
    ) => value.Value;

    public static explicit operator FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule(
        string value
    ) => new(value);

    internal class FeedsConnectionsCompleteBankResponseAccountsItemSyncScheduleSerializer
        : JsonConverter<FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule>
    {
        public override FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule Read(
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
            return new FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule ReadAsPropertyName(
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
            return new FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsConnectionsCompleteBankResponseAccountsItemSyncSchedule value,
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
