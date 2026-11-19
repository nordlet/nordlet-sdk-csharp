using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbVatObligationsListDeclarationsRequestStatus.GbVatObligationsListDeclarationsRequestStatusSerializer)
)]
[Serializable]
public readonly record struct GbVatObligationsListDeclarationsRequestStatus : IStringEnum
{
    public static readonly GbVatObligationsListDeclarationsRequestStatus O = new(Values.O);

    public static readonly GbVatObligationsListDeclarationsRequestStatus F = new(Values.F);

    public GbVatObligationsListDeclarationsRequestStatus(string value)
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
    public static GbVatObligationsListDeclarationsRequestStatus FromCustom(string value)
    {
        return new GbVatObligationsListDeclarationsRequestStatus(value);
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
        GbVatObligationsListDeclarationsRequestStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbVatObligationsListDeclarationsRequestStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GbVatObligationsListDeclarationsRequestStatus value) =>
        value.Value;

    public static explicit operator GbVatObligationsListDeclarationsRequestStatus(string value) =>
        new(value);

    internal class GbVatObligationsListDeclarationsRequestStatusSerializer
        : JsonConverter<GbVatObligationsListDeclarationsRequestStatus>
    {
        public override GbVatObligationsListDeclarationsRequestStatus Read(
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
            return new GbVatObligationsListDeclarationsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbVatObligationsListDeclarationsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbVatObligationsListDeclarationsRequestStatus ReadAsPropertyName(
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
            return new GbVatObligationsListDeclarationsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbVatObligationsListDeclarationsRequestStatus value,
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
        public const string O = "O";

        public const string F = "F";
    }
}
