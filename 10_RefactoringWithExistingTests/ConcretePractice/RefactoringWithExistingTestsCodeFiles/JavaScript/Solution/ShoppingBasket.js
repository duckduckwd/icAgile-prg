class Item {
    constructor(id, name, price, vat) {
        this._id = id;
        this._name = name;
        this._price = price;
        this._vat = vat;
    }

    get name() {
        return this._name;
    }

    get price() {
        return this._price;
    }

    get vat() {
        return this._vat;
    }
}

class ShoppingBasket {
    constructor() {
        this._basket = [];
    }

    get basket() {
        return this._basket;
    }

    set basket(item) {
        if (item instanceof Item) {
            this._basket.push(item);
        }
    }
}

const vatRate = 1.2;

const createBasketRow = (item, property) => {
    let itemOutput = ``;
    let priceToAdd = 0;
    switch (property) {
        case `_name`:
            itemOutput += `${item[property]}`;
            itemOutput += item[property].length < 16 ? `\t\t\t` : `\t\t`
            break;
        case `_price`:
            const priceToCharge = item._vat ? (item[property] * vatRate).toFixed(2) : item[property].toFixed(2);
            priceToAdd += parseFloat(priceToCharge);
            itemOutput += `${priceToCharge}\n`;
            break;
        case `_vat`:
        case `_id`:
        default:
            break;
    }
    return { itemOutput, priceToAdd };
}

const printBasket = basket => {
    let basketOutput = `Item Name\t\t\tPrice\n`;
    let total = 0;
    for (let item of basket) {
        for (let property in item) {
            let { itemOutput, priceToAdd } = createBasketRow(item, property);
            basketOutput += itemOutput;
            total += priceToAdd;
        }
    }
    basketOutput += `\n\t\t\tTotal\t£${total.toFixed(2)}`;
    return basketOutput;
}

const myBasket = new ShoppingBasket();

const item1 = new Item(1, "Baked Beans", 0.85, false);
myBasket.basket = item1;
console.log(printBasket(myBasket.basket));

const item2 = new Item(2, "Battenburg Cake", 1, true);
myBasket.basket = item2;
console.log(printBasket(myBasket.basket));

const item3 = new Item(3, "Granary Loaf", 1.45, false);
myBasket.basket = item3;
console.log(printBasket(myBasket.basket));

const item4 = new Item(4, "Bottle of Red Wine", 11, true);
myBasket.basket = item4;
console.log(printBasket(myBasket.basket));


module.exports = printBasket;