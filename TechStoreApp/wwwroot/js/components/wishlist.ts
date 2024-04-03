import { endpoints } from '../constants/endpoints.js';

export type ProductDetailsRes = {
	status: 200 | number
	isDeleted: boolean
}

export function attachWishlistHandler(
	formSelector: string,
	buttonTextSelector: string,
	productIdAttrName: string,
	listenFrom: string = null
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
			productId: currentId
		}

		$.post(endpoints.wishlist.change, payload)
			.done(statusChangeSuccessHandler)
			.fail(statusChangeFailHandler)
	}

	function statusChangeSuccessHandler(res: ProductDetailsRes) {
		if (res.status != 200) {
			return;
		}

		const textSelector: string = `${formSelector}[${productIdAttrName}=${currentId}] ${buttonTextSelector}`;

		if (res.isDeleted) {
			$(textSelector).text('Add To Wishlist');
		} else {
			$(textSelector).text('Remove From Wishlist');
		}

		changeHeaderWishlistCount(res.isDeleted)
	}

	function statusChangeFailHandler(err: any) {
		console.log(err);
	}
}

export function changeHeaderWishlistCount(isDeleted: boolean) {

	const headerEl = $('#headerWishlistCount, #headerWishlistCount:hidden');
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
