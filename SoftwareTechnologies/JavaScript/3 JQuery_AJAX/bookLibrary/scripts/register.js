function register(){
    let data = {
        username: $('#username').val(),
        password: $('#password').val()
    };
    let appKey = 'kid_HywNhDcH';
    let appSecret = '66156b06cd794c63a081a292d65dd2b0';
    let request = {
        method:'POST',
        url:'https://baas.kinvey.com/user/kid_HywNhDcH/',
        headers:{
            'Authorization':'Basic ' + btoa(appKey + ':' + appSecret),
            'Content-Type':'application/json'
        },
        data:JSON.stringify(data)
    };
    $.ajax(request);
}
