function sayHello() {
   const xhr = new XMLHttpRequest();
   xhr.onload = onload;
   xhr.open("GET", "hello", true);
   xhr.setRequestHeader("Accept", "text/plain");
   xhr.setRequestHeader("Authorization", "Basic " + btoa("homer:password"));
   xhr.send(null);
}

function onload() {
   const response = document.getElementById("response");
   response.innerText = this.responseText;   
}

function init() {
   const button = document.getElementById("button");
   button.addEventListener("click", sayHello);
}

window.addEventListener("load", init);
