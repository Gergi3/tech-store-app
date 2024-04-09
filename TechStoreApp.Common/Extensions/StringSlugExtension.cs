using System.Text;
using System.Text.RegularExpressions;
using Unidecode.Net8;

namespace TechStoreApp.Common.Extensions;

public static class StringSlugExtension
{
	public static bool IsSlug(
		this string str)
	{
		bool isMatch = Regex.IsMatch(str, @"^[a-z\d](?:[a-z\d_-]*[a-z\d])?$");

		return isMatch;
	}

	public static string ToSlug(
		this string str)
	{
		if (str == null)
		{
			return "";
		}

		const int maxLength = 80;
		int strLength = str.Length;
		bool prevDash = false;
		StringBuilder sb = new(strLength);
		char c;

		for (int i = 0; i < strLength; i++)
		{
			c = str[i];
			if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
			{
				sb.Append(c);
				prevDash = false;
			}
			else if (c >= 'A' && c <= 'Z')
			{
				// convert to lowercase
				sb.Append((char)(c | 32));
				prevDash = false;
			}
			else if (c == ' ' || c == ',' || c == '.' || c == '/' ||
				c == '\\' || c == '-' || c == '_' || c == '=')
			{
				if (!prevDash && sb.Length > 0)
				{
					sb.Append('-');
					prevDash = true;
				}
			}
			else if (c >= 128)
			{
				int prevlen = sb.Length;
				sb.Append(Unidecoder.Unidecode(c));
				if (prevlen != sb.Length)
				{
					prevDash = false;
				}
			}
			if (i == maxLength)
			{
				break;
			}
		}

		if (prevDash)
		{
			return sb.ToString().Substring(0, sb.Length - 1);
		}
		else
		{
			return sb.ToString();
		}
	}
}
