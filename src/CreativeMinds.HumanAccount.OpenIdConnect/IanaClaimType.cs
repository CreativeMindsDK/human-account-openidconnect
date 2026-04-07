using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeMinds.HumanAccount.OpenIdConnect {

	/// <summary>
	/// From IANA on https://www.iana.org/assignments/jwt/jwt.xhtml
	/// </summary>
	public static class IanaClaimType {

		public static readonly IReadOnlyCollection<String> Registered = new HashSet<String>(StringComparer.OrdinalIgnoreCase) {
			Iss, Sub, Aud, Exp, Nbf, Iat, Jti
		};

		public static readonly IReadOnlyCollection<String> Public = new HashSet<String>(StringComparer.OrdinalIgnoreCase) {
			Name, GivenName, FamilyName, MiddleName, Nickname, PreferredUsername, Profile, Picture, Website, Email,
			EmailVerified, Gender, Birthdate, Zoneinfo, Locale, PhoneNumber, PhoneNumberVerified, Address, UpdatedAt, Azp,
			Nonce, AuthTime, AtHash, CHash, Acr, Amr, SubJwk, Cnf, SipFromTag, SipDate, SipCallid, SipCseqNum, SipViaBranch,
			Orig, Dest, Mky, Events, Toe, Txn, Rph, Sid, Vot, Vtm, Attest, Origid, Act, Scope, ClientId, MayAct, Jcard,
			AtUseNbr, Div, Opt, Vc, Vp, Sph, AceProfile, Cnonce, Exi, Roles, Groups, Entitlements, TokenIntrospection,
			Cdniv, Cdnicrit, Cdniip, Cdniuc, Cdniets, Cdnistt, Cdnistd, SigValClaims, AuthorisationDetails
		};

		/// <summary>
		/// The "iss" (issuer) claim identifies the principal that issued the JWT.The processing of this claim is generally application specific.
		/// The "iss" value is a case-sensitive string containing a StringOrURI value. Use of this claim is OPTIONAL.
		/// </summary>
		/// <remarks>
		/// https://www.rfc-editor.org/rfc/rfc7519.html#section-4.1.1
		/// </remarks>
		public const String Iss = "iss";
		/// <summary>
		/// The "sub" (subject) claim identifies the principal that is the subject of the JWT.
		/// The claims in a JWT are normally statements about the subject.
		/// The subject value MUST either be scoped to be locally unique in the context of the issuer
		/// or be globally unique. The processing of this claim is generally application specific.
		/// The "sub" value is a case-sensitive string containing a StringOrURI value. Use of this claim is OPTIONAL.
		/// </summary>
		/// <remarks>
		/// https://www.rfc-editor.org/rfc/rfc7519.html#section-4.1.2
		/// </remarks>
		public const String Sub = "sub";
		/// <summary>
		/// The "aud" (audience) claim identifies the recipients that the JWT is intended for.
		/// Each principal intended to process the JWT MUST identify itself with a value in the audience claim.
		/// If the principal processing the claim does not identify itself with a value in the "aud" claim
		/// when this claim is present, then the JWT MUST be rejected.
		/// In the general case, the "aud" value is an array of case-sensitive strings, each containing a StringOrURI value.
		/// In the special case when the JWT has one audience, the "aud" value MAY be a single case-sensitive string
		/// containing a StringOrURI value. The interpretation of audience values is generally application specific.
		/// Use of this claim is OPTIONAL.
		/// </summary>
		/// <remarks>
		/// https://www.rfc-editor.org/rfc/rfc7519.html#section-4.1.3
		/// </remarks>
		public const String Aud = "aud";
		public const String Exp = "exp";
		public const String Nbf = "nbf";
		public const String Iat = "iat";
		public const String Jti = "jti";
		public const String Name = "name";
		public const String GivenName = "given_name";
		public const String FamilyName = "family_name";
		public const String MiddleName = "middle_name";
		public const String Nickname = "nickname";
		public const String PreferredUsername = "preferred_username";
		public const String Profile = "profile";
		public const String Picture = "picture";
		public const String Website = "website";
		public const String Email = "email";
		public const String EmailVerified = "email_verified";
		public const String Gender = "gender";
		public const String Birthdate = "birthdate";
		public const String Zoneinfo = "zoneinfo";
		public const String Locale = "locale";
		public const String PhoneNumber = "phone_number";
		public const String PhoneNumberVerified = "phone_number_verified";
		public const String Address = "address";
		public const String UpdatedAt = "updated_at";
		public const String Azp = "azp";
		public const String Nonce = "nonce";
		public const String AuthTime = "auth_time";
		public const String AtHash = "at_hash";
		public const String Acr = "acr";
		public const String Amr = "amr";
		public const String CHash = "c_hash";
		public const String SubJwk = "sub_jwk";
		public const String Cnf = "cnf";
		public const String SipFromTag = "sip_from_tag";
		public const String SipDate = "sip_date";
		public const String SipCallid = "sip_callid";
		public const String SipCseqNum = "sip_cseq_num";
		public const String SipViaBranch = "sip_via_branch";
		public const String Orig = "orig";
		public const String Dest = "dest";
		public const String Mky = "mky";
		public const String Events = "events";
		public const String Toe = "toe";
		public const String Txn = "txn";
		public const String Rph = "rph";
		public const String Sid = "sid";
		public const String Vot = "vot";
		public const String Vtm = "vtm";
		public const String Attest = "attest";
		public const String Origid = "origid";
		public const String Act = "act";
		public const String Scope = "scope";
		public const String ClientId = "client_id";
		public const String MayAct = "may_act";
		public const String Jcard = "jcard";
		public const String AtUseNbr = "at_use_nbr";
		public const String Div = "div";
		public const String Opt = "opt";
		public const String Vc = "vc";
		public const String Vp = "vp";
		public const String Sph = "sph";
		public const String AceProfile = "ace_profile";
		public const String Cnonce = "cnonce";
		public const String Exi = "exi";
		public const String Roles = "roles";
		public const String Groups = "groups";
		public const String Entitlements = "entitlements";
		public const String TokenIntrospection = "token_introspection";
		public const String EatNonce = "eat_nonce";
		public const String Cdniv = "cdniv";
		public const String Cdnicrit = "cdnicrit";
		public const String Cdniip = "cdniip";
		public const String Cdniuc = "cdniuc";
		public const String Cdniets = "cdniets";
		public const String Cdnistt = "cdnistt";
		public const String Cdnistd = "cdnistd";
		public const String SigValClaims = "sig_val_claims";
		public const String AuthorisationDetails = "authorization_details";
	}
}


/*
 
exp
nbf
iat
jti
name
given_name
family_name
middle_name
nickname
preferred_username
profile
picture
website
email
email_verified
gender
birthdate
zoneinfo
locale
phone_number
phone_number_verified
address
updated_at
azp
nonce
auth_time
at_hash
c_hash
acr
amr
sub_jwk
cnf
sip_from_tag
sip_date
sip_callid
sip_cseq_num
sip_via_branch
orig
dest
mky
events
toe
txn
rph
sid
vot
vtm
attest
origid
act
scope
client_id
may_act
jcard
at_use_nbr
div
opt
vc
vp
sph
ace_profile
cnonce
exi
roles
groups
entitlements
token_introspection
eat_nonce
ueid
sueids
oemid
hwmodel
hwversion
oemboot
dbgstat
location
eat_profile
submods
uptime
bootcount
bootseed
dloas
swname
swversion
manifests
measurements
measres
intuse
cdniv
cdnicrit
cdniip
cdniuc
cdniets
cdnistt
cdnistd
sig_val_claims
authorization_details
verified_claims
place_of_birth
nationalities
birth_family_name
birth_given_name
birth_middle_name
salutation
title
msisdn
also_known_as
htm
htu
ath
atc
sub_id
rcd
rcdi
crn
msgi
_claim_names
_claim_sources
rdap_allowed_purposes
rdap_dnt_allowed
geohash
_sd
...
_sd_alg
sd_hash
consumerPlmnId
consumerSnpnId
producerPlmnId
producerSnpnId
producerSnssaiList
producerNsiList
producerNfSetId
producerNfServiceSetId
sourceNfInstanceId
analyticsIdList
resOwnerId

 
 
 */