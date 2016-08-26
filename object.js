function displayObjectProperties(){
    var weko = {
        firstName: "Wekoslav",
        lastName : "Stefanovski",
        age : 0x27,
        getFullName: function(){
            return this.firstName + " " + this.lastName;
        }
    };

    console.log(weko.firstName);
    console.log(weko.lastName.toUpperCase());
    console.log(weko.getFullName());

    weko.getInitials = function(){
        return this.firstName[0].toUpperCase()+
            this.lastName[0].toUpperCase();
    };

    console.log(weko.getInitials());
}