using System;

namespace CreativeMinds.HumanAccount.OpenIdConnect {

	public static class ErrorCode {
		public const String InvalidRequest = "invalid_request";
		public const String InvalidClient = "invalid_client";
		public const String InvalidGrant = "invalid_grant";
		public const String UnauthorisedClient = "unauthorized_client";
		public const String UnsupportedGrantType = "unsupported_grant_type";
		public const String InvalidScope = "invalid_scope";
		public const String AccessDenied = "access_denied";
		public const String UnsupportedResponseType = "unsupported_response_type";
		public const String ServerError = "server_error";
		public const String TemporarilyUnavailable = "temporarily_unavailable";

		public const String InteractionRequired = "interaction_required";
		public const String LoginRequired = "login_required";
		public const String AccountSelectionRequired = "account_selection_required";
		public const String ConsentRequired = "consent_required";
		public const String InvalidRequestUri = "invalid_request_uri";
		public const String InvalidRequestObject = "invalid_request_object";
		public const String RequestNotSupported = "request_not_supported";
		public const String RequestUriNotSupported = "request_uri_not_supported";
		public const String RegistrationNotSupported = "registration_not_supported";

		public const String UnsupportedTokenType = "unsupported_token_type";

		public const String InvalidRedirectUri = "invalid_redirect_uri";
		public const String InvalidClientMetadata = "invalid_client_metadata";

		public const String ConfirmationRequired = "confirmation_required";
		public const String InvalidTarget = "invalid_target";
		public const String AuthorisationPending = "authorization_pending";
		public const String SlowDown = "slow_down";
		public const String ExpiredToken = "expired_token";
		public const String ExpiredLoginHintToken = "expired_login_hint_token";
		public const String UnknownUserId = "unknown_user_id";
		public const String MissingUserCode = "missing_user_code";
		public const String InvalidUserCode = "invalid_user_code";
		public const String InvalidBindingMessage = "invalid_binding_message";
	}
}
