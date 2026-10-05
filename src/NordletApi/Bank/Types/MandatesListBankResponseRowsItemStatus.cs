using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MandatesListBankResponseRowsItemStatus.MandatesListBankResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct MandatesListBankResponseRowsItemStatus : IStringEnum
{
    public static readonly MandatesListBankResponseRowsItemStatus Active = new(Values.Active);

    public static readonly MandatesListBankResponseRowsItemStatus Cancelled = new(Values.Cancelled);

    public static readonly MandatesListBankResponseRowsItemStatus Completed = new(Values.Completed);

    public MandatesListBankResponseRowsItemStatus(string value)
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
    public static MandatesListBankResponseRowsItemStatus FromCustom(string value)
    {
        return new MandatesListBankResponseRowsItemStatus(value);
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

    public static bool operator ==(MandatesListBankResponseRowsItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MandatesListBankResponseRowsItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MandatesListBankResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator MandatesListBankResponseRowsItemStatus(string value) =>
        new(value);

    internal class MandatesListBankResponseRowsItemStatusSerializer
        : JsonConverter<MandatesListBankResponseRowsItemStatus>
    {
        public override MandatesListBankResponseRowsItemStatus Read(
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
            return new MandatesListBankResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MandatesListBankResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MandatesListBankResponseRowsItemStatus ReadAsPropertyName(
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
            return new MandatesListBankResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MandatesListBankResponseRowsItemStatus value,
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
