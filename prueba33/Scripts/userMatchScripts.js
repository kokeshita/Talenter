

function openNav() {
    document.getElementById("mySideBar").style.width = "250px";
    document.getElementById("btnOpen").style.display = "none";
    document.getElementById("btnClose").style.display = "block";


}

function closeNav() {
    document.getElementById("mySideBar").style.width = "0px";
    document.getElementById("btnOpen").style.display = "block";
    document.getElementById("btnClose").style.display = "none";

}