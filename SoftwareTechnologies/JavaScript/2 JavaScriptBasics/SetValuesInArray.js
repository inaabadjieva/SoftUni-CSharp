function setValuesToArray(arr){
    let n = Number(arr[0]);
    let array = new Array(n).fill(0);
    let input = arr[1];
    let pos = 1;
    while(input){
        let index = Number(input[0]);
        let value = input.slice(input.indexOf('-') + 2);
        array[index] = value;
        pos++;
        input = arr[pos];
    }
    for(let i in array)
        console.log(array[i]);
}
