// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    // Initialize Owl Carousel
    const nextIcon = '<img src="./images/icons/next.svg">'
    const prevIcon = '<img src="./images/icons/previous.svg">'
    $(".owl-carousel").owlCarousel({
        loop: true,
        items: 1,
        margin: 10,
        autoplay:true,
        nav: true,
        dots: false,
        autoplayHoverPause: true,
        navText: [
            prevIcon,
            nextIcon
        ]
    });

    //Detect window scroll and change navbar background color
    window.onscroll = () => {
        if (window.scrollY > 80) {
            $('.navbar').addClass('scroll-nav');
        } else {
            $('.navbar').removeClass('scroll-nav');
        }
    };
    
    // Accordion Controller
    var accordion = document.getElementsByClassName("accordion-title");
    var i;

    for (i = 0; i < accordion.length; i++) {
        accordion[i].addEventListener("click", function () {
            this.classList.toggle("active");
            // var panel = this.nextElementSibling;
            // if (panel.style.display === "flex") {
            //     panel.style.display = "none";
            // } else {
            //     panel.style.display = "flex";
            // }
            var panel = this.nextElementSibling;
            if (panel.style.maxHeight) {
                panel.style.maxHeight = null;
            } else {
                panel.style.maxHeight = panel.scrollHeight + "px";
            }
        });
    }
});

//NavBar FlyOur Menu
function openMenu() {
    let menu = document.getElementById("fly-out");
    // menu.style.position = "fixed";
    menu.style.width = "fit-content";
    menu.style.width = "-moz-fit-content";
    menu.style.padding = "20px 50px";
    menu.style.display = "block";
    document.getElementById("overlay").style.visibility = "visible";
}

function closeMenu() {
    let menu = document.getElementById("fly-out");
    menu.style.width = "0%";
    menu.style.padding = "0";
    // menu.style.display = "none";
    document.getElementById("overlay").style.visibility = "hidden";
}
