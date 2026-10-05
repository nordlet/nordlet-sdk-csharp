using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MeAccountResponseCompaniesItemStatus.MeAccountResponseCompaniesItemStatusSerializer)
)]
[Serializable]
public readonly record struct MeAccountResponseCompaniesItemStatus : IStringEnum
{
    public static readonly MeAccountResponseCompaniesItemStatus Active = new(Values.Active);

    public static readonly MeAccountResponseCompaniesItemStatus Archived = new(Values.Archived);

    public static readonly MeAccountResponseCompaniesItemStatus Deleted = new(Values.Deleted);

    public MeAccountResponseCompaniesItemStatus(string value)
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
    public static MeAccountResponseCompaniesItemStatus FromCustom(string value)
    {
        return new MeAccountResponseCompaniesItemStatus(value);
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

    public static bool operator ==(MeAccountResponseCompaniesItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MeAccountResponseCompaniesItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MeAccountResponseCompaniesItemStatus value) =>
        value.Value;

    public static explicit operator MeAccountResponseCompaniesItemStatus(string value) =>
        new(value);

    internal class MeAccountResponseCompaniesItemStatusSerializer
        : JsonConverter<MeAccountResponseCompaniesItemStatus>
    {
        public override MeAccountResponseCompaniesItemStatus Read(
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
            return new MeAccountResponseCompaniesItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MeAccountResponseCompaniesItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MeAccountResponseCompaniesItemStatus ReadAsPropertyName(
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
            return new MeAccountResponseCompaniesItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MeAccountResponseCompaniesItemStatus value,
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
        public const string Active = "active";

        public const string Archived = "archived";

        public const string Deleted = "deleted";
    }
}
