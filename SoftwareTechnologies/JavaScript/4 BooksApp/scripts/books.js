const kinveyBaseUrl = "https://baas.kinvey.com/";
const kinveyAppKey = "kid_rJnRs5y8";
const kinveyAppSecret = "c3b9b8354ff34618b69faa3e551757a6";

function showView (viewName) {
    $('main > section').hide();
    $('#' + viewName).show();
}

function showHideMenuLinks() {
    $('#linkHome').show();
    if(sessionStorage.getItem('authToken') == null) {
        $('#linkLogin').show();
        $('#linkRegister').show();
        $('#linkListBooks').hide();
        $('#linkCreateBook').hide();
        $('#linkLogout').hide();
    } else {
        $('#linkLogin').hide();
        $('#linkRegister').hide();
        $('#linkListBooks').show();
        $('#linkCreateBook').show();
        $('#linkLogout').show();
    }
}

function showInfo(message) {
    $('#infoBox').text(message).show();
    setTimeout(function() { $('#infoBox').fadeOut()}, 3000);
}

function showError(errorMsg) {
    $('#errorBox').text('Error: ' + errorMsg).show();
}

function showHomeView() {
    showView('viewHome');
}

function showLoginView() {
    showView('viewLogin');
}

function login() {
    $.ajax({
        method: 'POST',
        url: kinveyBaseUrl + 'user/' + kinveyAppKey + '/login',
        headers: {
            Authorization: 'Basic ' + btoa(kinveyAppKey + ":" + kinveyAppSecret)
        },
        data: {
            username: $('#loginUser').val(),
            password: $('#loginPass').val()
        },
        success: loginSuccess,
        error: handleAjaxError
    });
    function loginSuccess(response) {
        let userAuth = response._kmd.authtoken;
        sessionStorage.setItem('authToken', userAuth);
        showHideMenuLinks();
        listBooks();
        showInfo('Login successful.');
    }
}

function handleAjaxError(response) {
    let errorMsg = JSON.stringify(response);
    if(response.readyState === 0)
        errorMsg = 'Cannot connect due to network error.';
    if(response.responseJSON && response.responseJSON.description)
        errorMsg = response.responseJSON.description;
    showError(errorMsg);
}

function showRegisterView() {
    showView('viewRegister')
}

function register() {
    $.ajax({
        method: 'POST',
        url: kinveyBaseUrl + 'user/' + kinveyAppKey + '/',
        headers: {
            Authorization: 'Basic ' + btoa(kinveyAppKey + ":" + kinveyAppSecret)
        },
        data: {
            username: $('#registerUser').val(),
            password: $('#registerPass').val()
        },
        success: registerSuccess,
        error: handleAjaxError
    });
    function registerSuccess(response) {
        let userAuth = response._kmd.authtoken;
        sessionStorage.setItem('authToken', userAuth);
        showHideMenuLinks();
        listBooks();
        showInfo('User registration successful.');
    }
}

function showListBooksView() {
    showView('viewBooks');
    listBooks();
}

function listBooks() {
    $('#books').empty();
    showView('viewBooks');

    $.ajax({
        method: 'GET',
        url: kinveyBaseUrl + 'appdata/' + kinveyAppKey + '/books',
        headers: {
            'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')
        },
        success: loadBooksSuccess,
        error: handleAjaxError
    });

    function loadBooksSuccess(books) {
        showInfo('Books loaded.');

        if (books.length === 0) {
            $('#books').text('No books in library.');
        } else {
            let bookTable = $('<table>')
                .append('<tr>')
                .append('<th>Title</th>',
                        '<th>Author</th>',
                        '<th>Description</th>');

            for (let book of books) {
                bookTable.append($('<tr>').append(
                    $('<td>').text(book.title),
                    $('<td>').text(book.author),
                    $('<td>').text(book.description))
                );

                let commentsRow = $('<tr id="commentRow">').attr('data-question', JSON.stringify(book));
                let commentsSection = $('<td colspan="3">');

                if (book.comments != undefined) {
                    for (let comment of book.comments) {
                        commentsSection.append(
                            $('<div id="bookCommentsText">').text(comment.text),
                            $('<div id="bookCommentsAuthor">').text('     --' + ' ' + comment.author),
                            $('<br>')
                        );
                    }
                    commentsRow.append(commentsSection);
                }

                commentsSection.append(
                    $('<div id="divAddComment"></div>')
                        .append($('<a href="#" id="linkAddComment">Add Comment</a>')
                            .click(function () {
                                $(this).hide();
                                $(this).closest('tr').find('#formComment').show();
                            })));

                commentsSection.append(
                    $('<form style="display: none" id="formComment">')
                    .append($('<span>Comment: </span>'))
                    .append($('<input type="text" id="textComment" required>'))
                    .append($('<span>Author: </span>'))
                    .append($('<input type="text" id="textCommentAuthor" required>'))
                    .append($('<input type="submit" id="addComment" value="Add comment">'))
                    .append($('<input type="reset" id="cancel" value="Cancel">'))
                    .on('submit', function (e) {
                        let bookData = JSON.parse($(this).closest('tr').attr('data-question'));
                        let commentText = $(this).find('#textComment').val();
                        let commentAuthor = $(this).find('#textCommentAuthor').val();

                        $(this).find('#textComment').val('');
                        $(this).find('#textCommentAuthor').val('');

                        e.preventDefault();

                        addBookComment(bookData, commentText, commentAuthor);

                        $(this).hide();
                        $(this).closest('tr').find('#linkAddComment').show()
                    })
                    .on('reset', function (e) {
                        $(this).hide();
                        $(this).closest('tr').find('#linkAddComment').show()
                    }));

                commentsRow.append(commentsSection);
                bookTable.append(commentsRow);
            }
            $('#books').append(bookTable);
        }
    }
}

function addBookComment(book, commentText, commentAuthor) {
    if (!book.comments) {
        book.comments = [];
    }

    book.comments.push({text: commentText, author: commentAuthor});

    $.ajax({
        method: 'PUT',
        url: kinveyBaseUrl + 'appdata/' + kinveyAppKey + '/books/' + book._id,
        headers: {
            Authorization: "Kinvey " + sessionStorage.getItem('authToken'),
            'Content-type': 'application/json'
        },
        data: JSON.stringify(book),
        success: addBookCommentSuccess,
        error: handleAjaxError
    });

    function addBookCommentSuccess() {
        listBooks();
        showInfo('Book comment added.');
    }
}

function showCreateBookView() {
    showView('viewCreateBook')
}

function createBook() {
    $.ajax({
        method: 'POST',
        url: kinveyBaseUrl + 'appdata/' + kinveyAppKey + '/books',
        headers: {
            'Authorization': 'Kinvey ' + sessionStorage.getItem('authToken')
        },
        data: {
            title: $('#bookTitle').val(),
            author: $('#bookAuthor').val(),
            description: $('#bookDescription').val(),
            comments: []
        },
        success: createBookSuccess,
        error: handleAjaxError
    });
    function createBookSuccess(response){
        showListBooksView();
        showInfo('Book created');
        $('#formCreateBook')[0].reset();
    }
}

function logout(){
    alert('logout');
    sessionStorage.clear();
    showHideMenuLinks();
    showHomeView();
}

$(function () {
    showHideMenuLinks();
    showHomeView();
});

$(function () {
    $('#linkHome').click(showHomeView);
    $('#linkLogin').click(showLoginView);
    $('#linkRegister').click(showRegisterView);
    $('#linkListBooks').click(listBooks);
    $('#linkCreateBook').click(showCreateBookView);
    $('#linkLogout').click(logout);
});

$(function () {
    $('#formLogin').submit(function (e) {
        e.preventDefault(); login();
    });
    $('#formRegister').submit(function (e) {
        e.preventDefault(); register();
    });
    $('#formCreateBook').submit(function (e) {
        e.preventDefault(); createBook();
    });
});

$(document).on({
    ajaxStart: function(){ $('#loadingBox').show()},
    ajaxStop: function () { $('#loadingBox').hide()}
});









