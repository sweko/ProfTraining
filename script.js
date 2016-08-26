function repeatText(){
    var text = document.getElementById("text").value;
    var times = document.getElementById("times").valueAsNumber;
    
    var result = repeatTextImpl(text, times);

    document.getElementById("result").innerHTML = result;
}


function repeatTextImpl(text, times){
    var result = "";
    for (var index = 0; index < times; index++) {
        result += text +"<br/>";
    }
    return result;    
}


// var count = prompt("Times to repeat");
// var text = prompt("Text to repeat");

// for (var index = 0; index < count; index++) {
//     document.write(text);
//     document.write("<br/>");
// }
