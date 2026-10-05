using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsAccountsLinkBankResponseSyncSchedule.FeedsAccountsLinkBankResponseSyncScheduleSerializer)
)]
[Serializable]
public readonly record struct FeedsAccountsLinkBankResponseSyncSchedule : IStringEnum
{
    public static readonly FeedsAccountsLinkBankResponseSyncSchedule Manual = new(Values.Manual);

    public static readonly FeedsAccountsLinkBankResponseSyncSchedule Daily = new(Values.Daily);

    public static readonly FeedsAccountsLinkBankResponseSyncSchedule Weekly = new(Values.Weekly);

    public static readonly FeedsAccountsLinkBankResponseSyncSchedule Monthly = new(Values.Monthly);

    public FeedsAccountsLinkBankResponseSyncSchedule(string value)
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
    public static FeedsAccountsLinkBankResponseSyncSchedule FromCustom(string value)
    {
        return new FeedsAccountsLinkBankResponseSyncSchedule(value);
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
        FeedsAccountsLinkBankResponseSyncSchedule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FeedsAccountsLinkBankResponseSyncSchedule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FeedsAccountsLinkBankResponseSyncSchedule value) =>
        value.Value;

    public static explicit operator FeedsAccountsLinkBankResponseSyncSchedule(string value) =>
        new(value);

    internal class FeedsAccountsLinkBankResponseSyncScheduleSerializer
        : JsonConverter<FeedsAccountsLinkBankResponseSyncSchedule>
    {
        public override FeedsAccountsLinkBankResponseSyncSchedule Read(
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
            return new FeedsAccountsLinkBankResponseSyncSchedule(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsAccountsLinkBankResponseSyncSchedule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsAccountsLinkBankResponseSyncSchedule ReadAsPropertyName(
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
            return new FeedsAccountsLinkBankResponseSyncSchedule(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsAccountsLinkBankResponseSyncSchedule value,
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
