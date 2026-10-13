using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FlatRateConfirmBillingResponseStatus.FlatRateConfirmBillingResponseStatusSerializer)
)]
[Serializable]
public readonly record struct FlatRateConfirmBillingResponseStatus : IStringEnum
{
    public static readonly FlatRateConfirmBillingResponseStatus Trial = new(Values.Trial);

    public static readonly FlatRateConfirmBillingResponseStatus Active = new(Values.Active);

    public static readonly FlatRateConfirmBillingResponseStatus Suspended = new(Values.Suspended);

    public FlatRateConfirmBillingResponseStatus(string value)
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
    public static FlatRateConfirmBillingResponseStatus FromCustom(string value)
    {
        return new FlatRateConfirmBillingResponseStatus(value);
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

    public static bool operator ==(FlatRateConfirmBillingResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FlatRateConfirmBillingResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FlatRateConfirmBillingResponseStatus value) =>
        value.Value;

    public static explicit operator FlatRateConfirmBillingResponseStatus(string value) =>
        new(value);

    internal class FlatRateConfirmBillingResponseStatusSerializer
        : JsonConverter<FlatRateConfirmBillingResponseStatus>
    {
        public override FlatRateConfirmBillingResponseStatus Read(
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
            return new FlatRateConfirmBillingResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FlatRateConfirmBillingResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FlatRateConfirmBillingResponseStatus ReadAsPropertyName(
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
            return new FlatRateConfirmBillingResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FlatRateConfirmBillingResponseStatus value,
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
        public const string Trial = "trial";

        public const string Active = "active";

        public const string Suspended = "suspended";
    }
}
