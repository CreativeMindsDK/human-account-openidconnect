using System;

namespace CreativeMinds.HumanAccount.OpenIdConnect {

	/// <summary>
	/// Space-delimited, case-sensitive list of ASCII string values that specifies whether the
	/// Authorization Server prompts the End-User for reauthentication and consent.
	/// The defined values are:
	/// </summary>
	public static class Prompt {
		/// <summary>
		/// The Authorization Server MUST NOT display any authentication or consent user interface pages.
		/// An error is returned if an End-User is not already authenticated or the Client does not have pre-configured
		/// consent for the requested Claims or does not fulfill other conditions for processing the request.
		/// The error code will typically be login_required, interaction_required, or another code defined in
		/// Section 3.1.2.6. This can be used as a method to check for existing authentication and/or consent.
		/// </summary>
		public const String None = "none";
		/// <summary>
		/// The Authorization Server SHOULD prompt the End-User for reauthentication. If it cannot reauthenticate the End-User, it MUST return an error, typically login_required.
		/// </summary>
		public const String Login = "login";
		/// <summary>
		/// The Authorization Server SHOULD prompt the End-User for consent before returning information to the Client. If it cannot obtain consent, it MUST return an error, typically consent_required.
		/// </summary>
		public const String Consent = "consent";
		/// <summary>
		/// The Authorization Server SHOULD prompt the End-User to select a user account.
		/// This enables an End-User who has multiple accounts at the Authorization Server to select amongst
		/// the multiple accounts that they might have current sessions for.
		/// If it cannot obtain an account selection choice made by the End-User, it MUST return an error,
		/// typically account_selection_required.
		/// </summary>
		public const String SelectAccount = "select_account";
		/// <summary>
		/// The prompt value needed to tell Open ID Connect, that a new account should be created
		/// </summary>
		/// <remarks>
		/// https://openid.net/specs/openid-connect-prompt-create-1_0.html
		/// </remarks>
		public const String Create = "create";
	}
}
