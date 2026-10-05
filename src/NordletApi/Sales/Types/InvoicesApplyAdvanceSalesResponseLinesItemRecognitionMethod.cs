using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod.InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethodSerializer)
)]
[Serializable]
public readonly record struct InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod
    : IStringEnum
{
    public static readonly InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod PointInTime =
        new(Values.PointInTime);

    public static readonly InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod Ratable =
        new(Values.Ratable);

    public static readonly InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod Milestone =
        new(Values.Milestone);

    public static readonly InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod PercentComplete =
        new(Values.PercentComplete);

    public InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod(string value)
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
    public static InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod FromCustom(
        string value
    )
    {
        return new InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod(value);
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
        InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod value
    ) => value.Value;

    public static explicit operator InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod(
        string value
    ) => new(value);

    internal class InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethodSerializer
        : JsonConverter<InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod>
    {
        public override InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod Read(
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
            return new InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod ReadAsPropertyName(
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
            return new InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesApplyAdvanceSalesResponseLinesItemRecognitionMethod value,
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
        public const string PointInTime = "point_in_time";

        public const string Ratable = "ratable";

        public const string Milestone = "milestone";

        public const string PercentComplete = "percent_complete";
    }
}
