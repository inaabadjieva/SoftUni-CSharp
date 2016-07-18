function storingObjects(arr){
    let student = {};
    for(let elements of arr){
        let tokens = elements.split(' -> ');
        student.Name = tokens[0];
        student.Age = tokens[1];
        student.Grade = tokens[2];
        for(let s in student){
            console.log(`${s}: ${student[s]}`);
        }
    }
}
storingObjects(['Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57', 'Toni -> 13 -> 4.90']);