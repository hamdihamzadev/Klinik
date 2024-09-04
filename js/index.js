let links = document.querySelectorAll('.nav-link')

links.forEach(link => {
    link.addEventListener('click', () => {
        document.querySelector('.activelink').classList.remove('activelink')
        link.classList.add('activelink')
    })
})

