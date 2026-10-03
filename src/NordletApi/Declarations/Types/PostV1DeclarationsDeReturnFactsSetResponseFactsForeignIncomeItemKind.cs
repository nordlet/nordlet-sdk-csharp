using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind.PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind
    : IStringEnum
{
    public static readonly PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind Dividends =
        new(Values.Dividends);

    public static readonly PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind Other =
        new(Values.Other);

    public PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind(string value)
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
    public static PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind(value);
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
        PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKindSerializer
        : JsonConverter<PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind>
    {
        public override PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind Read(
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
            return new PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind ReadAsPropertyName(
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
            return new PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsSetResponseFactsForeignIncomeItemKind value,
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
