import { endpoints } from '../constants/endpoints.js';

$(window).on('popstate', function () {
	fetchAndDisplayProducts();
});

export function fetchAndDisplayProducts() {
	let query = window.location.search;

	const pathname = window.location.pathname
		.split('/')
		.filter(n => n);

	if (pathname[0] == 'categories' && pathname[2] == 'products') {
		query = query.concat(`&categorySlug=${pathname[1]}`); 
	}

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
		$('.tp-shop-area select').niceSelect();
	}

	function fetchListFailHandler(err: any) {
		console.log(err);
	}
}

