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