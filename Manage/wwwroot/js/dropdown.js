const filter_wrapper_btn = document.querySelectorAll('.filter-wrapper-btn'),
    filter_wrapper = document.querySelectorAll('.filter-wrapper'),
    filter_wrapper_btn_img = document.querySelectorAll('.filter-wrapper-btn img');

const toggleWrapper = (event, btn, index) => {
    event.preventDefault()
    
    filter_wrapper[index].classList.toggle('show')
    filter_wrapper_btn_img[index].classList.toggle('rotate')
}

filter_wrapper_btn.forEach((btn, index) => {
    btn.addEventListener('click', (event) => toggleWrapper(event, btn, index), false)
})
