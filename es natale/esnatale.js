"use strict";
exports.__esModule = true;
var readline_sync_1 = require("readline-sync");
function main() {
    var arrfinale = new Array;
    var arrbase = new Array;
    var n = (0, readline_sync_1.question)("Quanti numeri vuoi inserire? ");
    for (var i = 0; i < n; i++) {
        var numbers = (0, readline_sync_1.question)(i + '°' + " numero ");
        arrbase[i] = numbers;
    }
    for (var i_1 = 0; i_1 < arrbase.length; i_1++) {
        for (var j = 0; j < arrbase.length - i_1 - 1; j++) {
            if (arrbase[j] > arrbase[j + 1]) {
                arrfinale[i_1] = arrbase[j];
            }
        }
    }
    console.log(arrfinale);
}
main();
