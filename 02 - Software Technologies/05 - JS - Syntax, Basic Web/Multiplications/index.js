function multiplyByTwo(arr){
    let num = Number(arr[0]);
    return num * 2;
}

function multiplyTwoNumbers(arr){
    let a = Number(arr[0]);
    let b = Number(arr[1]);
    return a * b;
}

function MultiplyOrDivideANumber(arr){
    let a = Number(arr[0]);
    let b = Number(arr[1]);
    if(a <= b){
        return a * b;
    }else{
        return a / b;
    }
}

function ProductOfThreeNumbers(arr){
    arr = arr
        .map(Number)
        .filter(x => x < 0);

    let negatives = arr
        .filter(x => x == 0);

    if(arr.length % 2 == 0
        || negatives.length
    ){
        return "Positive";
    }else{
        return "Negative";
    }
}

ProductOfThreeNumbers(['2', '3', '-1']);