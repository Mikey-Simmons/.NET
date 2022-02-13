const einstein =  new XMLHttpRequest ();
einstein.onreadystatechange = function(){
if(this.readyState== 4 && this.status ==200){
let myobj= JSON.parse(this.responseText);

document.getElementById("name").innerHTML = myobj.name;
document.getElementById("bday").innerHTML = myobj.bday;
document.getElementById("button").addEventListener("click", function(){
document.getElementById ("fullBio").innerHTML = myobj.bio;

   
});
}
}

 einstein.open("Get","einstein.json",true);
 einstein.send();
