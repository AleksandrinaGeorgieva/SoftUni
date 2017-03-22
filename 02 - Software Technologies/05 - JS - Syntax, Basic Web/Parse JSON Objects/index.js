function ParseJSON(arr){
    let data = [];

    for(let i = 0; i < arr.length; i++){
        let student = JSON.parse(arr[i]);
        data.push(student);
    }

    for(let i = 0; i < data.length; i++){
        console.log("Name: " + data[i]["name"]);
        console.log("Age: " + data[i]["age"]);
        console.log("Date: " + data[i]["date"]);
    }
}