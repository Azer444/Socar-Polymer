let swiper = new Swiper('.swiper-container', {
    autoplay: {
        delay: 2000,
        disableOnInteraction: false
    },
    loop: true,
    pagination: {
        el: '.swiper-pagination',
        clickable: true,
    },
    centeredSlides: true
});

let swiper_slide = document.querySelector('.swiper-container');

swiper_slide.addEventListener('mouseenter', () => {
    swiper.autoplay.stop()
})

swiper_slide.addEventListener('mouseleave', () => {
    swiper.autoplay.start()
})