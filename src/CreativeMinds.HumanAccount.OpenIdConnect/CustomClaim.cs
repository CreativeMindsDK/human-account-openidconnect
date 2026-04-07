using System;

namespace CreativeMinds.HumanAccount.OpenIdConnect {

	public static class CustomClaim {
		public const String AgeCheck13Plus = "http://human-account.com/claims/age_check_13_plus";
		public const String AgeCheck15Plus = "http://human-account.com/claims/age_check_15_plus";
		public const String AgeCheck18Plus = "http://human-account.com/claims/age_check_18_plus";
		public const String AgeCheck21Plus = "http://human-account.com/claims/age_check_21_plus";
		public const String BirthDateVerified = "http://human-account.com/claims/birthdate_verified";
		public const String NameVerified = "http://human-account.com/claims/name_verified";
	}
}
