using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsInputVatAssetsResponseInputVatUseChangesItemReason.AssetsInputVatAssetsResponseInputVatUseChangesItemReasonSerializer)
)]
[Serializable]
public readonly record struct AssetsInputVatAssetsResponseInputVatUseChangesItemReason : IStringEnum
{
    public static readonly AssetsInputVatAssetsResponseInputVatUseChangesItemReason UseChange = new(
        Values.UseChange
    );

    public static readonly AssetsInputVatAssetsResponseInputVatUseChangesItemReason Sale = new(
        Values.Sale
    );

    public static readonly AssetsInputVatAssetsResponseInputVatUseChangesItemReason Withdrawal =
        new(Values.Withdrawal);

    public AssetsInputVatAssetsResponseInputVatUseChangesItemReason(string value)
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
    public static AssetsInputVatAssetsResponseInputVatUseChangesItemReason FromCustom(string value)
    {
        return new AssetsInputVatAssetsResponseInputVatUseChangesItemReason(value);
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
        AssetsInputVatAssetsResponseInputVatUseChangesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsInputVatAssetsResponseInputVatUseChangesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetsInputVatAssetsResponseInputVatUseChangesItemReason value
    ) => value.Value;

    public static explicit operator AssetsInputVatAssetsResponseInputVatUseChangesItemReason(
        string value
    ) => new(value);

    internal class AssetsInputVatAssetsResponseInputVatUseChangesItemReasonSerializer
        : JsonConverter<AssetsInputVatAssetsResponseInputVatUseChangesItemReason>
    {
        public override AssetsInputVatAssetsResponseInputVatUseChangesItemReason Read(
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
            return new AssetsInputVatAssetsResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsInputVatAssetsResponseInputVatUseChangesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsInputVatAssetsResponseInputVatUseChangesItemReason ReadAsPropertyName(
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
            return new AssetsInputVatAssetsResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsInputVatAssetsResponseInputVatUseChangesItemReason value,
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
        public const string UseChange = "use_change";

        public const string Sale = "sale";

        public const string Withdrawal = "withdrawal";
    }
}
