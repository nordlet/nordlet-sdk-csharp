using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BooksValidateMigrationRequestPartnersItemType.BooksValidateMigrationRequestPartnersItemTypeSerializer)
)]
[Serializable]
public readonly record struct BooksValidateMigrationRequestPartnersItemType : IStringEnum
{
    public static readonly BooksValidateMigrationRequestPartnersItemType Company = new(
        Values.Company
    );

    public static readonly BooksValidateMigrationRequestPartnersItemType Person = new(
        Values.Person
    );

    public BooksValidateMigrationRequestPartnersItemType(string value)
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
    public static BooksValidateMigrationRequestPartnersItemType FromCustom(string value)
    {
        return new BooksValidateMigrationRequestPartnersItemType(value);
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
        BooksValidateMigrationRequestPartnersItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BooksValidateMigrationRequestPartnersItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(BooksValidateMigrationRequestPartnersItemType value) =>
        value.Value;

    public static explicit operator BooksValidateMigrationRequestPartnersItemType(string value) =>
        new(value);

    internal class BooksValidateMigrationRequestPartnersItemTypeSerializer
        : JsonConverter<BooksValidateMigrationRequestPartnersItemType>
    {
        public override BooksValidateMigrationRequestPartnersItemType Read(
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
            return new BooksValidateMigrationRequestPartnersItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BooksValidateMigrationRequestPartnersItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BooksValidateMigrationRequestPartnersItemType ReadAsPropertyName(
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
            return new BooksValidateMigrationRequestPartnersItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BooksValidateMigrationRequestPartnersItemType value,
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
        public const string Company = "company";

        public const string Person = "person";
    }
}
