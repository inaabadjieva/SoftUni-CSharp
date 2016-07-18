function keyValuePairs(arr) {
    let objects = [];
    let key;
    let value;
    for (let i = 0; i < arr.length - 1; i++) {
        let pair = arr[i].split(' ');
        key = pair[0];
        value = pair[1];
        objects[key] = value;
    }
    let keyWord = arr[arr.length - 1];
    if (objects[keyWord] == undefined)
        console.log("None");
    else
        console.log(objects[keyWord]);
}