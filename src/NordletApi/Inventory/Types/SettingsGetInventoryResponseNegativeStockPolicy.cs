using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SettingsGetInventoryResponseNegativeStockPolicy.SettingsGetInventoryResponseNegativeStockPolicySerializer)
)]
[Serializable]
public readonly record struct SettingsGetInventoryResponseNegativeStockPolicy : IStringEnum
{
    public static readonly SettingsGetInventoryResponseNegativeStockPolicy Reject = new(
        Values.Reject
    );

    public static readonly SettingsGetInventoryResponseNegativeStockPolicy Allow = new(
        Values.Allow
    );

    public SettingsGetInventoryResponseNegativeStockPolicy(string value)
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
    public static SettingsGetInventoryResponseNegativeStockPolicy FromCustom(string value)
    {
        return new SettingsGetInventoryResponseNegativeStockPolicy(value);
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
        SettingsGetInventoryResponseNegativeStockPolicy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SettingsGetInventoryResponseNegativeStockPolicy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SettingsGetInventoryResponseNegativeStockPolicy value) =>
        value.Value;

    public static explicit operator SettingsGetInventoryResponseNegativeStockPolicy(string value) =>
        new(value);

    internal class SettingsGetInventoryResponseNegativeStockPolicySerializer
        : JsonConverter<SettingsGetInventoryResponseNegativeStockPolicy>
    {
        public override SettingsGetInventoryResponseNegativeStockPolicy Read(
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
            return new SettingsGetInventoryResponseNegativeStockPolicy(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SettingsGetInventoryResponseNegativeStockPolicy value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SettingsGetInventoryResponseNegativeStockPolicy ReadAsPropertyName(
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
            return new SettingsGetInventoryResponseNegativeStockPolicy(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SettingsGetInventoryResponseNegativeStockPolicy value,
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
        public const string Reject = "reject";

        public const string Allow = "allow";
    }
}
