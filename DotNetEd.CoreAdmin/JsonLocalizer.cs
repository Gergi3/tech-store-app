﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace DotNetEd.CoreAdmin;

public class JsonLocalizer : IStringLocalizer<JsonLocalizer>
{
	public Dictionary<string, Dictionary<string, string>> translations = new();
	private readonly IHttpContextAccessor httpContextAccessor;

	public JsonLocalizer(IHttpContextAccessor httpContextAccessor)
	{
		var assembly = Assembly.GetExecutingAssembly();
		foreach (var embeddedResource in assembly.GetManifestResourceNames().Where(e => e.EndsWith(".json")))
		{
			var textStreamReader = new StreamReader(assembly.GetManifestResourceStream(embeddedResource));
			this.translations.Add(embeddedResource, JsonSerializer.Deserialize<Dictionary<string, string>>(textStreamReader.ReadToEnd()));
		}

		this.httpContextAccessor = httpContextAccessor;
	}

	public LocalizedString this[string name] => this.GetAllStrings(false).FirstOrDefault(s => s.Name == name) ?? new LocalizedString(name, name);

	public LocalizedString this[string name, params object[] arguments] => this.GetAllStrings(false).FirstOrDefault(s => s.Name == name) ?? new LocalizedString(name, name);

	public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
	{
		var cultureKeys = this.httpContextAccessor.HttpContext.Request.Headers["Accept-Language"];

		foreach (var culture in cultureKeys)
		{
			var fileName = $"{culture}.json";
			var key = this.translations.Keys.FirstOrDefault(k => k.EndsWith(fileName));
			if (key != null)
			{
				return this.translations[key].Select(s => new LocalizedString(s.Key, s.Value));
			}
		}

		// fall back to en-US
		return this.translations[this.translations.Keys.First(k => k.EndsWith("en-US.json"))].Select(s => new LocalizedString(s.Key, s.Value));
	}
}
