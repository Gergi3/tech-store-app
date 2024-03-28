export const APP_HOST = 'https://localhost:7152';
export const buildUrl = (endpoint) => APP_HOST + '/' + endpoint;
export const endpoints = {
    category: {
        list: buildUrl('categories/category-list')
    },
    product: {
        list: buildUrl('products/product-list')
    }
};
//# sourceMappingURL=endpoints.js.map