import { endpoints } from '../constants/endpoints.js';
export function attachSessionHandler(formSelector, buttonTextSelector, productIdAttrName, statusAttrName, statusText, headerCountSelector, listenFrom = null) {
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
            productId: currentId,
            status: $(this).attr(statusAttrName)
        };
        $.post(endpoints.session.change, payload)
            .done(statusChangeSuccessHandler)
            .fail(statusChangeFailHandler);
    }
    function statusChangeSuccessHandler(res) {
        if (res.status != 200) {
            return;
        }
        const textSelector = `${formSelector}[${productIdAttrName}=${currentId}] ${buttonTextSelector}`;
        if (res.isDeleted) {
            $(textSelector).text(`Add To ${statusText}`);
        }
        else {
            $(textSelector).text(`Remove From ${statusText}`);
        }
        changeHeaderCount(res.isDeleted, headerCountSelector);
    }
    function statusChangeFailHandler(err) {
        console.log(err);
    }
}
export function changeHeaderCount(isDeleted, selector) {
    const headerEl = $(`${selector}, ${selector}:hidden`);
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
//# sourceMappingURL=session.js.map