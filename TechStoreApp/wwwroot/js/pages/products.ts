import { endpoints } from '../constants/endpoints.js';
import { loader } from './loader.js';

$(window).on('popstate', function () {
	const query: string = window.location.search;

	fetchAndDisplayItems(query, null);
});

$('body').on('submit', 'form.pagination-form', function (e) {
	e.preventDefault();

	const queryArr = $(this).serializeArray();
	const query: string = '?' + $(this).serialize();

	fetchAndDisplayItems(query, queryArr);
});

function fetchAndDisplayItems(
	query: string,
	queryArr: JQuery.NameValuePair[] | null
) {
	const url: string = `${endpoints.product.list}${query}`;

	$('#product-list-content-container')
		.css('pointer-events', 'none')
		.css('user-select', 'none')
		.fadeTo(500, 0.4)
		.on('click', function (e) {
			e.preventDefault();
			e.stopPropagation();
			e.stopImmediatePropagation();
		});

	$.get(url)
		.done(fetchListSuccessHandler)
		.fail(fetchListFailHandler);

	function fetchListSuccessHandler(res: string) {
		$('#product-list-content-container').replaceWith(res);

		
		const page = Number(queryArr.find(x => x.name == 'page').value);
		const perPage = Number(queryArr.find(x => x.name == 'perPage').value);

		$('#showingFrom').text((page * perPage) - perPage + 1);
		$('#showingTo').text(page * perPage);

		if (queryArr != null) {
			const url = new URL(window.location.href);
			queryArr.forEach(({ name, value }) => {
				url.searchParams.set(name, value);
			});
			history.pushState({}, '', url);
		}
	}

	function fetchListFailHandler(err: any) {
		console.log(err);
	}
}

