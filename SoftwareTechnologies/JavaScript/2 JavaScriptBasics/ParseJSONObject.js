function ParseJSONObject(arr){
    for(let i of arr){
        let obj = JSON.parse(i);
        for(let key in obj){
            console.log(`${toUppercase(key)}: ${obj[key]}`);
        }
    }
    function toUppercase(key){
        return key.charAt(0).toUpperCase() + key.substr(1);
    }
}
ParseJSONObject(['{"name":"Gosho","age":10,"date":"19/06/2005"}', '{"name":"Tosho","age":11,"date":"04/04/2005"}']);