function getPerson() {
   const personId = document.getElementById("personId").value; 
   const xhr = new XMLHttpRequest();
   xhr.onload = onload;
   xhr.open("GET", "persons/" + personId, true);
   xhr.setRequestHeader("Accept", "application/json");
   //xhr.setRequestHeader("Authorization", "Basic " + btoa("homer:homer"));
   xhr.send(null);
}

function onload() {
   const firstName = document.getElementById("firstName");
   const lastName = document.getElementById("lastName");
   const phone = document.getElementById("phone");
   const person = JSON.parse(this.responseText);
   firstName.innerText = person.firstName;
   lastName.innerText = person.lastName;
   phone.innerText = person.phone;
}

function init() {
   const button = document.getElementById("button");
   button.addEventListener("click", getPerson);
}

window.addEventListener("load", init);
