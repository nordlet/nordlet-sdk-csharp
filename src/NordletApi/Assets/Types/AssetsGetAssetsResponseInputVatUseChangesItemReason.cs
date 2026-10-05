using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsGetAssetsResponseInputVatUseChangesItemReason.AssetsGetAssetsResponseInputVatUseChangesItemReasonSerializer)
)]
[Serializable]
public readonly record struct AssetsGetAssetsResponseInputVatUseChangesItemReason : IStringEnum
{
    public static readonly AssetsGetAssetsResponseInputVatUseChangesItemReason UseChange = new(
        Values.UseChange
    );

    public static readonly AssetsGetAssetsResponseInputVatUseChangesItemReason Sale = new(
        Values.Sale
    );

    public static readonly AssetsGetAssetsResponseInputVatUseChangesItemReason Withdrawal = new(
        Values.Withdrawal
    );

    public AssetsGetAssetsResponseInputVatUseChangesItemReason(string value)
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
    public static AssetsGetAssetsResponseInputVatUseChangesItemReason FromCustom(string value)
    {
        return new AssetsGetAssetsResponseInputVatUseChangesItemReason(value);
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
        AssetsGetAssetsResponseInputVatUseChangesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsGetAssetsResponseInputVatUseChangesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetsGetAssetsResponseInputVatUseChangesItemReason value
    ) => value.Value;

    public static explicit operator AssetsGetAssetsResponseInputVatUseChangesItemReason(
        string value
    ) => new(value);

    internal class AssetsGetAssetsResponseInputVatUseChangesItemReasonSerializer
        : JsonConverter<AssetsGetAssetsResponseInputVatUseChangesItemReason>
    {
        public override AssetsGetAssetsResponseInputVatUseChangesItemReason Read(
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
            return new AssetsGetAssetsResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsGetAssetsResponseInputVatUseChangesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsGetAssetsResponseInputVatUseChangesItemReason ReadAsPropertyName(
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
            return new AssetsGetAssetsResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsGetAssetsResponseInputVatUseChangesItemReason value,
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
