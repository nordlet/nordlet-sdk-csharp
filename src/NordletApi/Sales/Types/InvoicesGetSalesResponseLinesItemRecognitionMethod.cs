using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesGetSalesResponseLinesItemRecognitionMethod.InvoicesGetSalesResponseLinesItemRecognitionMethodSerializer)
)]
[Serializable]
public readonly record struct InvoicesGetSalesResponseLinesItemRecognitionMethod : IStringEnum
{
    public static readonly InvoicesGetSalesResponseLinesItemRecognitionMethod PointInTime = new(
        Values.PointInTime
    );

    public static readonly InvoicesGetSalesResponseLinesItemRecognitionMethod Ratable = new(
        Values.Ratable
    );

    public static readonly InvoicesGetSalesResponseLinesItemRecognitionMethod Milestone = new(
        Values.Milestone
    );

    public static readonly InvoicesGetSalesResponseLinesItemRecognitionMethod PercentComplete = new(
        Values.PercentComplete
    );

    public InvoicesGetSalesResponseLinesItemRecognitionMethod(string value)
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
    public static InvoicesGetSalesResponseLinesItemRecognitionMethod FromCustom(string value)
    {
        return new InvoicesGetSalesResponseLinesItemRecognitionMethod(value);
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
        InvoicesGetSalesResponseLinesItemRecognitionMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesGetSalesResponseLinesItemRecognitionMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        InvoicesGetSalesResponseLinesItemRecognitionMethod value
    ) => value.Value;

    public static explicit operator InvoicesGetSalesResponseLinesItemRecognitionMethod(
        string value
    ) => new(value);

    internal class InvoicesGetSalesResponseLinesItemRecognitionMethodSerializer
        : JsonConverter<InvoicesGetSalesResponseLinesItemRecognitionMethod>
    {
        public override InvoicesGetSalesResponseLinesItemRecognitionMethod Read(
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
            return new InvoicesGetSalesResponseLinesItemRecognitionMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesGetSalesResponseLinesItemRecognitionMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesGetSalesResponseLinesItemRecognitionMethod ReadAsPropertyName(
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
            return new InvoicesGetSalesResponseLinesItemRecognitionMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesGetSalesResponseLinesItemRecognitionMethod value,
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
