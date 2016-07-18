function showBooks(){
    let request = {
        method:'GET',
        url:'https://baas.kinvey.com/appdata/kid_HywNhDcH/books',
        headers:{
            'Authorization':'Kinvey ' + sessionStorage.getItem('authToken'),
            'Content-Type':'application/json'
        }
    };
    $.ajax(request).then(function(response){
        for(let obj of response){
            let innerList = document.createElement('ul');
            let title = document.createElement('li');
            let author = document.createElement('li');
            let description = document.createElement('li');
            author.className = 'author-style';

            let orderedListItem = document.createElement('li');

            title.appendChild(document.createTextNode(obj.title));
            author.appendChild(document.createTextNode(obj.author));
            description.appendChild(document.createTextNode(obj.description));

            innerList.appendChild(title);
            innerList.appendChild(author);
            innerList.appendChild(description);

            orderedListItem.appendChild(innerList);
            $('#booksList').append(orderedListItem);
        }
    });
}
