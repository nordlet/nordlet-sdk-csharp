using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsInputVatAssetsRequestInputVatUseChangesItemReason.AssetsInputVatAssetsRequestInputVatUseChangesItemReasonSerializer)
)]
[Serializable]
public readonly record struct AssetsInputVatAssetsRequestInputVatUseChangesItemReason : IStringEnum
{
    public static readonly AssetsInputVatAssetsRequestInputVatUseChangesItemReason UseChange = new(
        Values.UseChange
    );

    public static readonly AssetsInputVatAssetsRequestInputVatUseChangesItemReason Sale = new(
        Values.Sale
    );

    public static readonly AssetsInputVatAssetsRequestInputVatUseChangesItemReason Withdrawal = new(
        Values.Withdrawal
    );

    public AssetsInputVatAssetsRequestInputVatUseChangesItemReason(string value)
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
    public static AssetsInputVatAssetsRequestInputVatUseChangesItemReason FromCustom(string value)
    {
        return new AssetsInputVatAssetsRequestInputVatUseChangesItemReason(value);
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
        AssetsInputVatAssetsRequestInputVatUseChangesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsInputVatAssetsRequestInputVatUseChangesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetsInputVatAssetsRequestInputVatUseChangesItemReason value
    ) => value.Value;

    public static explicit operator AssetsInputVatAssetsRequestInputVatUseChangesItemReason(
        string value
    ) => new(value);

    internal class AssetsInputVatAssetsRequestInputVatUseChangesItemReasonSerializer
        : JsonConverter<AssetsInputVatAssetsRequestInputVatUseChangesItemReason>
    {
        public override AssetsInputVatAssetsRequestInputVatUseChangesItemReason Read(
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
            return new AssetsInputVatAssetsRequestInputVatUseChangesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsInputVatAssetsRequestInputVatUseChangesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsInputVatAssetsRequestInputVatUseChangesItemReason ReadAsPropertyName(
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
            return new AssetsInputVatAssetsRequestInputVatUseChangesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsInputVatAssetsRequestInputVatUseChangesItemReason value,
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
