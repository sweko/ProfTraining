function doSearch(){
    var name = $("#name").val();
    var url = "http://www.omdbapi.com/?t=" + name + "&y=&plot=short&r=json";
    //var url = `http://www.omdbapi.com/?t=${name}&y=&plot=short&r=json`;
    
    $.ajax(url).done(
        function(data){
            console.log("found");
            $("#plot").text(data.Plot);
            $("#title").text(data.Title);
        }
    );

    console.log("searching");
    $("#plot").text("searching ....");
    $("#title").text("");
}