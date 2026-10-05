using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesApplyAdvanceSalesResponseStatus.InvoicesApplyAdvanceSalesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesApplyAdvanceSalesResponseStatus : IStringEnum
{
    public static readonly InvoicesApplyAdvanceSalesResponseStatus Draft = new(Values.Draft);

    public static readonly InvoicesApplyAdvanceSalesResponseStatus Issued = new(Values.Issued);

    public InvoicesApplyAdvanceSalesResponseStatus(string value)
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
    public static InvoicesApplyAdvanceSalesResponseStatus FromCustom(string value)
    {
        return new InvoicesApplyAdvanceSalesResponseStatus(value);
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

    public static bool operator ==(InvoicesApplyAdvanceSalesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesApplyAdvanceSalesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesApplyAdvanceSalesResponseStatus value) =>
        value.Value;

    public static explicit operator InvoicesApplyAdvanceSalesResponseStatus(string value) =>
        new(value);

    internal class InvoicesApplyAdvanceSalesResponseStatusSerializer
        : JsonConverter<InvoicesApplyAdvanceSalesResponseStatus>
    {
        public override InvoicesApplyAdvanceSalesResponseStatus Read(
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
            return new InvoicesApplyAdvanceSalesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesApplyAdvanceSalesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesApplyAdvanceSalesResponseStatus ReadAsPropertyName(
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
            return new InvoicesApplyAdvanceSalesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesApplyAdvanceSalesResponseStatus value,
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
        public const string Draft = "draft";

        public const string Issued = "issued";
    }
}
