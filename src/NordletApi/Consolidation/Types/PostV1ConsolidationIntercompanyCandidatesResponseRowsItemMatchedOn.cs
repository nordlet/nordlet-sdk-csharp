using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn.PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOnSerializer)
)]
[Serializable]
public readonly record struct PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn
    : IStringEnum
{
    public static readonly PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn Code =
        new(Values.Code);

    public static readonly PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn VatCode =
        new(Values.VatCode);

    public PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn(string value)
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
    public static PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn FromCustom(
        string value
    )
    {
        return new PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn(value);
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
        PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn value
    ) => value.Value;

    public static explicit operator PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn(
        string value
    ) => new(value);

    internal class PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOnSerializer
        : JsonConverter<PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn>
    {
        public override PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn Read(
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
            return new PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn ReadAsPropertyName(
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
            return new PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ConsolidationIntercompanyCandidatesResponseRowsItemMatchedOn value,
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
