using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AutomationUpdateDeclarationsResponseRowsItemCertificate.AutomationUpdateDeclarationsResponseRowsItemCertificateSerializer)
)]
[Serializable]
public readonly record struct AutomationUpdateDeclarationsResponseRowsItemCertificate : IStringEnum
{
    public static readonly AutomationUpdateDeclarationsResponseRowsItemCertificate Ok = new(
        Values.Ok
    );

    public static readonly AutomationUpdateDeclarationsResponseRowsItemCertificate Expiring = new(
        Values.Expiring
    );

    public static readonly AutomationUpdateDeclarationsResponseRowsItemCertificate Expired = new(
        Values.Expired
    );

    public static readonly AutomationUpdateDeclarationsResponseRowsItemCertificate Unknown = new(
        Values.Unknown
    );

    public static readonly AutomationUpdateDeclarationsResponseRowsItemCertificate Missing = new(
        Values.Missing
    );

    public static readonly AutomationUpdateDeclarationsResponseRowsItemCertificate NotNeeded = new(
        Values.NotNeeded
    );

    public AutomationUpdateDeclarationsResponseRowsItemCertificate(string value)
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
    public static AutomationUpdateDeclarationsResponseRowsItemCertificate FromCustom(string value)
    {
        return new AutomationUpdateDeclarationsResponseRowsItemCertificate(value);
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
        AutomationUpdateDeclarationsResponseRowsItemCertificate value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AutomationUpdateDeclarationsResponseRowsItemCertificate value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AutomationUpdateDeclarationsResponseRowsItemCertificate value
    ) => value.Value;

    public static explicit operator AutomationUpdateDeclarationsResponseRowsItemCertificate(
        string value
    ) => new(value);

    internal class AutomationUpdateDeclarationsResponseRowsItemCertificateSerializer
        : JsonConverter<AutomationUpdateDeclarationsResponseRowsItemCertificate>
    {
        public override AutomationUpdateDeclarationsResponseRowsItemCertificate Read(
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
            return new AutomationUpdateDeclarationsResponseRowsItemCertificate(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationUpdateDeclarationsResponseRowsItemCertificate value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationUpdateDeclarationsResponseRowsItemCertificate ReadAsPropertyName(
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
            return new AutomationUpdateDeclarationsResponseRowsItemCertificate(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationUpdateDeclarationsResponseRowsItemCertificate value,
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
        public const string Ok = "ok";

        public const string Expiring = "expiring";

        public const string Expired = "expired";

        public const string Unknown = "unknown";

        public const string Missing = "missing";

        public const string NotNeeded = "not-needed";
    }
}
