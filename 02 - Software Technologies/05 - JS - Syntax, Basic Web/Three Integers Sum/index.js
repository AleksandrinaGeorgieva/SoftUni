function solve (arr) {

    function checkSum(a, b, c){
        if(a + b !== c){
            return false;
        }
        let result = [Math.min(a, b), '+', Math.max(a, b), '=', c];
        return result.join(' ');
    }

    arr = arr[0]
        .split(' ')
        .map(Number);

    let output = checkSum(arr[0], arr[1], arr[2])
        || checkSum(arr[1], arr[2], arr[0])
        || checkSum(arr[0], arr[2], arr[1])
        ||"No";
    console.log(output);
}

solve(['3 8 12']);
solve(['8 15 7']);
solve(['-5 -3 -2']);