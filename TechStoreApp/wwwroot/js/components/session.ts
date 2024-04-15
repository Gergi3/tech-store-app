import { endpoints } from '../constants/endpoints.js';

export type ProductDetailsRes = {
	status: 200 | number
	isDeleted: boolean
}

export function attachSessionHandler(
	formSelector: string,
	buttonTextSelector: string,
	productIdAttrName: string,
	statusAttrName: string,
	statusText: string,
	headerCountSelector: string,
	listenFrom: string = null,
) {
	if (listenFrom) {
		$(listenFrom).on('submit', formSelector, buttonClickHandler);
	}
	else {
		$(formSelector).on('submit', buttonClickHandler);
	}

	let currentId = null;

	function buttonClickHandler(e) {
		e.preventDefault();

		currentId = $(this).attr(productIdAttrName);

		const payload = {
			productId: currentId,
			status: $(this).attr(statusAttrName)
		}

		$.post(endpoints.session.change, payload)
			.done(statusChangeSuccessHandler)
			.fail(statusChangeFailHandler)
	}

	function statusChangeSuccessHandler(res: ProductDetailsRes) {
		if (res.status != 200) {
			return;
		}

		const textSelector: string = `${formSelector}[${productIdAttrName}=${currentId}] ${buttonTextSelector}`;

		if (res.isDeleted) {
			$(textSelector).text(`Add To ${statusText}`);
		} else {
			$(textSelector).text(`Remove From ${statusText}`);
		}

		changeHeaderCount(res.isDeleted, headerCountSelector)
	}

	function statusChangeFailHandler(err: any) {
		console.log(err);
	}
}

export function changeHeaderCount(isDeleted: boolean, selector: string) {

	const headerEl = $(`${selector}, ${selector}:hidden`);
	let headerCounter = Number(headerEl.text());

	if (isDeleted) {
		headerCounter--;
	} else {
		headerCounter++;
	}

	headerEl.text(headerCounter)

	if (headerCounter <= 0) {
		headerEl.hide();
	} else if (headerCounter > 0) {
		headerEl.show();
	}
}
