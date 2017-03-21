function solve (arr) {
    let n = Number(arr[0]);
    let outputNumbers = [];
    for(let i = 1; i <= n; i++){
        let currentNumber = i;
        let reversedNumber = i
            .toString()
            .split('')
            .reverse()
            .join('');
        if(currentNumber == reversedNumber){
            outputNumbers.push(i);
        }
    }
    outputNumbers = outputNumbers.join(' ');
    console.log(outputNumbers);
}

solve(['750']);