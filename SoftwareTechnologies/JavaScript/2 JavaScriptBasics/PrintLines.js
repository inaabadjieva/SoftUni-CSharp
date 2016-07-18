function printLines(arr){
    let input = arr[0];
    let index = 0;
    while(input !== 'Stop'){
        console.log(input);
        index++;
        input = arr[index];
    }
}
