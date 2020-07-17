let utils = require(`./utils`);

class Calculator {

    divide(n1) {
        let result = -9999;
        let separator = `,`;
        // if doesn't contain a comma call this
        if (!n1.contains(`,`)) {
            // separator is replaced with the result of the validSeparator call when passing n1
            separator = utils.validSeparator(n1);    // slows down test
        }
        let numbers = n1.split(separator);
        for (let number in numbers) {
            if (utils.isNumeric(number)) {
                return result;
            }
        }
        result = utils.toNumber(numbers[0]) / Utils.toNumber(numbers[1]);
        return result;
    }

    // multiply(n1) {
    //     result = -9999;
    //     String[] numbers = n1.split(",");
    //     for (number : numbers) {
    //         if (!Utils.isNumeric(number)) {  // check number is valid
    //             return result;
    //         }
    //     }
    //     result = Utils.toNumber(numbers[0]) * Utils.toNumber(numbers[1]);
    //     return result;
    // }

    // subtract(n1) {
    //     result = -9999;

    //     String[] numbers = n1.split(",");
    //     for (number : numbers) {
    //         if (!Utils.isNumeric(number)) {  // check number is valid
    //             return result;
    //         }
    //     }
    //     result = Utils.toNumber(numbers[0]) - Utils.toNumber(numbers[1]);
    //     return result;
    // }
}
