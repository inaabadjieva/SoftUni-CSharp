function addCountryToTable(country, capital){
    let row = $('<tr>')
        .append($('<td>').text(country))
        .append($('<td>').text(capital))
        .append($('<td>')
            .append($('<a href="#" onclick="moveRowUp(this)">[Up]</a>'))
            .append(' ')
            .append($('<a href="#" onclick="moveRowDown(this)">[Down]</a>'))
            .append(' ')
            .append($('<a href="#" onclick="deleteRow(this)">[Delete]</a>'))
        );
    $('#countriesTable').append(row);
    return row;
}
$(function(){
    addCountryToTable('Bulgaria', 'Sofia');
    addCountryToTable('Germany', 'Berlin');
    addCountryToTable('Russia', 'Moscow');
    addCountryToTable('France', 'Paris');
    addCountryToTable('Turkey', 'Ankara');
    fixRowLinks()
});
function addCountry(){
    let country = $('#newCountryText').val();
    let capital = $('#newCapitalText').val();
    let row = addCountryToTable(country, capital);
    row.hide();
    row.fadeIn();
    $('#newCountryText').val('');
    $('#newCapitalText').val('');
    fixRowLinks()
}
function deleteRow(link){
    let row = $(link).parent().parent();
    row.fadeOut(function(){
        row.remove();
        fixRowLinks()
    })
}
function moveRowUp(link){
    let row = $(link).parent().parent();
    row.fadeOut(function(){
        row.insertBefore(row.prev());
        row.fadeIn();
        fixRowLinks();
    })
}
function moveRowDown(link){
    let row = $(link).parent().parent();
    row.fadeOut(function(){
        row.insertAfter(row.next());
        row.fadeIn();
        fixRowLinks();
    })
}
function fixRowLinks(){
    $('#countriesTable').show();
    let tableRows = $('#countriesTable tr');
    for(var i =1; i < tableRows.length; i++){
        if(i==1){
            $(tableRows[i]).find('a:contains("Up")').hide();
            $(tableRows[i]).find('a:contains("Down")').show();
        }
        else if (i == tableRows.length-1){
            $(tableRows[i]).find('a:contains("Up")').show();
            $(tableRows[i]).find('a:contains("Down")').hide();
        }
        else{
            $(tableRows[i]).find('a:contains("Up")').show();
            $(tableRows[i]).find('a:contains("Down")').show();
        }
    }
}
