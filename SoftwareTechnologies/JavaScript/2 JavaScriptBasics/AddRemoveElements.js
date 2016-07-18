function addRemoveElem(arr){
    let pos = 0;
    let input = arr[pos];
    let array = [];
    while(input){
        let tokens = input.split(' ');
        let command = tokens[0];
        if(command === 'add'){
            let num = tokens[1];
            array.push(num);
        }
        else{
            let index = tokens[1];
            if (index > -1 && index < array.length) {
                array.splice(index, 1);
            }
        }
        pos++;
        input = arr[pos];
    }
    for(let i of array)
    console.log(i);
}
