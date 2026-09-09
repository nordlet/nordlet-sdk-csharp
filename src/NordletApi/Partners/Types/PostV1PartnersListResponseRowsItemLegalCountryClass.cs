using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersListResponseRowsItemLegalCountryClass.PostV1PartnersListResponseRowsItemLegalCountryClassSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersListResponseRowsItemLegalCountryClass : IStringEnum
{
    public static readonly PostV1PartnersListResponseRowsItemLegalCountryClass Lt = new(Values.Lt);

    public static readonly PostV1PartnersListResponseRowsItemLegalCountryClass Eu = new(Values.Eu);

    public static readonly PostV1PartnersListResponseRowsItemLegalCountryClass NonEu = new(
        Values.NonEu
    );

    public PostV1PartnersListResponseRowsItemLegalCountryClass(string value)
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
    public static PostV1PartnersListResponseRowsItemLegalCountryClass FromCustom(string value)
    {
        return new PostV1PartnersListResponseRowsItemLegalCountryClass(value);
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
        PostV1PartnersListResponseRowsItemLegalCountryClass value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersListResponseRowsItemLegalCountryClass value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1PartnersListResponseRowsItemLegalCountryClass value
    ) => value.Value;

    public static explicit operator PostV1PartnersListResponseRowsItemLegalCountryClass(
        string value
    ) => new(value);

    internal class PostV1PartnersListResponseRowsItemLegalCountryClassSerializer
        : JsonConverter<PostV1PartnersListResponseRowsItemLegalCountryClass>
    {
        public override PostV1PartnersListResponseRowsItemLegalCountryClass Read(
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
            return new PostV1PartnersListResponseRowsItemLegalCountryClass(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersListResponseRowsItemLegalCountryClass value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersListResponseRowsItemLegalCountryClass ReadAsPropertyName(
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
            return new PostV1PartnersListResponseRowsItemLegalCountryClass(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersListResponseRowsItemLegalCountryClass value,
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
        public const string Lt = "lt";

        public const string Eu = "eu";

        public const string NonEu = "non_eu";
    }
}
