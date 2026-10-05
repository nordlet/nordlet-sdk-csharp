using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReportConsolidationResponseMembersItemMethod.ReportConsolidationResponseMembersItemMethodSerializer)
)]
[Serializable]
public readonly record struct ReportConsolidationResponseMembersItemMethod : IStringEnum
{
    public static readonly ReportConsolidationResponseMembersItemMethod Full = new(Values.Full);

    public static readonly ReportConsolidationResponseMembersItemMethod Proportional = new(
        Values.Proportional
    );

    public static readonly ReportConsolidationResponseMembersItemMethod Equity = new(Values.Equity);

    public ReportConsolidationResponseMembersItemMethod(string value)
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
    public static ReportConsolidationResponseMembersItemMethod FromCustom(string value)
    {
        return new ReportConsolidationResponseMembersItemMethod(value);
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
        ReportConsolidationResponseMembersItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReportConsolidationResponseMembersItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ReportConsolidationResponseMembersItemMethod value) =>
        value.Value;

    public static explicit operator ReportConsolidationResponseMembersItemMethod(string value) =>
        new(value);

    internal class ReportConsolidationResponseMembersItemMethodSerializer
        : JsonConverter<ReportConsolidationResponseMembersItemMethod>
    {
        public override ReportConsolidationResponseMembersItemMethod Read(
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
            return new ReportConsolidationResponseMembersItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReportConsolidationResponseMembersItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReportConsolidationResponseMembersItemMethod ReadAsPropertyName(
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
            return new ReportConsolidationResponseMembersItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReportConsolidationResponseMembersItemMethod value,
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
        public const string Full = "full";

        public const string Proportional = "proportional";

        public const string Equity = "equity";
    }
}
