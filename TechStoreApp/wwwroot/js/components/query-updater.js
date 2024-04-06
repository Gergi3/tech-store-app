export function addToQuery(queryArr) {
    const url = new URL(window.location.href);
    queryArr.forEach(({ name, value }) => {
        url.searchParams.set(name, value);
    });
    history.pushState({}, '', url);
}
//# sourceMappingURL=query-updater.js.map