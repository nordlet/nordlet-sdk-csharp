using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SettingsUpdateInventoryRequestNegativeStockPolicy.SettingsUpdateInventoryRequestNegativeStockPolicySerializer)
)]
[Serializable]
public readonly record struct SettingsUpdateInventoryRequestNegativeStockPolicy : IStringEnum
{
    public static readonly SettingsUpdateInventoryRequestNegativeStockPolicy Reject = new(
        Values.Reject
    );

    public static readonly SettingsUpdateInventoryRequestNegativeStockPolicy Allow = new(
        Values.Allow
    );

    public SettingsUpdateInventoryRequestNegativeStockPolicy(string value)
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
    public static SettingsUpdateInventoryRequestNegativeStockPolicy FromCustom(string value)
    {
        return new SettingsUpdateInventoryRequestNegativeStockPolicy(value);
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
        SettingsUpdateInventoryRequestNegativeStockPolicy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SettingsUpdateInventoryRequestNegativeStockPolicy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SettingsUpdateInventoryRequestNegativeStockPolicy value
    ) => value.Value;

    public static explicit operator SettingsUpdateInventoryRequestNegativeStockPolicy(
        string value
    ) => new(value);

    internal class SettingsUpdateInventoryRequestNegativeStockPolicySerializer
        : JsonConverter<SettingsUpdateInventoryRequestNegativeStockPolicy>
    {
        public override SettingsUpdateInventoryRequestNegativeStockPolicy Read(
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
            return new SettingsUpdateInventoryRequestNegativeStockPolicy(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SettingsUpdateInventoryRequestNegativeStockPolicy value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SettingsUpdateInventoryRequestNegativeStockPolicy ReadAsPropertyName(
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
            return new SettingsUpdateInventoryRequestNegativeStockPolicy(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SettingsUpdateInventoryRequestNegativeStockPolicy value,
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
