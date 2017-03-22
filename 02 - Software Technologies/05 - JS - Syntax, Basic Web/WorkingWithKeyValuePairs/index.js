function ObjectData(arr){
    let data = {};
    for(let i = 0; i < arr.length - 1; i++){
        let splitted = arr[i]
            .split(' ');
        data[splitted[0]] = splitted[1];
    }

    let last = arr[arr.length - 1];
    if(data[last]){
        console.log(data[last]);
    }else{
        console.log("None");
    }
}

/*
* You will be given input lines, each holding two
* elements separated by a space: key and value.
* You need to store the given values to the given keys.
* At the last line of the input you will receive a key.
* You must print all the values corresponding to that key.
* If there are no such, just print “None”.
* */

function ObjectDataMultipleValues(arr){
    let data = {};
    for(let i = 0; i < arr.length - 1; i++){
        let splitted = arr[i]
            .split(' ');
        if(!data[splitted[0]]){
            data[splitted[0]] = [];
        }
        data[splitted[0]].push(splitted[1]);
    }

    let last = arr[arr.length - 1];
    if(data[last]){
        for(let i = 0; i < data[last].length; i++){
            console.log(data[last][i]);
        }
    }else{
        console.log("None");
    }
}