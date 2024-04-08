import { endpoints } from "../constants/endpoints.js";


export type ChangeWishlistQuantityRes = {
	status: 200 | number,
	isUpdated: boolean
}

export function attachQuantityCounterHandler(
	quantityInputSelector: string,
	priceInputSelector: string,
	priceDataSelector: string,
	productIdDataSelector: string
) {
	$(quantityInputSelector).on('change', function () {
		const productId = $(this).attr(productIdDataSelector);
		const newQuantity = Number($(this).val());

		const payload = { productId, newQuantity }

		$.post(endpoints.wishlist.updateQuantity, payload)
			.done(function (res: ChangeWishlistQuantityRes) {
				if (res.status != 200) {
					return;
				}

				if (res.isUpdated) {
					const priceForOne = Number($(this)
						.attr(priceDataSelector)
						.replace('$', ''));


					const USDollar = new Intl.NumberFormat('en-US', {
						style: 'currency',
						currency: 'USD',

					});

					$(`${priceInputSelector}[${productIdDataSelector}=${productId}]`)
						.text(USDollar.format(newQuantity * priceForOne).replace(',', ''));
				} else {
					$(this).val(newQuantity - 1);
				}
			})
			.fail(function (err: any) {
				console.log(err);
			});
	});
}

