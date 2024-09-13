$(document).ready(function () {
  var $blogPad = $(".blog-pad");
  var isSliderInitialized = false;

  function checkMobile() {
    return window.matchMedia("(max-width: 767px)").matches;
  }

  function initSlider() {
    if ($blogPad.length && !isSliderInitialized) {
      $blogPad.slick({
        infinite: true,
        centerMode: true,
        variableWidth: true,
        dots: true,
        speed: 500,
        cssEase: 'linear',
        useTransform: true,
        autoplaySpeed: 1000,
        arrows: true,
        rows: 1
      });
      isSliderInitialized = true;
    }
  }

  function destroySlider() {
    if ($blogPad.length && isSliderInitialized) {
      $blogPad.slick('unslick');
      isSliderInitialized = false;
    }
  }

  function updateSlider() {
    if (checkMobile()) {
      initSlider();
    } else {
      destroySlider();
    }
  }

  updateSlider();
  $(window).on('resize', function() {
    updateSlider();
  });
});



const vis = document.getElementById("navbarDropdown");
vis.addEventListener("click", myFunction);
function myFunction() {
  if (document.getElementById("collapseExample").style.display === "flex") {
    document.getElementById("collapseExample").style.display = "none";
  } else {
    document.getElementById("collapseExample").style.display = "flex";
  }
}
const fax = document.getElementById("myfix");
const lo = document.getElementById("logo");
const bart = document.getElementById("bar");
const formMobile=document.getElementById("formMobile");

window.addEventListener("scroll", function () {
  if (window.scrollY >= 700) {
    if (window.matchMedia("(max-width: 768px)").matches) {
      this.document.getElementById("mobile").style.display = "flex";
      bart.style.setProperty("display", "none", "important");
      fax.style.top = "60px";
      fax.style.zIndex = "1";
      fax.style.position = "fixed";
      formMobile.style.top="60px"
    } 
    else {
      fax.style.position = "fixed";
      document.getElementById("nav").style.marginRight = "230px";
      this.document.getElementById("naver").style.position = "fixed";
      this.document.getElementById("naver").style.top = "60px";
      this.document.getElementById("mobile").style.display = "none";
      this.document.getElementById("naver").style.boxShadow ="rgba(100, 100, 111, 0.2) 0px 7px 29px 0px";
      this.document.getElementById("naver").style.background = "white";
      this.document.getElementById("lnkel").classList.add("clisic");
      this.document.getElementById("link1").style.color = "#1b548a";
      this.document.getElementById("link2").style.color = "#1b548a";
      this.document.getElementById("link3").style.color = "#1b548a";
      this.document.getElementById("link4").style.color = "#1b548a";
      this.document.getElementById("link5").style.color = "#1b548a";
      this.document.getElementById("Path121").style.fill="#1b548a";
      fax.style.top = "0px";
      this.document.getElementById("navbarDropdown").style.color = "#1b548a";
      lo.style.display = "flex";
      lo.style.right = "130px";
      mod.style.overflow="auto";
      formMobil.style.display="none";
    }
  }

  if (window.scrollY < 700) {
    if (window.matchMedia("(max-width: 768px)").matches) {
      this.document.getElementById("mobile").style.display = "none";
      fax.style.position = "static";
      fax.style.top = "0";
      formMobile.style.top="70px"
      bart.style.setProperty("display", "block", "important");
    } else {
      fax.style.position = "static";
      document.getElementById("nav").style.marginRight = "0";
      this.document.getElementById("naver").style.position = "static";
      this.document.getElementById("naver").style.top = "0";
      this.document.getElementById("naver").style.boxShadow = "none";
      this.document.getElementById("naver").style.background = "#0e4069";
      this.document.getElementById("link1").style.color = "white";
      document.getElementById("collapseExample").style.display = "none";
      this.document.getElementById("lnkel").classList.remove("clisic");
      this.document.getElementById("link2").style.color = "white";
      this.document.getElementById("link3").style.color = "white";
      this.document.getElementById("link4").style.color = "white";
      this.document.getElementById("link5").style.color = "white";
      this.document.getElementById("Path121").style.fill="white";
      this.document.getElementById("navbarDropdown").style.color = "white";
      lo.style.display = "none";
      lo.style.right = "0";
      this.document.getElementById("mobile").style.display = "none";
      mod.style.overflow="auto";

      formMobil.style.display="none";
    }
  }
});

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


const later=document.getElementById("bar");
const formMobil=document.getElementById("formMobile");
const mob=document.getElementById("mob");
const mod=document.getElementById("mod");
mob.addEventListener("click",hideMobile);
later.addEventListener("click", hideMobile);
function hideMobile() {
  if (formMobil.style.display === "block") {
    formMobil.style.display = "none";
    mod.style.overflow="auto";
  } else {
    formMobil.style.display = "block";
    mod.style.overflow="hidden";
  }
  if (window.scrollY < 700) {
    if (window.matchMedia("(max-width: 377px) and (max-width: 480px)").matches) {
      formMobile.style.top="94px"
    }
  }
}

var counts = [0, 0, 0, 0];
var targets = [52, 323, 217, 322];
var counterElements = [
  document.getElementById("count1"),
  document.getElementById("count2"),
  document.getElementById("count3"),
  document.getElementById("count4"),
];

var intervalIds = [];

function startCounts() {
  for (var i = 0; i < counts.length; i++) {
    var intervalId = setInterval(incrementCount.bind(null, i), 1);
    intervalIds.push(intervalId);
  }
}

function stopCounts() {
  for (var i = 0; i < intervalIds.length; i++) {
    clearInterval(intervalIds[i]);
  }
  intervalIds = [];
}

function incrementCount(index) {
  counts[index]++;
  updateCount(index);

  if (counts[index] === targets[index]) {
    clearInterval(intervalIds[index]);
  }
}

function updateCount(index) {
  var paddedCount = String(counts[index]).padStart(5, "0");
  counterElements[index].textContent = paddedCount;
}

startCounts();

const attendance = document.getElementById("attendance");
const online = document.getElementById("online");
const alldata = document.getElementById("alldata");

const att = document.getElementById("att");
const on = document.getElementById("on");
const all = document.getElementById("all");

attendance.addEventListener("change", function () {
  if (attendance.checked) {
    att.style.display = "block";
    on.style.display = "none";
    all.style.display = "none";
  }
});
online.addEventListener("change", function () {
  if (online.checked) {
    att.style.display = "none";
    on.style.display = "block";
    all.style.display = "none";
  }
});
alldata.addEventListener("change", function () {
  if (alldata.checked) {
    att.style.display = "none";
    on.style.display = "none";
    all.style.display = "block";
  }
});



$(document).ready(function() {
  function checkMobile() {
    return window.matchMedia("(max-width: 767px)").matches;
  }
function initSlider() {
    $(".slider").slick({
      infinite: true,
      centerMode: true,
      variableWidth: true,
      dots: true,
      speed: 500,
      cssEase: 'linear',
      useTransform: true,
      autoplay: true,
      autoplaySpeed: 1000,
      arrows: true,
      rows: checkMobile() ? 2 : 1, 
    });
  }
  initSlider();
  $(window).on('resize', function() {
    $(".slider").slick('unslick');
    initSlider();
  });
});


	



