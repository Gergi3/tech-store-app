using System.Text.RegularExpressions;
using Unidecode.Net8;

namespace TechStoreApp.Common.Extensions;

public static class StringSlugExtension
{
	public static bool IsSlug(this string str)
	{
		bool isMatch = Regex.IsMatch(str, "^[a-z\\d](?:[a-z\\d_-]*[a-z\\d])?$");

		return isMatch;
	}

	public static string ToSlug(this string str)
	{
		// decode cyrillics and such
		string slugged = Unidecoder.Unidecode(str).ToLower();

		// invalid chars           
		slugged = Regex.Replace(slugged, @"[^a-z0-9\s-]", "");

		// convert multiple spaces into one space   
		slugged = Regex.Replace(slugged, @"\s+", " ").Trim();

		// hyphens
		slugged = Regex.Replace(slugged, @"\s", "-");

		return slugged;
	}
}
