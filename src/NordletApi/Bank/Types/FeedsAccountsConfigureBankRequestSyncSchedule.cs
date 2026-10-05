using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsAccountsConfigureBankRequestSyncSchedule.FeedsAccountsConfigureBankRequestSyncScheduleSerializer)
)]
[Serializable]
public readonly record struct FeedsAccountsConfigureBankRequestSyncSchedule : IStringEnum
{
    public static readonly FeedsAccountsConfigureBankRequestSyncSchedule Manual = new(
        Values.Manual
    );

    public static readonly FeedsAccountsConfigureBankRequestSyncSchedule Daily = new(Values.Daily);

    public static readonly FeedsAccountsConfigureBankRequestSyncSchedule Weekly = new(
        Values.Weekly
    );

    public static readonly FeedsAccountsConfigureBankRequestSyncSchedule Monthly = new(
        Values.Monthly
    );

    public FeedsAccountsConfigureBankRequestSyncSchedule(string value)
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
    public static FeedsAccountsConfigureBankRequestSyncSchedule FromCustom(string value)
    {
        return new FeedsAccountsConfigureBankRequestSyncSchedule(value);
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
        FeedsAccountsConfigureBankRequestSyncSchedule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FeedsAccountsConfigureBankRequestSyncSchedule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FeedsAccountsConfigureBankRequestSyncSchedule value) =>
        value.Value;

    public static explicit operator FeedsAccountsConfigureBankRequestSyncSchedule(string value) =>
        new(value);

    internal class FeedsAccountsConfigureBankRequestSyncScheduleSerializer
        : JsonConverter<FeedsAccountsConfigureBankRequestSyncSchedule>
    {
        public override FeedsAccountsConfigureBankRequestSyncSchedule Read(
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
            return new FeedsAccountsConfigureBankRequestSyncSchedule(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsAccountsConfigureBankRequestSyncSchedule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsAccountsConfigureBankRequestSyncSchedule ReadAsPropertyName(
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
            return new FeedsAccountsConfigureBankRequestSyncSchedule(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsAccountsConfigureBankRequestSyncSchedule value,
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
