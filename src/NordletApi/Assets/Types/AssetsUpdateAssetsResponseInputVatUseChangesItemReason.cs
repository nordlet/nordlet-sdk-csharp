using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsUpdateAssetsResponseInputVatUseChangesItemReason.AssetsUpdateAssetsResponseInputVatUseChangesItemReasonSerializer)
)]
[Serializable]
public readonly record struct AssetsUpdateAssetsResponseInputVatUseChangesItemReason : IStringEnum
{
    public static readonly AssetsUpdateAssetsResponseInputVatUseChangesItemReason UseChange = new(
        Values.UseChange
    );

    public static readonly AssetsUpdateAssetsResponseInputVatUseChangesItemReason Sale = new(
        Values.Sale
    );

    public static readonly AssetsUpdateAssetsResponseInputVatUseChangesItemReason Withdrawal = new(
        Values.Withdrawal
    );

    public AssetsUpdateAssetsResponseInputVatUseChangesItemReason(string value)
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
    public static AssetsUpdateAssetsResponseInputVatUseChangesItemReason FromCustom(string value)
    {
        return new AssetsUpdateAssetsResponseInputVatUseChangesItemReason(value);
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
        AssetsUpdateAssetsResponseInputVatUseChangesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsUpdateAssetsResponseInputVatUseChangesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetsUpdateAssetsResponseInputVatUseChangesItemReason value
    ) => value.Value;

    public static explicit operator AssetsUpdateAssetsResponseInputVatUseChangesItemReason(
        string value
    ) => new(value);

    internal class AssetsUpdateAssetsResponseInputVatUseChangesItemReasonSerializer
        : JsonConverter<AssetsUpdateAssetsResponseInputVatUseChangesItemReason>
    {
        public override AssetsUpdateAssetsResponseInputVatUseChangesItemReason Read(
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
            return new AssetsUpdateAssetsResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsUpdateAssetsResponseInputVatUseChangesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsUpdateAssetsResponseInputVatUseChangesItemReason ReadAsPropertyName(
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
            return new AssetsUpdateAssetsResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsUpdateAssetsResponseInputVatUseChangesItemReason value,
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
