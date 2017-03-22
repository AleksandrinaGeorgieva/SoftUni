function StoringObjects(arr){
    let data = [];

    for(let i = 0; i < arr.length; i++){
        let splitted = arr[i].split(' -> ');
        let name = splitted[0];
        let age = splitted[1];
        let grade = splitted[2];

        data.push({
            name: name,
            age: age,
            grade: grade
        });
    }

    for(let i = 0; i < data.length; i++){
        console.log("Name: " + data[i]["name"]);
        console.log("Age: " + data[i]["age"]);
        console.log("Grade: " + data[i]["grade"]);
    }
}