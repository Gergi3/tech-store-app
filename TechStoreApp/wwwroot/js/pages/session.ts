import { attachQuantityCounterHandler, updateTotalCount } from '../components/quantity-counter.js';
import { ProductDetailsRes, changeHeaderCount } from '../components/session-handler.js';
import { endpoints } from '../constants/endpoints.js'

attachQuantityCounterHandler('.session-quantity', '.session-price' , 'data-showed-price', 'data-product-id', 'data-status');

$('.session-remove-form').on('submit', function (e) {
	e.preventDefault();

	const productId = $(this).attr('data-product-id');
	const status = $(this).attr('data-status');
	const payload = { productId, status };

	$.post(endpoints.session.change, payload)
		.done(function (res: ProductDetailsRes) {
			if (res.status == 200 && res.isDeleted == true) {
				$(`.session-item[data-product-id=${productId}]`).remove();

				if (status == 'Wishlisted') {
					changeHeaderCount(res.isDeleted, '#headerWishlistCount');
				}
				else {
					changeHeaderCount(res.isDeleted, '#headerCartCount');
					updateTotalCount()
				}
			}
		})
		.fail(function (err: any) {
			console.log(err);
		})
});
