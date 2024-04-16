import { endpoints } from '../constants/endpoints.js';

export type ChangeWishlistQuantityRes = {
	status: 200 | number,
	isUpdated: boolean
}

export function attachQuantityCounterHandler(
	quantityInputSelector: string,
	priceInputSelector: string,
	priceDataSelector: string,
	productIdDataSelector: string,
	statusSelector: string,
) {
	let lastValidQuantity = $(quantityInputSelector).val();
	$(quantityInputSelector).on('change', function () {
		const newQuantity = Number($(this).val());

		if (!newQuantity || newQuantity < 0 || newQuantity > Number.MAX_SAFE_INTEGER) {
			$(this).val(lastValidQuantity);
			return;
		}
		lastValidQuantity = newQuantity;

		const productId = $(this).attr(productIdDataSelector);
		const showedPrice = $(this).attr(priceDataSelector);
		const status = $(this).attr(statusSelector);
		const payload = { productId, newQuantity, status }

		$.post(endpoints.session.updateQuantity, payload)
			.done(function (res: ChangeWishlistQuantityRes) {
				if (res.status != 200 || !res.isUpdated) {
					return;
				}

				const priceForOne = Number(showedPrice.replace('$', ''));

				const USDollar = new Intl.NumberFormat('en-US', {
					style: 'currency',
					currency: 'USD',
				});

				const newPriceText = USDollar
					.format(newQuantity * priceForOne)
					.replace(',', '')

				$(`${priceInputSelector}[${productIdDataSelector}=${productId}]`)
					.text(newPriceText);

				updateTotalCount();
			})
			.fail(function (err: any) {
				console.log(err);
			});
	});
}

export function updateTotalCount() {
	const USDollar = new Intl.NumberFormat('en-US', {
		style: 'currency',
		currency: 'USD',
	});

	let totalPrice = 0;
	$('.session-price').each(function () {
		totalPrice += Number($(this).text().replace('$', ''))
	})
	const newTotalPriceText = USDollar
		.format(totalPrice)
		.replace(',', '');

	$('.total-checkout-price').text(newTotalPriceText);
}
