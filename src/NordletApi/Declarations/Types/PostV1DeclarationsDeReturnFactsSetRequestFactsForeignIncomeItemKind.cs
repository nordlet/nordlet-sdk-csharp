using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind.PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind
    : IStringEnum
{
    public static readonly PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind Dividends =
        new(Values.Dividends);

    public static readonly PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind Other =
        new(Values.Other);

    public PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind(string value)
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
    public static PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind(value);
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
        PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKindSerializer
        : JsonConverter<PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind>
    {
        public override PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind Read(
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
            return new PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind ReadAsPropertyName(
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
            return new PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsSetRequestFactsForeignIncomeItemKind value,
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
        public const string Dividends = "dividends";

        public const string Other = "other";
    }
}
