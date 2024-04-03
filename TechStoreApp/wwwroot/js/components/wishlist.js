import { endpoints } from '../constants/endpoints.js';
export function attachWishlistHandler(formSelector, buttonTextSelector, productIdAttrName, listenFrom = null) {
    if (listenFrom) {
        $(listenFrom).on('submit', formSelector, buttonClickHandler);
    }
    else {
        $(formSelector).on('submit', buttonClickHandler);
    }
    let currentId = null;
    function buttonClickHandler(e) {
        e.preventDefault();
        currentId = $(this).attr(productIdAttrName);
        const payload = {
            productId: currentId
        };
        $.post(endpoints.wishlist.change, payload)
            .done(statusChangeSuccessHandler)
            .fail(statusChangeFailHandler);
    }
    function statusChangeSuccessHandler(res) {
        if (res.status != 200) {
            return;
        }
        const textSelector = `${formSelector}[${productIdAttrName}=${currentId}] ${buttonTextSelector}`;
        if (res.isDeleted) {
            $(textSelector).text('Add To Wishlist');
        }
        else {
            $(textSelector).text('Remove From Wishlist');
        }
        changeHeaderWishlistCount(res.isDeleted);
    }
    function statusChangeFailHandler(err) {
        console.log(err);
    }
}
export function changeHeaderWishlistCount(isDeleted) {
    const headerEl = $('#headerWishlistCount, #headerWishlistCount:hidden');
    let headerCounter = Number(headerEl.text());
    if (isDeleted) {
        headerCounter--;
    }
    else {
        headerCounter++;
    }
    headerEl.text(headerCounter);
    if (headerCounter <= 0) {
        headerEl.hide();
    }
    else if (headerCounter > 0) {
        headerEl.show();
    }
}
//# sourceMappingURL=wishlist.js.map