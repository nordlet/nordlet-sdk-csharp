using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsDisposeAssetsResponseInputVatUseChangesItemReason.AssetsDisposeAssetsResponseInputVatUseChangesItemReasonSerializer)
)]
[Serializable]
public readonly record struct AssetsDisposeAssetsResponseInputVatUseChangesItemReason : IStringEnum
{
    public static readonly AssetsDisposeAssetsResponseInputVatUseChangesItemReason UseChange = new(
        Values.UseChange
    );

    public static readonly AssetsDisposeAssetsResponseInputVatUseChangesItemReason Sale = new(
        Values.Sale
    );

    public static readonly AssetsDisposeAssetsResponseInputVatUseChangesItemReason Withdrawal = new(
        Values.Withdrawal
    );

    public AssetsDisposeAssetsResponseInputVatUseChangesItemReason(string value)
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
    public static AssetsDisposeAssetsResponseInputVatUseChangesItemReason FromCustom(string value)
    {
        return new AssetsDisposeAssetsResponseInputVatUseChangesItemReason(value);
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
        AssetsDisposeAssetsResponseInputVatUseChangesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsDisposeAssetsResponseInputVatUseChangesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetsDisposeAssetsResponseInputVatUseChangesItemReason value
    ) => value.Value;

    public static explicit operator AssetsDisposeAssetsResponseInputVatUseChangesItemReason(
        string value
    ) => new(value);

    internal class AssetsDisposeAssetsResponseInputVatUseChangesItemReasonSerializer
        : JsonConverter<AssetsDisposeAssetsResponseInputVatUseChangesItemReason>
    {
        public override AssetsDisposeAssetsResponseInputVatUseChangesItemReason Read(
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
            return new AssetsDisposeAssetsResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsDisposeAssetsResponseInputVatUseChangesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsDisposeAssetsResponseInputVatUseChangesItemReason ReadAsPropertyName(
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
            return new AssetsDisposeAssetsResponseInputVatUseChangesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsDisposeAssetsResponseInputVatUseChangesItemReason value,
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
