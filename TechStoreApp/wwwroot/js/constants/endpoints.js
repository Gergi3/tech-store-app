export const APP_HOST = 'https://localhost:7152';
export const buildUrl = (endpoint) => APP_HOST + '/' + endpoint;
export const endpoints = {
    category: {
        list: buildUrl('categories/category-list')
    },
    product: {
        list: buildUrl('products/product-list')
    },
    wishlist: {
        change: buildUrl('wishlist/change-status'),
        updateQuantity: buildUrl('wishlist/change-quantity')
    },
    review: {
        create: buildUrl('reviews/create')
    }
};
//# sourceMappingURL=endpoints.js.map