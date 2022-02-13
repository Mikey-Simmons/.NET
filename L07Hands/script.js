function regexChecker() {
    let firstName = document.getElementById('First').value;
    let lastName = document.getElementById('Last').value;
    let nameRegex = /^[a-zA-Z]/;

    if (firstName.match && firstName.match){
    alert ("Yay! Your inputs were all correct!");
    console.log(true);
    }
    else{
        alert ("Input invalid");
        console.log(false)
    }
    
     

   
    
    
}