function StringifyJSON(arr){
    let data = {};
    for(let i = 0; i < arr.length; i++){
        let splitted = arr[i].split(' -> ');
        let value = splitted[1];
        if(!isNaN(value)){
            value = parseInt(value);
        }
        data[splitted[0]] = value;
    }
    return JSON.stringify(data);
}