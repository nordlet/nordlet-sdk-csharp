using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(MandatesCancelBankResponseStatus.MandatesCancelBankResponseStatusSerializer))]
[Serializable]
public readonly record struct MandatesCancelBankResponseStatus : IStringEnum
{
    public static readonly MandatesCancelBankResponseStatus Active = new(Values.Active);

    public static readonly MandatesCancelBankResponseStatus Cancelled = new(Values.Cancelled);

    public static readonly MandatesCancelBankResponseStatus Completed = new(Values.Completed);

    public MandatesCancelBankResponseStatus(string value)
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
    public static MandatesCancelBankResponseStatus FromCustom(string value)
    {
        return new MandatesCancelBankResponseStatus(value);
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

    public static bool operator ==(MandatesCancelBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesCancelBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesCancelBankResponseStatus value) => value.Value;

    public static explicit operator MandatesCancelBankResponseStatus(string value) => new(value);

    internal class MandatesCancelBankResponseStatusSerializer
        : JsonConverter<MandatesCancelBankResponseStatus>
    {
        public override MandatesCancelBankResponseStatus Read(
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
            return new MandatesCancelBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesCancelBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesCancelBankResponseStatus ReadAsPropertyName(
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
            return new MandatesCancelBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesCancelBankResponseStatus value,
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
