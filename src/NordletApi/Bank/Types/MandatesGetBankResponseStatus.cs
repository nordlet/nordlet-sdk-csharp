using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(MandatesGetBankResponseStatus.MandatesGetBankResponseStatusSerializer))]
[Serializable]
public readonly record struct MandatesGetBankResponseStatus : IStringEnum
{
    public static readonly MandatesGetBankResponseStatus Active = new(Values.Active);

    public static readonly MandatesGetBankResponseStatus Cancelled = new(Values.Cancelled);

    public static readonly MandatesGetBankResponseStatus Completed = new(Values.Completed);

    public MandatesGetBankResponseStatus(string value)
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
    public static MandatesGetBankResponseStatus FromCustom(string value)
    {
        return new MandatesGetBankResponseStatus(value);
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

    public static bool operator ==(MandatesGetBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesGetBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesGetBankResponseStatus value) => value.Value;

    public static explicit operator MandatesGetBankResponseStatus(string value) => new(value);

    internal class MandatesGetBankResponseStatusSerializer
        : JsonConverter<MandatesGetBankResponseStatus>
    {
        public override MandatesGetBankResponseStatus Read(
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
            return new MandatesGetBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesGetBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesGetBankResponseStatus ReadAsPropertyName(
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
            return new MandatesGetBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesGetBankResponseStatus value,
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
