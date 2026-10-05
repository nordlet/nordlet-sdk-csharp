using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(LocaleSetAccountResponseScope.LocaleSetAccountResponseScopeSerializer))]
[Serializable]
public readonly record struct LocaleSetAccountResponseScope : IStringEnum
{
    public static readonly LocaleSetAccountResponseScope Membership = new(Values.Membership);

    public static readonly LocaleSetAccountResponseScope User = new(Values.User);

    public LocaleSetAccountResponseScope(string value)
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
    public static LocaleSetAccountResponseScope FromCustom(string value)
    {
        return new LocaleSetAccountResponseScope(value);
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

    public static bool operator ==(LocaleSetAccountResponseScope value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LocaleSetAccountResponseScope value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LocaleSetAccountResponseScope value) => value.Value;

    public static explicit operator LocaleSetAccountResponseScope(string value) => new(value);

    internal class LocaleSetAccountResponseScopeSerializer
        : JsonConverter<LocaleSetAccountResponseScope>
    {
        public override LocaleSetAccountResponseScope Read(
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
            return new LocaleSetAccountResponseScope(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LocaleSetAccountResponseScope value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LocaleSetAccountResponseScope ReadAsPropertyName(
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
            return new LocaleSetAccountResponseScope(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LocaleSetAccountResponseScope value,
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
        public const string Membership = "membership";

        public const string User = "user";
    }
}
