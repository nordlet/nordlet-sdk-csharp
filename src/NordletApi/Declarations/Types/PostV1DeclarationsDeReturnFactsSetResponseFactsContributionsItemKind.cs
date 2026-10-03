using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind.PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind
    : IStringEnum
{
    public static readonly PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind Cash =
        new(Values.Cash);

    public static readonly PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind InKind =
        new(Values.InKind);

    public PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind(string value)
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
    public static PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind(value);
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
        PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKindSerializer
        : JsonConverter<PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind>
    {
        public override PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind Read(
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
            return new PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind ReadAsPropertyName(
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
            return new PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsSetResponseFactsContributionsItemKind value,
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
        public const string Cash = "cash";

        public const string InKind = "in_kind";
    }
}
