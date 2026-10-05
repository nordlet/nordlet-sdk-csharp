using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsListAgreementsResponseRowsItemStatus.AgreementsListAgreementsResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct AgreementsListAgreementsResponseRowsItemStatus : IStringEnum
{
    public static readonly AgreementsListAgreementsResponseRowsItemStatus Draft = new(Values.Draft);

    public static readonly AgreementsListAgreementsResponseRowsItemStatus Active = new(
        Values.Active
    );

    public static readonly AgreementsListAgreementsResponseRowsItemStatus Expired = new(
        Values.Expired
    );

    public static readonly AgreementsListAgreementsResponseRowsItemStatus Terminated = new(
        Values.Terminated
    );

    public AgreementsListAgreementsResponseRowsItemStatus(string value)
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
    public static AgreementsListAgreementsResponseRowsItemStatus FromCustom(string value)
    {
        return new AgreementsListAgreementsResponseRowsItemStatus(value);
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
        AgreementsListAgreementsResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgreementsListAgreementsResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsListAgreementsResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator AgreementsListAgreementsResponseRowsItemStatus(string value) =>
        new(value);

    internal class AgreementsListAgreementsResponseRowsItemStatusSerializer
        : JsonConverter<AgreementsListAgreementsResponseRowsItemStatus>
    {
        public override AgreementsListAgreementsResponseRowsItemStatus Read(
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
            return new AgreementsListAgreementsResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsListAgreementsResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsListAgreementsResponseRowsItemStatus ReadAsPropertyName(
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
            return new AgreementsListAgreementsResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsListAgreementsResponseRowsItemStatus value,
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

        public const string Active = "active";

        public const string Expired = "expired";

        public const string Terminated = "terminated";
    }
}
