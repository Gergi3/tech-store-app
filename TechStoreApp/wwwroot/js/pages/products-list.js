import { fetchAndDisplayProducts } from './products.js';
import { attachWishlistHandler } from '../components/wishlist.js';
import { addToQuery } from '../components/query-updater.js';
attachWishlistHandler('.add-to-wishlist-form', '.add-to-wishlist-btn-text', 'data-product-id', '.tp-shop-main-wrapper');
$('body').on('submit', 'form.pagination-form', function (e) {
    e.preventDefault();
    const queryArr = $(this).serializeArray();
    addToQuery(queryArr);
    fetchAndDisplayProducts();
});
//# sourceMappingURL=products-list.js.map