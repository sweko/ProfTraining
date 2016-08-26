function repeatText(){
    var text = $("#text").val();
    var times = $("#times").val();
    
    var result = repeatTextImpl(text, times);

    $("#result").html(result);
}

function repeatTextImpl(text, times){
    var result = "";
    for (var index = 0; index < times; index++) {
        result += text +"<br/>";
    }
    return result;    
}

function changeSecond(){
    $($("#mylist li")[1]).text("Два");
}

function addItem(){
    $("#mylist").append("<li>Six</li>");
}

function getResult(){
    var listItems = $("#mylist li");
    var result = "";
    for (var index = 0; index < listItems.length; index++) {
        var listItem = listItems[index];
        var itemText =  $(listItem).text();
        var firstLetter = itemText[0];
        if (firstLetter !== "F"){
            result += itemText;
        }
    }
    $("#result").text(result);
}