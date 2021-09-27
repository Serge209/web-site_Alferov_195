$(document).ready(function(){
    $("a").click(function(){
        const _href = $(this).attr("href");
        $("html, body").animate({scrollTop: $(_href).offset().top+"px"});
        return false;
    });
});


const hamburger = document.querySelector('.hamburger'),
menu = document.querySelector('.mobile'),
closeElem = document.querySelector('.mobile__close');

hamburger.addEventListener('click', () => {
menu.classList.add('active');
});

closeElem.addEventListener('click', () => {
menu.classList.remove('active');
});

