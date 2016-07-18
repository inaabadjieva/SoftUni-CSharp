function multipleValuesPerKey(arr){
    let objects = {};
    for (let i = 0; i < arr.length - 1; i++) {
        let tokens = arr[i].split(' ');
        let key = tokens[0];
        let value = tokens[1];
        objects[key] = objects[key] || [];
        objects[key].push(value);
    }
    let keyWord = arr[arr.length - 1];
    if (objects[keyWord] == undefined)
        console.log("None");
    else{
        for(let value of objects[keyWord])
            console.log(value);
    }
}


