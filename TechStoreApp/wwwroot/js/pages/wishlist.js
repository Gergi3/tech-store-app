import { attachQuantityCounterHandler } from '../components/quantity-counter.js';
import { changeHeaderWishlistCount } from '../components/wishlist.js';
import { endpoints } from '../constants/endpoints.js';
attachQuantityCounterHandler('.wishlist-quantity', '.wishlist-price', 'data-showed-price', 'data-product-id');
$('.wishlist-remove-form').on('submit', function (e) {
    e.preventDefault();
    const productId = $(this).attr('data-product-id');
    const payload = { productId };
    $.post(endpoints.wishlist.change, payload)
        .done(function (res) {
        if (res.status == 200 && res.isDeleted == true) {
            $(`.wishlist-item[data-product-id=${productId}]`).remove();
            changeHeaderWishlistCount(res.isDeleted);
        }
    })
        .fail(function (err) {
        console.log(err);
    });
});
//# sourceMappingURL=wishlist.js.map