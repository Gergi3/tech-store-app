import { endpoints } from '../constants/endpoints.js';
export function attachQuantityCounterHandler(quantityInputSelector, priceInputSelector, priceDataSelector, productIdDataSelector) {
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
        const payload = { productId, newQuantity };
        $.post(endpoints.wishlist.updateQuantity, payload)
            .done(function (res) {
            if (res.status != 200 || !res.isUpdated) {
                return;
            }
            const priceForOne = Number(showedPrice.replace('$', ''));
            const USDollar = new Intl.NumberFormat('en-US', {
                style: 'currency',
                currency: 'USD',
            });
            $(`${priceInputSelector}[${productIdDataSelector}=${productId}]`)
                .text(USDollar
                .format(newQuantity * priceForOne)
                .replace(',', ''));
        })
            .fail(function (err) {
            console.log(err);
        });
    });
}
//# sourceMappingURL=quantity-counter.js.map