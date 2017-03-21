/**
 * Created by Georgievi on 3/21/2017.
 */
function solve (arr) {
    let obj = {},
        sorted;

    for(let i = 0; i < arr.length; i++){
        let data = JSON.parse(arr[i]),
            income;
        if(typeof obj[data.town] === 'undefined'){
            obj[data.town] = 0;
        }
        income = Number(data.income);
        obj[data.town] += income;
    }

    sorted = Object.keys(obj).sort();
    for(let town of sorted){
        console.log(town + " -> " + obj[town]);
    }
}

solve([
    '{"town":"Sofia","income":200}',
    '{"town":"Varna","income":120}',
    '{"town":"Pleven","income":60}',
    '{"town":"Varna","income":70}'
]);
