using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(MeAccountResponseBillingStatus.MeAccountResponseBillingStatusSerializer))]
[Serializable]
public readonly record struct MeAccountResponseBillingStatus : IStringEnum
{
    public static readonly MeAccountResponseBillingStatus Trial = new(Values.Trial);

    public static readonly MeAccountResponseBillingStatus Active = new(Values.Active);

    public static readonly MeAccountResponseBillingStatus Suspended = new(Values.Suspended);

    public MeAccountResponseBillingStatus(string value)
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
    public static MeAccountResponseBillingStatus FromCustom(string value)
    {
        return new MeAccountResponseBillingStatus(value);
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

    public static bool operator ==(MeAccountResponseBillingStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MeAccountResponseBillingStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MeAccountResponseBillingStatus value) => value.Value;

    public static explicit operator MeAccountResponseBillingStatus(string value) => new(value);

    internal class MeAccountResponseBillingStatusSerializer
        : JsonConverter<MeAccountResponseBillingStatus>
    {
        public override MeAccountResponseBillingStatus Read(
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
            return new MeAccountResponseBillingStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MeAccountResponseBillingStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MeAccountResponseBillingStatus ReadAsPropertyName(
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
            return new MeAccountResponseBillingStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MeAccountResponseBillingStatus value,
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
