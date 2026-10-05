using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn.IntercompanyCandidatesConsolidationResponseRowsItemMatchedOnSerializer)
)]
[Serializable]
public readonly record struct IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn
    : IStringEnum
{
    public static readonly IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn Code = new(
        Values.Code
    );

    public static readonly IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn VatCode =
        new(Values.VatCode);

    public IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn(string value)
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
    public static IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn FromCustom(
        string value
    )
    {
        return new IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn(value);
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
        IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn value
    ) => value.Value;

    public static explicit operator IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn(
        string value
    ) => new(value);

    internal class IntercompanyCandidatesConsolidationResponseRowsItemMatchedOnSerializer
        : JsonConverter<IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn>
    {
        public override IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn Read(
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
            return new IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn ReadAsPropertyName(
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
            return new IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            IntercompanyCandidatesConsolidationResponseRowsItemMatchedOn value,
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
        public const string Code = "code";

        public const string VatCode = "vatCode";
    }
}
