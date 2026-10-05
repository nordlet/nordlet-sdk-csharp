using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BooksImportMigrationRequestPartnersItemType.BooksImportMigrationRequestPartnersItemTypeSerializer)
)]
[Serializable]
public readonly record struct BooksImportMigrationRequestPartnersItemType : IStringEnum
{
    public static readonly BooksImportMigrationRequestPartnersItemType Company = new(
        Values.Company
    );

    public static readonly BooksImportMigrationRequestPartnersItemType Person = new(Values.Person);

    public BooksImportMigrationRequestPartnersItemType(string value)
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
    public static BooksImportMigrationRequestPartnersItemType FromCustom(string value)
    {
        return new BooksImportMigrationRequestPartnersItemType(value);
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
        BooksImportMigrationRequestPartnersItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BooksImportMigrationRequestPartnersItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(BooksImportMigrationRequestPartnersItemType value) =>
        value.Value;

    public static explicit operator BooksImportMigrationRequestPartnersItemType(string value) =>
        new(value);

    internal class BooksImportMigrationRequestPartnersItemTypeSerializer
        : JsonConverter<BooksImportMigrationRequestPartnersItemType>
    {
        public override BooksImportMigrationRequestPartnersItemType Read(
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
            return new BooksImportMigrationRequestPartnersItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BooksImportMigrationRequestPartnersItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BooksImportMigrationRequestPartnersItemType ReadAsPropertyName(
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
            return new BooksImportMigrationRequestPartnersItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BooksImportMigrationRequestPartnersItemType value,
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
