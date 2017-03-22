function PrintFromOneToN(arr){
    let n = Number(arr[0]);

    for(let i = 1; i <= n; i++){
        console.log(i);
    }
}

function PrintFromNToOne(arr){
    let n = Number(arr[0]);

    for(let i = n; i > 0; i--){
        console.log(i);
    }
}