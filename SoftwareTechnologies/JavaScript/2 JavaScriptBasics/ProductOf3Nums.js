function product(arr){
    let nums = arr.map(Number);
    let count = 0;
    for(let num of nums)
        if(num < 0)
            count++;
    if(count % 2 === 0)
        console.log('Positive');
    else if(nums.indexOf(0) > -1)
        console.log('Positive');
    else
        console.log('Negative');
}