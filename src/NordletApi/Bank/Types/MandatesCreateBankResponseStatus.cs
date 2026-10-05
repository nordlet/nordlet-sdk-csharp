using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(MandatesCreateBankResponseStatus.MandatesCreateBankResponseStatusSerializer))]
[Serializable]
public readonly record struct MandatesCreateBankResponseStatus : IStringEnum
{
    public static readonly MandatesCreateBankResponseStatus Active = new(Values.Active);

    public static readonly MandatesCreateBankResponseStatus Cancelled = new(Values.Cancelled);

    public static readonly MandatesCreateBankResponseStatus Completed = new(Values.Completed);

    public MandatesCreateBankResponseStatus(string value)
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
    public static MandatesCreateBankResponseStatus FromCustom(string value)
    {
        return new MandatesCreateBankResponseStatus(value);
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

    public static bool operator ==(MandatesCreateBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesCreateBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesCreateBankResponseStatus value) => value.Value;

    public static explicit operator MandatesCreateBankResponseStatus(string value) => new(value);

    internal class MandatesCreateBankResponseStatusSerializer
        : JsonConverter<MandatesCreateBankResponseStatus>
    {
        public override MandatesCreateBankResponseStatus Read(
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
            return new MandatesCreateBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesCreateBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesCreateBankResponseStatus ReadAsPropertyName(
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
            return new MandatesCreateBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesCreateBankResponseStatus value,
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

        public const string Cancelled = "cancelled";

        public const string Completed = "completed";
    }
}
