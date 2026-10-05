using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ContactsListPartnersRequestSortItemDir.ContactsListPartnersRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct ContactsListPartnersRequestSortItemDir : IStringEnum
{
    public static readonly ContactsListPartnersRequestSortItemDir Asc = new(Values.Asc);

    public static readonly ContactsListPartnersRequestSortItemDir Desc = new(Values.Desc);

    public ContactsListPartnersRequestSortItemDir(string value)
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
    public static ContactsListPartnersRequestSortItemDir FromCustom(string value)
    {
        return new ContactsListPartnersRequestSortItemDir(value);
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

    public static bool operator ==(ContactsListPartnersRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContactsListPartnersRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContactsListPartnersRequestSortItemDir value) =>
        value.Value;

    public static explicit operator ContactsListPartnersRequestSortItemDir(string value) =>
        new(value);

    internal class ContactsListPartnersRequestSortItemDirSerializer
        : JsonConverter<ContactsListPartnersRequestSortItemDir>
    {
        public override ContactsListPartnersRequestSortItemDir Read(
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
            return new ContactsListPartnersRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContactsListPartnersRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContactsListPartnersRequestSortItemDir ReadAsPropertyName(
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
            return new ContactsListPartnersRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContactsListPartnersRequestSortItemDir value,
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
        public const string Asc = "asc";

        public const string Desc = "desc";
    }
}
