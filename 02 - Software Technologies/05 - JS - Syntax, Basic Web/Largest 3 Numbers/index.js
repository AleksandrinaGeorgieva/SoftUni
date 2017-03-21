/**
 * Created by Georgievi on 3/21/2017.
 */
function solve (arr) {
    arr = arr
        .map(Number)
        .sort(function(a,b){return b-a});

    let n = Math.min(3, arr.length);

    for(let i = 0; i < n; i++){
        console.log(arr[i]);
    }
}

solve([
    '10', '30', '15', '20', '50', '5'
]);
