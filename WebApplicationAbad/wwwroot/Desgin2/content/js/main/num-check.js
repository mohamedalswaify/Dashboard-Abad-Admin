
let button = document.getElementById("generate");

  button.onclick = function generate() {

  let randomNum = Math.floor((Math.random() * 9999) + 1000);

  let el = document.getElementById('ranNum');
  el.innerHTML = randomNum;
 }