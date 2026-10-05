using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TypesListAgreementsRequestSortItemDir.TypesListAgreementsRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct TypesListAgreementsRequestSortItemDir : IStringEnum
{
    public static readonly TypesListAgreementsRequestSortItemDir Asc = new(Values.Asc);

    public static readonly TypesListAgreementsRequestSortItemDir Desc = new(Values.Desc);

    public TypesListAgreementsRequestSortItemDir(string value)
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
    public static TypesListAgreementsRequestSortItemDir FromCustom(string value)
    {
        return new TypesListAgreementsRequestSortItemDir(value);
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

    public static bool operator ==(TypesListAgreementsRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TypesListAgreementsRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TypesListAgreementsRequestSortItemDir value) =>
        value.Value;

    public static explicit operator TypesListAgreementsRequestSortItemDir(string value) =>
        new(value);

    internal class TypesListAgreementsRequestSortItemDirSerializer
        : JsonConverter<TypesListAgreementsRequestSortItemDir>
    {
        public override TypesListAgreementsRequestSortItemDir Read(
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
            return new TypesListAgreementsRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TypesListAgreementsRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TypesListAgreementsRequestSortItemDir ReadAsPropertyName(
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
            return new TypesListAgreementsRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TypesListAgreementsRequestSortItemDir value,
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
