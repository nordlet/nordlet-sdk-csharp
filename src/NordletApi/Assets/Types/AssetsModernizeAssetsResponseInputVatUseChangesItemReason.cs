using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsModernizeAssetsResponseInputVatUseChangesItemReason.AssetsModernizeAssetsResponseInputVatUseChangesItemReasonSerializer)
)]
[Serializable]
public readonly record struct AssetsModernizeAssetsResponseInputVatUseChangesItemReason
    : IStringEnum
{
    public static readonly AssetsModernizeAssetsResponseInputVatUseChangesItemReason UseChange =
        new(Values.UseChange);

    public static readonly AssetsModernizeAssetsResponseInputVatUseChangesItemReason Sale = new(
        Values.Sale
    );

    public static readonly AssetsModernizeAssetsResponseInputVatUseChangesItemReason Withdrawal =
        new(Values.Withdrawal);

    public AssetsModernizeAssetsResponseInputVatUseChangesItemReason(string value)
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
    public static AssetsModernizeAssetsResponseInputVatUseChangesItemReason FromCustom(string value)
    {
        return new AssetsModernizeAssetsResponseInputVatUseChangesItemReason(value);
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
        AssetsModernizeAssetsResponseInputVatUseChangesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsModernizeAssetsResponseInputVatUseChangesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetsModernizeAssetsResponseInputVatUseChangesItemReason value
    ) => value.Value;

    public static explicit operator AssetsModernizeAssetsResponseInputVatUseChangesItemReason(
        string value
    ) => new(value);

    internal class AssetsModernizeAssetsResponseInputVatUseChangesItemReasonSerializer
        : JsonConverter<AssetsModernizeAssetsResponseInputVatUseChangesItemReason>
    {
        public override AssetsModernizeAssetsResponseInputVatUseChangesItemReason Read(
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
            return new AssetsModernizeAssetsResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsModernizeAssetsResponseInputVatUseChangesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsModernizeAssetsResponseInputVatUseChangesItemReason ReadAsPropertyName(
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
            return new AssetsModernizeAssetsResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsModernizeAssetsResponseInputVatUseChangesItemReason value,
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
