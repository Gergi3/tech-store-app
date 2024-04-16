import { fetchAndDisplayProducts } from './products.js';
import { attachSessionHandler } from '../components/session-handler.js';
import { addToQuery } from '../components/query-updater.js';
attachSessionHandler('.add-to-wishlist-form', '.add-to-wishlist-btn-text', 'data-product-id', 'data-status', 'Wishlist', '#headerWishlistCount', '.tp-shop-main-wrapper');
attachSessionHandler('.add-to-cart-form', '.add-to-cart-btn-text', 'data-product-id', 'data-status', 'Cart', '#headerCartCount', '.tp-shop-main-wrapper');
$('body').on('submit', 'form.pagination-form', function (e) {
    e.preventDefault();
    const queryArr = $(this).serializeArray();
    addToQuery(queryArr);
    fetchAndDisplayProducts();
});
//# sourceMappingURL=products-list.js.map