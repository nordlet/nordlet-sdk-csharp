using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuVatRatesListReferenceResponseRowsItemSource.EuVatRatesListReferenceResponseRowsItemSourceSerializer)
)]
[Serializable]
public readonly record struct EuVatRatesListReferenceResponseRowsItemSource : IStringEnum
{
    public static readonly EuVatRatesListReferenceResponseRowsItemSource Default = new(
        Values.Default
    );

    public static readonly EuVatRatesListReferenceResponseRowsItemSource Company = new(
        Values.Company
    );

    public EuVatRatesListReferenceResponseRowsItemSource(string value)
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
    public static EuVatRatesListReferenceResponseRowsItemSource FromCustom(string value)
    {
        return new EuVatRatesListReferenceResponseRowsItemSource(value);
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
        EuVatRatesListReferenceResponseRowsItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuVatRatesListReferenceResponseRowsItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EuVatRatesListReferenceResponseRowsItemSource value) =>
        value.Value;

    public static explicit operator EuVatRatesListReferenceResponseRowsItemSource(string value) =>
        new(value);

    internal class EuVatRatesListReferenceResponseRowsItemSourceSerializer
        : JsonConverter<EuVatRatesListReferenceResponseRowsItemSource>
    {
        public override EuVatRatesListReferenceResponseRowsItemSource Read(
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
            return new EuVatRatesListReferenceResponseRowsItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuVatRatesListReferenceResponseRowsItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuVatRatesListReferenceResponseRowsItemSource ReadAsPropertyName(
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
            return new EuVatRatesListReferenceResponseRowsItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuVatRatesListReferenceResponseRowsItemSource value,
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
        public const string Default = "default";

        public const string Company = "company";
    }
}
