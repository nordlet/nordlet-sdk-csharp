using global::System.Text.Json;
using NordletApi.Core;

namespace NordletApi;

public partial class PayrollClient : IPayrollClient
{
    private readonly RawClient _client;

    internal PayrollClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<PostV1PayrollDepartmentsCreateResponse>
    > PostV1PayrollDepartmentsCreateAsyncCore(
        PostV1PayrollDepartmentsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/departments/create",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollDepartmentsCreateResponse>(
                    responseBody
                )!;
                return new WithRawResponse<PostV1PayrollDepartmentsCreateResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<
        WithRawResponse<PostV1PayrollDepartmentsListResponse>
    > PostV1PayrollDepartmentsListAsyncCore(
        PostV1PayrollDepartmentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/departments/list",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollDepartmentsListResponse>(
                    responseBody
                )!;
                return new WithRawResponse<PostV1PayrollDepartmentsListResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<
        WithRawResponse<PostV1PayrollSchedulesCreateResponse>
    > PostV1PayrollSchedulesCreateAsyncCore(
        PostV1PayrollSchedulesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/schedules/create",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollSchedulesCreateResponse>(
                    responseBody
                )!;
                return new WithRawResponse<PostV1PayrollSchedulesCreateResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<
        WithRawResponse<PostV1PayrollSchedulesListResponse>
    > PostV1PayrollSchedulesListAsyncCore(
        PostV1PayrollSchedulesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/schedules/list",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollSchedulesListResponse>(
                    responseBody
                )!;
                return new WithRawResponse<PostV1PayrollSchedulesListResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<WithRawResponse<PostV1PayrollCalcResponse>> PostV1PayrollCalcAsyncCore(
        PostV1PayrollCalcRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/calc",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollCalcResponse>(responseBody)!;
                return new WithRawResponse<PostV1PayrollCalcResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<
        WithRawResponse<PostV1PayrollRunsCreateResponse>
    > PostV1PayrollRunsCreateAsyncCore(
        PostV1PayrollRunsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/runs/create",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollRunsCreateResponse>(
                    responseBody
                )!;
                return new WithRawResponse<PostV1PayrollRunsCreateResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<WithRawResponse<PostV1PayrollRunsGetResponse>> PostV1PayrollRunsGetAsyncCore(
        PostV1PayrollRunsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/runs/get",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollRunsGetResponse>(
                    responseBody
                )!;
                return new WithRawResponse<PostV1PayrollRunsGetResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<
        WithRawResponse<PostV1PayrollRunsListResponse>
    > PostV1PayrollRunsListAsyncCore(
        PostV1PayrollRunsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/runs/list",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollRunsListResponse>(
                    responseBody
                )!;
                return new WithRawResponse<PostV1PayrollRunsListResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<
        WithRawResponse<PostV1PayrollRunsApproveResponse>
    > PostV1PayrollRunsApproveAsyncCore(
        PostV1PayrollRunsApproveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/runs/approve",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollRunsApproveResponse>(
                    responseBody
                )!;
                return new WithRawResponse<PostV1PayrollRunsApproveResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<
        WithRawResponse<PostV1PayrollRunsCancelResponse>
    > PostV1PayrollRunsCancelAsyncCore(
        PostV1PayrollRunsCancelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/runs/cancel",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollRunsCancelResponse>(
                    responseBody
                )!;
                return new WithRawResponse<PostV1PayrollRunsCancelResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async Task<
        WithRawResponse<PostV1PayrollPaymentsExportResponse>
    > PostV1PayrollPaymentsExportAsyncCore(
        PostV1PayrollPaymentsExportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new NordletApi.Core.QueryStringBuilder.Builder(capacity: 0)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new NordletApi.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "v1/payroll/payments/export",
                    Body = request,
                    QueryString = _queryString,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<PostV1PayrollPaymentsExportResponse>(
                    responseBody
                )!;
                return new WithRawResponse<PostV1PayrollPaymentsExportResponse>()
                {
                    Data = responseData,
                    RawResponse = new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new NordletApiApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new NordletApi.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 401:
                        throw new UnauthorizedError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 403:
                        throw new ForbiddenError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 404:
                        throw new NotFoundError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 409:
                        throw new ConflictError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                    case 500:
                        throw new InternalServerError(
                            JsonUtils.Deserialize<ErrorResponse>(responseBody),
                            rawResponse: new NordletApi.RawResponse()
                            {
                                StatusCode = response.Raw.StatusCode,
                                Url =
                                    response.Raw.RequestMessage?.RequestUri
                                    ?? new Uri("about:blank"),
                                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                            }
                        );
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new NordletApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new NordletApi.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollDepartmentsCreateAsync(
    ///     new PostV1PayrollDepartmentsCreateRequest { Code = "code", Name = "name" }
    /// );
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollDepartmentsCreateResponse> PostV1PayrollDepartmentsCreateAsync(
        PostV1PayrollDepartmentsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollDepartmentsCreateResponse>(
            PostV1PayrollDepartmentsCreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollDepartmentsListAsync(new PostV1PayrollDepartmentsListRequest());
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollDepartmentsListResponse> PostV1PayrollDepartmentsListAsync(
        PostV1PayrollDepartmentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollDepartmentsListResponse>(
            PostV1PayrollDepartmentsListAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollSchedulesCreateAsync(
    ///     new PostV1PayrollSchedulesCreateRequest { Code = "code", Name = "name" }
    /// );
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollSchedulesCreateResponse> PostV1PayrollSchedulesCreateAsync(
        PostV1PayrollSchedulesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollSchedulesCreateResponse>(
            PostV1PayrollSchedulesCreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollSchedulesListAsync(new PostV1PayrollSchedulesListRequest());
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollSchedulesListResponse> PostV1PayrollSchedulesListAsync(
        PostV1PayrollSchedulesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollSchedulesListResponse>(
            PostV1PayrollSchedulesListAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollCalcAsync(
    ///     new PostV1PayrollCalcRequest { TaxableBase = "taxableBase", Date = "date" }
    /// );
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollCalcResponse> PostV1PayrollCalcAsync(
        PostV1PayrollCalcRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollCalcResponse>(
            PostV1PayrollCalcAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollRunsCreateAsync(
    ///     new PostV1PayrollRunsCreateRequest { Year = 1000000, Month = 1000000 }
    /// );
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollRunsCreateResponse> PostV1PayrollRunsCreateAsync(
        PostV1PayrollRunsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollRunsCreateResponse>(
            PostV1PayrollRunsCreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollRunsGetAsync(new PostV1PayrollRunsGetRequest { Id = "id" });
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollRunsGetResponse> PostV1PayrollRunsGetAsync(
        PostV1PayrollRunsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollRunsGetResponse>(
            PostV1PayrollRunsGetAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollRunsListAsync(new PostV1PayrollRunsListRequest());
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollRunsListResponse> PostV1PayrollRunsListAsync(
        PostV1PayrollRunsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollRunsListResponse>(
            PostV1PayrollRunsListAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollRunsApproveAsync(
    ///     new PostV1PayrollRunsApproveRequest { Id = "id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollRunsApproveResponse> PostV1PayrollRunsApproveAsync(
        PostV1PayrollRunsApproveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollRunsApproveResponse>(
            PostV1PayrollRunsApproveAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollRunsCancelAsync(new PostV1PayrollRunsCancelRequest { Id = "id" });
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollRunsCancelResponse> PostV1PayrollRunsCancelAsync(
        PostV1PayrollRunsCancelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollRunsCancelResponse>(
            PostV1PayrollRunsCancelAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Payroll.PostV1PayrollPaymentsExportAsync(
    ///     new PostV1PayrollPaymentsExportRequest { RunId = "runId", BankAccountId = "bankAccountId" }
    /// );
    /// </code></example>
    public WithRawResponseTask<PostV1PayrollPaymentsExportResponse> PostV1PayrollPaymentsExportAsync(
        PostV1PayrollPaymentsExportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PostV1PayrollPaymentsExportResponse>(
            PostV1PayrollPaymentsExportAsyncCore(request, options, cancellationToken)
        );
    }
}
