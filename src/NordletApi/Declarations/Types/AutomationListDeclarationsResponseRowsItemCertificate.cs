using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AutomationListDeclarationsResponseRowsItemCertificate.AutomationListDeclarationsResponseRowsItemCertificateSerializer)
)]
[Serializable]
public readonly record struct AutomationListDeclarationsResponseRowsItemCertificate : IStringEnum
{
    public static readonly AutomationListDeclarationsResponseRowsItemCertificate Ok = new(
        Values.Ok
    );

    public static readonly AutomationListDeclarationsResponseRowsItemCertificate Expiring = new(
        Values.Expiring
    );

    public static readonly AutomationListDeclarationsResponseRowsItemCertificate Expired = new(
        Values.Expired
    );

    public static readonly AutomationListDeclarationsResponseRowsItemCertificate Unknown = new(
        Values.Unknown
    );

    public static readonly AutomationListDeclarationsResponseRowsItemCertificate Missing = new(
        Values.Missing
    );

    public static readonly AutomationListDeclarationsResponseRowsItemCertificate NotNeeded = new(
        Values.NotNeeded
    );

    public AutomationListDeclarationsResponseRowsItemCertificate(string value)
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
    public static AutomationListDeclarationsResponseRowsItemCertificate FromCustom(string value)
    {
        return new AutomationListDeclarationsResponseRowsItemCertificate(value);
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
        AutomationListDeclarationsResponseRowsItemCertificate value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AutomationListDeclarationsResponseRowsItemCertificate value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AutomationListDeclarationsResponseRowsItemCertificate value
    ) => value.Value;

    public static explicit operator AutomationListDeclarationsResponseRowsItemCertificate(
        string value
    ) => new(value);

    internal class AutomationListDeclarationsResponseRowsItemCertificateSerializer
        : JsonConverter<AutomationListDeclarationsResponseRowsItemCertificate>
    {
        public override AutomationListDeclarationsResponseRowsItemCertificate Read(
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
            return new AutomationListDeclarationsResponseRowsItemCertificate(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AutomationListDeclarationsResponseRowsItemCertificate value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AutomationListDeclarationsResponseRowsItemCertificate ReadAsPropertyName(
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
            return new AutomationListDeclarationsResponseRowsItemCertificate(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AutomationListDeclarationsResponseRowsItemCertificate value,
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
