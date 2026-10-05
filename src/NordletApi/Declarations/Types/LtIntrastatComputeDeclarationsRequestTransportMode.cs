using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtIntrastatComputeDeclarationsRequestTransportMode.LtIntrastatComputeDeclarationsRequestTransportModeSerializer)
)]
[Serializable]
public readonly record struct LtIntrastatComputeDeclarationsRequestTransportMode : IStringEnum
{
    public static readonly LtIntrastatComputeDeclarationsRequestTransportMode One = new(Values.One);

    public static readonly LtIntrastatComputeDeclarationsRequestTransportMode Two = new(Values.Two);

    public static readonly LtIntrastatComputeDeclarationsRequestTransportMode Three = new(
        Values.Three
    );

    public static readonly LtIntrastatComputeDeclarationsRequestTransportMode Four = new(
        Values.Four
    );

    public static readonly LtIntrastatComputeDeclarationsRequestTransportMode Five = new(
        Values.Five
    );

    public static readonly LtIntrastatComputeDeclarationsRequestTransportMode Seven = new(
        Values.Seven
    );

    public static readonly LtIntrastatComputeDeclarationsRequestTransportMode Eight = new(
        Values.Eight
    );

    public static readonly LtIntrastatComputeDeclarationsRequestTransportMode Nine = new(
        Values.Nine
    );

    public LtIntrastatComputeDeclarationsRequestTransportMode(string value)
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
    public static LtIntrastatComputeDeclarationsRequestTransportMode FromCustom(string value)
    {
        return new LtIntrastatComputeDeclarationsRequestTransportMode(value);
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
        LtIntrastatComputeDeclarationsRequestTransportMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LtIntrastatComputeDeclarationsRequestTransportMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        LtIntrastatComputeDeclarationsRequestTransportMode value
    ) => value.Value;

    public static explicit operator LtIntrastatComputeDeclarationsRequestTransportMode(
        string value
    ) => new(value);

    internal class LtIntrastatComputeDeclarationsRequestTransportModeSerializer
        : JsonConverter<LtIntrastatComputeDeclarationsRequestTransportMode>
    {
        public override LtIntrastatComputeDeclarationsRequestTransportMode Read(
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
            return new LtIntrastatComputeDeclarationsRequestTransportMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtIntrastatComputeDeclarationsRequestTransportMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtIntrastatComputeDeclarationsRequestTransportMode ReadAsPropertyName(
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
            return new LtIntrastatComputeDeclarationsRequestTransportMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtIntrastatComputeDeclarationsRequestTransportMode value,
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
        public const string One = "1";

        public const string Two = "2";

        public const string Three = "3";

        public const string Four = "4";

        public const string Five = "5";

        public const string Seven = "7";

        public const string Eight = "8";

        public const string Nine = "9";
    }
}
