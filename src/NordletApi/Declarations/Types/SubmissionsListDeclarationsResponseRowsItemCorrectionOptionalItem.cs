using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem.SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItemSerializer)
)]
[Serializable]
public readonly record struct SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem
    : IStringEnum
{
    public static readonly SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem Reason =
        new(Values.Reason);

    public static readonly SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem ReasonCode =
        new(Values.ReasonCode);

    public static readonly SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem AuthorityReference =
        new(Values.AuthorityReference);

    public static readonly SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem DiscoveredOn =
        new(Values.DiscoveredOn);

    public SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem(string value)
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
    public static SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem FromCustom(
        string value
    )
    {
        return new SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem(value);
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
        SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem value
    ) => value.Value;

    public static explicit operator SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem(
        string value
    ) => new(value);

    internal class SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItemSerializer
        : JsonConverter<SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem>
    {
        public override SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem Read(
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
            return new SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem ReadAsPropertyName(
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
            return new SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmissionsListDeclarationsResponseRowsItemCorrectionOptionalItem value,
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
        public const string Reason = "reason";

        public const string ReasonCode = "reasonCode";

        public const string AuthorityReference = "authorityReference";

        public const string DiscoveredOn = "discoveredOn";
    }
}
