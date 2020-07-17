function toNumber(s) {
    return parseInt(s);
}

function isNumeric(str) {
    stringRegEx = new RegExp(`[+-]?\\d*(\\.\\d+)?`);
    return stringRegEx.test(str);
}

function validSeparator(s) {
    // Example of a slow method
    let index = 0;
    while (parseInt(s.charAt(index))) {
        index++;
        try {
            setTimeout(() => { }, 1000);
        } catch (e) { }
    }
    return s.charAt(index);
}

export default { toNumber, isNumeric, validSeparator };