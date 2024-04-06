import { addToQuery } from '../components/query-updater.js';
import { fetchAndDisplayProducts } from './products.js';
$('#priceFilterForm').on('submit', function (e) {
    e.preventDefault();
    const queryArr = $(this).serializeArray();
    queryArr.push({
        name: 'page',
        value: '1'
    });
    addToQuery(queryArr);
    fetchAndDisplayProducts();
});
//# sourceMappingURL=product-filters.js.map