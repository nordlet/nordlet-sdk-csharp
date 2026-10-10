using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuDigitalReportingListDeclarationsResponseTransactionsItemArticle.EuDigitalReportingListDeclarationsResponseTransactionsItemArticleSerializer)
)]
[Serializable]
public readonly record struct EuDigitalReportingListDeclarationsResponseTransactionsItemArticle
    : IStringEnum
{
    public static readonly EuDigitalReportingListDeclarationsResponseTransactionsItemArticle TwoHundredSixtyTwo1A =
        new(Values.TwoHundredSixtyTwo1A);

    public static readonly EuDigitalReportingListDeclarationsResponseTransactionsItemArticle TwoHundredSixtyTwo1B =
        new(Values.TwoHundredSixtyTwo1B);

    public static readonly EuDigitalReportingListDeclarationsResponseTransactionsItemArticle TwoHundredSixtyTwo1C =
        new(Values.TwoHundredSixtyTwo1C);

    public static readonly EuDigitalReportingListDeclarationsResponseTransactionsItemArticle TwoHundredSixtyTwo1D =
        new(Values.TwoHundredSixtyTwo1D);

    public EuDigitalReportingListDeclarationsResponseTransactionsItemArticle(string value)
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
    public static EuDigitalReportingListDeclarationsResponseTransactionsItemArticle FromCustom(
        string value
    )
    {
        return new EuDigitalReportingListDeclarationsResponseTransactionsItemArticle(value);
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
        EuDigitalReportingListDeclarationsResponseTransactionsItemArticle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuDigitalReportingListDeclarationsResponseTransactionsItemArticle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EuDigitalReportingListDeclarationsResponseTransactionsItemArticle value
    ) => value.Value;

    public static explicit operator EuDigitalReportingListDeclarationsResponseTransactionsItemArticle(
        string value
    ) => new(value);

    internal class EuDigitalReportingListDeclarationsResponseTransactionsItemArticleSerializer
        : JsonConverter<EuDigitalReportingListDeclarationsResponseTransactionsItemArticle>
    {
        public override EuDigitalReportingListDeclarationsResponseTransactionsItemArticle Read(
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
            return new EuDigitalReportingListDeclarationsResponseTransactionsItemArticle(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuDigitalReportingListDeclarationsResponseTransactionsItemArticle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuDigitalReportingListDeclarationsResponseTransactionsItemArticle ReadAsPropertyName(
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
            return new EuDigitalReportingListDeclarationsResponseTransactionsItemArticle(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuDigitalReportingListDeclarationsResponseTransactionsItemArticle value,
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
        public const string TwoHundredSixtyTwo1A = "262(1)(a)";

        public const string TwoHundredSixtyTwo1B = "262(1)(b)";

        public const string TwoHundredSixtyTwo1C = "262(1)(c)";

        public const string TwoHundredSixtyTwo1D = "262(1)(d)";
    }
}
