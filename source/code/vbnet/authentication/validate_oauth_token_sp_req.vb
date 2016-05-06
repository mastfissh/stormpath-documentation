Dim validationRequest = OauthRequests.NewJwtAuthenticationRequest() _
    .SetJwt(access_token) _
    .Build()

Dim accessToken = Await app.NewJwtAuthenticator() _
    .AuthenticateAsync(validationRequest)
