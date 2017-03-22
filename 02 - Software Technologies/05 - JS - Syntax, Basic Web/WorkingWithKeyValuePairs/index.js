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