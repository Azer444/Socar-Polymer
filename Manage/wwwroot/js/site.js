const texts = document.querySelectorAll('.socar-card-info')
const info_text = document.querySelectorAll('.news-card-body-info');
const info = document.querySelectorAll('.news-card-info')
const form = document.querySelector('#sticky-form');
const dropdown = document.querySelector('.nav-dropdown-menu');
const flexible = document.querySelector('.flexible')
const rigid_packaging = document.querySelector('.rigid_packaging');
const btn_open_search = document.querySelector('.btn-search');
const btn_close_search = document.querySelector('.btn-close-search');
const nav_search = document.querySelector('.nav-search');
const main_nav = document.querySelector('.main-nav');
const header = document.querySelector('.header');
const slice_text = document.querySelectorAll('.slice-text')
const footer = document.getElementsByClassName('footer')[0]

const navbar_brand = document.getElementById('navbar-brand')
const right_side = document.getElementById('right-side')
const hamburger = document.getElementsByClassName('hamburger')[0]
const dropdown_language = document.getElementsByClassName('dropdown-language')[0]
const search_btn_form = document.getElementById('search-btn-form')

let breakpoint = {
    tablet: 768,
    desktop: 1024
}

window.onload = () => {
    if (window !== undefined) {
        if (texts) {
            texts.forEach(text => {
                text.innerHTML = truncateString(text.innerHTML, 180)
            })
        } else if (info_text) {
            info_text.forEach(text => {
                text.innerHTML = truncateString(text.innerHTML, 170)
            })
        } else if (info) {
            info.forEach(text => {
                text.innerHTML = truncateString(text.innerHTML, 150)
            })
        } else if (form) {
            setSticky()
        } if (slice_text) {
            slice_text.forEach(text => {
                text.innerHTML = truncateString(text.innerHTML, 120)
            })
        }
    }
}

window.addEventListener("scroll", () => {
    if (form) {
        setSticky()
    }
})

function truncateString(text, length) {
    if (text.length > length) {
        return text.slice(0, length) + '...'
    } else {
        return text
    }
}


flexible.addEventListener('mouseenter', () => {
    dropdown.style.minHeight = '476px'
})
flexible.addEventListener('mouseleave', () => {
    dropdown.style.minHeight = 'auto'
})


rigid_packaging.addEventListener('mouseenter', () => {
    dropdown.style.minHeight = '630px'
})
rigid_packaging.addEventListener('mouseleave', () => {
    dropdown.style.minHeight = 'auto'
})

btn_open_search.addEventListener('click', (e) => {
    e.preventDefault();

    if (window.innerWidth > breakpoint.tablet) {
        main_nav.classList.add('hidden')
        nav_search.classList.remove('hidden');
        btn_open_search.classList.add('hidden')
    } else {
        navbar_brand.style.display = 'none'
        nav_search.classList.remove('hidden');
        btn_open_search.classList.add('hidden')
        right_side.style.display = 'none'
    }
})

btn_close_search.addEventListener('click', (e) => {
    e.preventDefault();

    if (window.innerWidth > breakpoint.tablet) {
        main_nav.classList.remove('hidden')
        nav_search.classList.add('hidden');
        btn_open_search.classList.remove('hidden')
    } else {
        navbar_brand.style.display = 'flex'
        nav_search.classList.add('hidden');
        btn_open_search.classList.remove('hidden')
        right_side.style.display = 'block'
    }

})

const footerVisible = (entries) => {
    const footerVisible = entries[0].isIntersecting
    if (footerVisible) {
        header.classList.add('static')
    } else {
        header.classList.remove('static')
    }
}

const options = {
    root: null,
    rootMargin: "0px",
    threshhold: 0,
}

const oberveFooter = new IntersectionObserver(footerVisible, options)
oberveFooter.observe(footer)

// Responsive Navbar

const handleClick = () => {
    hamburger.classList.toggle('rotate')
    search_btn_form.classList.toggle('hide')
    dropdown_language.classList.toggle('show_')
}

hamburger.addEventListener('click', handleClick, false)

window.addEventListener('resize', () => {
    if (window.innerWidth > breakpoint.tablet) {
        main_nav.classList.remove('hidden')
        nav_search.classList.add('hidden');
        btn_open_search.classList.remove('hidden')
        search_btn_form.classList.remove('hide')
        right_side.style.display = 'block'
        navbar_brand.style.display = 'block'
        // hamburger.classList.remove('rotate')

    } else {
        dropdown_language.classList.remove('show_')
        // hamburger.classList.remove('rotate')
        search_btn_form.classList.remove('hide')
    }
})

$(function () {
    // $('.responsive-navbar').css('display', 'none')
    $('.hamburger').on('click', function () {
        if ($(this).hasClass('rotate')) {
            $('.responsive-navbar').fadeIn()
            $('.header').css('position', 'fixed')
            $('body').css('overflow-y', 'hidden')
        } else {
            $('.responsive-navbar').fadeOut()
            $('.header').css('position', 'sticky')
            $('body').css('overflow-y', 'auto')
        }
    })

    $.each($('.btn-navbar'), function (index) {
        $(this).on('click', function () {
            if ($('.responsive-navbar-sidebar').eq(index).data('target') === $(this).attr('id')) {
                $('.responsive-navbar-sidebar').eq(index).fadeIn()
                $('.responsive-navbar-wrapper').fadeOut()
            }
        })
    })

    $.each($('.go-back'), function (index) {
        $(this).on('click', function () {
            $('.responsive-navbar-sidebar').eq(index).fadeOut()
            $('.responsive-navbar-wrapper').fadeIn()
        })
    })
})



// Responsive Navbar