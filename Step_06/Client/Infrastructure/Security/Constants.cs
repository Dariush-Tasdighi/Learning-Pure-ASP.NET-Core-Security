﻿namespace Infrastructure.Security;

public static class Constants : object
{
	public const string DefaultScheme =
		Microsoft.AspNetCore.Authentication.Cookies
		.CookieAuthenticationDefaults.AuthenticationScheme;

	public const string NameKeyName =
		System.Security.Claims.ClaimTypes.Name;

	public const string RoleKeyName =
		System.Security.Claims.ClaimTypes.Role;

	public const string UserIdClaimKeyName = "UserId";

	//public const string UserIdClaimKeyName =
	//	System.Security.Claims.ClaimTypes.NameIdentifier;

	public const string UserIPClaimKeyName = "UserIP";
	public const string LastNameClaimKeyName = "LastName";
	public const string RoleCodeClaimKeyName = "RoleCode";
	public const string UsernameClaimKeyName = "Username";
	public const string FirstNameClaimKeyName = "FirstName";
	public const string SessionIdClaimKeyName = "SessionId";
	public const string EmailAddressClaimKeyName = "EmailAddress";
	public const string CellPhoneNumberClaimKeyName = "CellPhoneNumber";

	static Constants()
	{
	}
}
