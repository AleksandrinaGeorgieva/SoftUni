function AddRemoveElements(arr){
    let data = [];
    for(let i = 0; i < arr.length; i++){
        let splitted = arr[i]
            .split(' ');
        let num = Number(splitted[1]);
        switch(splitted[0]){
            case "add":
                data.push(num);
                break;
            case "remove":
                if(typeof data[num] !== 'undefined')
                    data.splice(num, 1);
                break;
        }
    }

    for(let i = 0; i < data.length; i++){
        console.log(data[i]);
    }
}