import { endpoints } from '../constants/endpoints.js';

const loadMoreBtn = $('#loadMoreBtn');
const progressBar = $('#categoryProgressBar');
const categoriesContainerElement = $('#categoryItemsContainer');

const take = parseInt(loadMoreBtn.attr('data-take'));
const count = parseInt(loadMoreBtn.attr('data-count'));
let nextSkip;

attachEventHandlers();

function attachEventHandlers() {
	categoriesContainerElement.on('animationstart', '.tp-category-item-container', function () {
		this.classList.remove('opacity-0')
	});

	loadMoreBtn.on('click', buttonClickHandler);
}

function buttonClickHandler() {
	const currentSkipEl = loadMoreBtn.attr('data-skip');
	nextSkip = parseInt(currentSkipEl) + take;

	const endpoint = endpoints.category.list;
	const options = { skip: nextSkip, take };

	$.post(endpoint, options, 'json')
		.done(fetchListSuccessHandler)
		.fail(fetchListFailHandler);
}

function fetchListSuccessHandler(res: string) {
	loadMoreBtn.attr('data-skip', nextSkip);
	categoriesContainerElement.append(res);

	let showedElementsCount = nextSkip + take;
	if (count <= showedElementsCount) {
		showedElementsCount = count;
		loadMoreBtn.hide();
	}

	const newWidth = Math.ceil((showedElementsCount / count) * 100);
	progressBar.attr('data-width', newWidth + '%')
	$('#categoryProgressBar').trigger('data-width-changed');
	$('#categoriesShowing').text(showedElementsCount);

}

function fetchListFailHandler(err: any) {
	console.log(err);
}
