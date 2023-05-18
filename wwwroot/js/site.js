try {
    const toggleBtn = document.querySelector('[data-option="toggle"]')
    toggleBtn.addEventListener('click', function () {
        const element = document.querySelector(toggleBtn.getAttribute('data-target'))

        if (!element.classList.contains('open-menu')) {
            element.classList.add('open-menu')
            toggleBtn.classList.add('btn-outline-dark')
            toggleBtn.classList.add('btn-toggle-white')
        }

        else {
            element.classList.remove('open-menu')
            toggleBtn.classList.remove('btn-outline-dark')
            toggleBtn.classList.remove('btn-toggle-white')
        }
    })
} catch { }

function getFileName(e) {
    var fileName = e.target.files[0].name;
    document.getElementById('fileName').innerHTML = fileName;
}

function validateRequired(e) {
    validationfield = document.querySelector(`[data-valmsg-for="${e.target.id}"]`)

    if (e.target.value.length >= 1)
        validationfield.innerHTML = ""
    else
        validationfield.innerHTML = e.target.dataset.valRequired
}
