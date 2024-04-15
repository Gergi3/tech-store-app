import { attachSessionHandler } from '../components/session.js';
attachSessionHandler('#wishlistForm', '#wishlistButtonText', 'data-product-id', 'data-status', 'Wishlist', '#headerWishlistCount');
attachSessionHandler('#cartForm', '#cartButtonText', 'data-product-id', 'data-status', 'Cart', '#headerCartCount');
//# sourceMappingURL=product-details.js.map