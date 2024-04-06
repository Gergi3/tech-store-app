export function addToQuery(
	queryArr: JQuery.NameValuePair[]
) {
	const url = new URL(window.location.href);
	queryArr.forEach(({ name, value }) => {
		url.searchParams.set(name, value);
	});

	history.pushState({}, '', url);
}
