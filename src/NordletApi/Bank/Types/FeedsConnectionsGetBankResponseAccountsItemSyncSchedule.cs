using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsConnectionsGetBankResponseAccountsItemSyncSchedule.FeedsConnectionsGetBankResponseAccountsItemSyncScheduleSerializer)
)]
[Serializable]
public readonly record struct FeedsConnectionsGetBankResponseAccountsItemSyncSchedule : IStringEnum
{
    public static readonly FeedsConnectionsGetBankResponseAccountsItemSyncSchedule Manual = new(
        Values.Manual
    );

    public static readonly FeedsConnectionsGetBankResponseAccountsItemSyncSchedule Daily = new(
        Values.Daily
    );

    public static readonly FeedsConnectionsGetBankResponseAccountsItemSyncSchedule Weekly = new(
        Values.Weekly
    );

    public static readonly FeedsConnectionsGetBankResponseAccountsItemSyncSchedule Monthly = new(
        Values.Monthly
    );

    public FeedsConnectionsGetBankResponseAccountsItemSyncSchedule(string value)
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
    public static FeedsConnectionsGetBankResponseAccountsItemSyncSchedule FromCustom(string value)
    {
        return new FeedsConnectionsGetBankResponseAccountsItemSyncSchedule(value);
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
        FeedsConnectionsGetBankResponseAccountsItemSyncSchedule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FeedsConnectionsGetBankResponseAccountsItemSyncSchedule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FeedsConnectionsGetBankResponseAccountsItemSyncSchedule value
    ) => value.Value;

    public static explicit operator FeedsConnectionsGetBankResponseAccountsItemSyncSchedule(
        string value
    ) => new(value);

    internal class FeedsConnectionsGetBankResponseAccountsItemSyncScheduleSerializer
        : JsonConverter<FeedsConnectionsGetBankResponseAccountsItemSyncSchedule>
    {
        public override FeedsConnectionsGetBankResponseAccountsItemSyncSchedule Read(
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
            return new FeedsConnectionsGetBankResponseAccountsItemSyncSchedule(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsConnectionsGetBankResponseAccountsItemSyncSchedule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsConnectionsGetBankResponseAccountsItemSyncSchedule ReadAsPropertyName(
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
            return new FeedsConnectionsGetBankResponseAccountsItemSyncSchedule(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsConnectionsGetBankResponseAccountsItemSyncSchedule value,
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
