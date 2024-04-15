import { endpoints } from '../constants/endpoints.js';
$('#createReviewForm').on('submit', function (e) {
    e.preventDefault();
    const values = {};
    $.each($(this).serializeArray(), function (i, field) {
        values[field.name] = field.value;
    });
    $.post(endpoints.review.create, values)
        .done(function (res) {
        $('#reviewsContainer').prepend(res);
        $('#createReviewForm').remove();
        $('.tp-product-details-review-form-title').text('Thank you for reviewing this product!');
    })
        .err(function (err) {
        console.log(err);
    });
});
//# sourceMappingURL=create-review.js.map