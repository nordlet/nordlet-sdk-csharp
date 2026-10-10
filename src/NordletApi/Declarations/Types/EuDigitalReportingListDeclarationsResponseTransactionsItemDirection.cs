using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuDigitalReportingListDeclarationsResponseTransactionsItemDirection.EuDigitalReportingListDeclarationsResponseTransactionsItemDirectionSerializer)
)]
[Serializable]
public readonly record struct EuDigitalReportingListDeclarationsResponseTransactionsItemDirection
    : IStringEnum
{
    public static readonly EuDigitalReportingListDeclarationsResponseTransactionsItemDirection Supply =
        new(Values.Supply);

    public static readonly EuDigitalReportingListDeclarationsResponseTransactionsItemDirection Acquisition =
        new(Values.Acquisition);

    public EuDigitalReportingListDeclarationsResponseTransactionsItemDirection(string value)
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
    public static EuDigitalReportingListDeclarationsResponseTransactionsItemDirection FromCustom(
        string value
    )
    {
        return new EuDigitalReportingListDeclarationsResponseTransactionsItemDirection(value);
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
        EuDigitalReportingListDeclarationsResponseTransactionsItemDirection value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuDigitalReportingListDeclarationsResponseTransactionsItemDirection value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EuDigitalReportingListDeclarationsResponseTransactionsItemDirection value
    ) => value.Value;

    public static explicit operator EuDigitalReportingListDeclarationsResponseTransactionsItemDirection(
        string value
    ) => new(value);

    internal class EuDigitalReportingListDeclarationsResponseTransactionsItemDirectionSerializer
        : JsonConverter<EuDigitalReportingListDeclarationsResponseTransactionsItemDirection>
    {
        public override EuDigitalReportingListDeclarationsResponseTransactionsItemDirection Read(
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
            return new EuDigitalReportingListDeclarationsResponseTransactionsItemDirection(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuDigitalReportingListDeclarationsResponseTransactionsItemDirection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuDigitalReportingListDeclarationsResponseTransactionsItemDirection ReadAsPropertyName(
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
            return new EuDigitalReportingListDeclarationsResponseTransactionsItemDirection(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuDigitalReportingListDeclarationsResponseTransactionsItemDirection value,
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
        public const string Supply = "supply";

        public const string Acquisition = "acquisition";
    }
}
