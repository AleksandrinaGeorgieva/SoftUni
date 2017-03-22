function PrintFromOneToN(arr){
    let n = Number(arr[0]);

    for(let i = 1; i <= n; i++){
        console.log(i);
    }
}

function PrintFromNToOne(arr){
    let n = Number(arr[0]);

    for(let i = n; i > 0; i--){
        console.log(i);
    }
}

function printLines(arr){
    for(let i = 0; i < arr.length; i++){
        if(arr[i] == "Stop"){
            return;
        }
        console.log(arr[i]);
    }
}

function printNumbersInReversedOrder(arr){
    for(let i = arr.length - 1; i >= 0; i--){
        console.log(arr[i]);
    }
}

/* set values to indexes in an array */
function fillArray(arr){
    let n = Number(arr[0]);
    let numbers = new Array(n)
        .fill(0);
    for(let i = 1; i < arr.length; i++){
        let splitted = arr[i]
            .split(' - ')
            .map(Number);
        numbers[splitted[0]] = splitted[1];
    }
    for(let i = 0; i < n; i++){
        console.log(numbers[i]);
    }
}