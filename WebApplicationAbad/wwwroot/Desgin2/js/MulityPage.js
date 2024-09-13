
window.addEventListener('load', function () {
  initMap();
});

const vis = document.getElementById("navbarDropdown");
vis.addEventListener("click", myFun);
const coll = document.getElementById("collapseExample");

function myFun() {
  if (coll.style.display === "flex") {
    coll.style.display = "none";
  } else {
    coll.style.display = "flex";
  }
}


const mobile=document.getElementById("mob");
const formMobile=document.getElementById("formMobile")
var bodyElement = document.querySelector('body');

mobile.addEventListener("click", myFunction);
function myFunction() {
    if (formMobile.style.display === "block") {
        formMobile.style.display = "none";
        bodyElement.style.overflow="auto";
      } else {
        formMobile.style.display = "block";
        bodyElement.style.overflow="hidden";
      }
}
const controltab = document.getElementById("controltab");
const icome = document.getElementById("icome");
if (icome) {
  icome.addEventListener("click", function () {
    if (controltab.style.display === "flex") {
      controltab.style.display = "none";
    } else {
      controltab.style.display = "flex";
    }
  });
} else {
  
}

const Col = document.getElementById("Moli");
const munel = document.getElementById("munel");
const hied = document.getElementById("hied");


if (Col || munel) {
  Col.addEventListener("click", ShowMenu);
  hied.addEventListener("click", HiedMenue);
}

function ShowMenu() {
  munel.classList.add("soll-class");
} 
function HiedMenue() {
  munel.classList.remove("soll-class");
} 

const attendance = document.getElementById("attendance");
const online = document.getElementById("online");
const alldata = document.getElementById("alldata");

const att = document.getElementById("att");
const on = document.getElementById("on");
const all = document.getElementById("all");

if (attendance && att && on && all) {
  attendance.addEventListener("change", function () {
    if (attendance.checked) {
      att.style.display = "block";
      on.style.display = "none";
      all.style.display = "none";
    }
  });
} 
if (attendance && att && on && all) {
online.addEventListener("change", function () {
  if (online.checked) {
    att.style.display = "none";
    on.style.display = "block";
    all.style.display = "none";
  }
});
}

if (attendance && att && on && all) {
alldata.addEventListener("change", function () {
  if (alldata.checked) {
    att.style.display = "none";
    on.style.display = "none";
    all.style.display = "block";
  }
});
}


function initMap() {
  var myLatLng = { lat: 24.742697872662774, lng: 46.76559187495602}; 

  var map = new google.maps.Map(document.getElementById("map"), {
    center: myLatLng,
    zoom: 18
  });

  var marker = new google.maps.Marker({
    position: myLatLng,
    map: map,
    title: "Abad"
    });
}






function OpenTypeCourse(evt, cityName) {
  const coller = document.getElementById("coller");
  
  var i, tabcontent, tablinks;
  tabcontent = document.getElementsByClassName("tabcontent");
  for (i = 0; i < tabcontent.length; i++) {
    tabcontent[i].style.display = "none";
  }

  tablinks = document.getElementsByClassName("tablinks");
  for (i = 0; i < tablinks.length; i++) {
    tablinks[i].className = tablinks[i].className.replace(" active", "");
  }

  document.getElementById(cityName).style.display = "block";
  evt.currentTarget.className += " active";

  coller.textContent = evt.currentTarget.textContent;
}



