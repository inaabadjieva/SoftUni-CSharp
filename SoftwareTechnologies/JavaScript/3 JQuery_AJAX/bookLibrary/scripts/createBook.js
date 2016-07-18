function createBook(){
    let data = {
        title:$('#title').val(),
        author: $('#author').val(),
        description:$('#description').val()
    };
    let request = {
        method:'POST',
        url:'https://baas.kinvey.com/appdata/kid_HywNhDcH/books',
        headers:{
            'Authorization':'Kinvey ' + sessionStorage.getItem('authToken'),
            'Content-Type':'application/json'
        },
        data:JSON.stringify(data)
    };
    $.ajax(request);
}
