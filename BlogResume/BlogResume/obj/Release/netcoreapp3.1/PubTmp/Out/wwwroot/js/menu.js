/*Sticky menu*/
window.onscroll = function () {
  fixedOnScroll();
  backTopAnimated();
};

var nav_header = document.getElementById("nav");
var whereToActive = document.getElementById("main");
var sticky = whereToActive.offsetTop;

function fixedOnScroll() {
  if (window.pageYOffset > sticky) {
    nav_header.classList.add("sticky");
  } else {
    nav_header.classList.remove("sticky");
  }
}


var backTopButton = document.getElementById('back-top-button');
backTopButton.addEventListener('click', function(){
  window.scroll({
    top:0,
    behavior: "smooth"
  })
})

function backTopAnimated(){
  if (window.pageYOffset > sticky) {
    backTopButton.classList.add("animated");
  } else {
    backTopButton.classList.remove("animated");
  }
}
/*End*/

/*Toggle menu*/
const toggleButton = document.getElementById("toggle-button");
toggleButton.addEventListener("click", function () {
  menuToggle();
});

function menuToggle() {
  var x = document.getElementById("sticky-nav");
  if (x.className === "sticky-nav") {
    x.className += " responsive";
  } else {
    x.className = "sticky-nav";
  }
}
/*End*/
