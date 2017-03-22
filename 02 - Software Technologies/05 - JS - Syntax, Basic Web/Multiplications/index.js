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