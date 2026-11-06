using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FreeSandboxStartBillingResponseStatus.FreeSandboxStartBillingResponseStatusSerializer)
)]
[Serializable]
public readonly record struct FreeSandboxStartBillingResponseStatus : IStringEnum
{
    public static readonly FreeSandboxStartBillingResponseStatus Trial = new(Values.Trial);

    public static readonly FreeSandboxStartBillingResponseStatus Active = new(Values.Active);

    public static readonly FreeSandboxStartBillingResponseStatus Suspended = new(Values.Suspended);

    public FreeSandboxStartBillingResponseStatus(string value)
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
    public static FreeSandboxStartBillingResponseStatus FromCustom(string value)
    {
        return new FreeSandboxStartBillingResponseStatus(value);
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

    public static bool operator ==(FreeSandboxStartBillingResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FreeSandboxStartBillingResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FreeSandboxStartBillingResponseStatus value) =>
        value.Value;

    public static explicit operator FreeSandboxStartBillingResponseStatus(string value) =>
        new(value);

    internal class FreeSandboxStartBillingResponseStatusSerializer
        : JsonConverter<FreeSandboxStartBillingResponseStatus>
    {
        public override FreeSandboxStartBillingResponseStatus Read(
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
            return new FreeSandboxStartBillingResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FreeSandboxStartBillingResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FreeSandboxStartBillingResponseStatus ReadAsPropertyName(
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
            return new FreeSandboxStartBillingResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FreeSandboxStartBillingResponseStatus value,
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
