const 
    left = document.getElementById("Left"),
    middle = document.getElementById("Middle"),
    right = document.getElementById("Right"),
    cat = document.getElementsByClassName("cat")[0],
    dog = document.getElementsByClassName("dog")[0],
    cat_img = document.getElementById("cat_photo"),
    dog_img = document.getElementById("dog_photo")

left.onclick = function() {
    cat.style.width = "95%"
    dog.style.width = "5%"

    cat_img.style.width = "60%"
    
    Show(cat_img)
    Hide(dog_img)
}

middle.onclick = function() {
    cat.style.width = "50%"
    dog.style.width = "50%"

    cat_img.style.width = "calc(100% - 40px)"
    dog_img.style.width = "calc(100% - 40px)"

    Show(cat_img)
    Show(dog_img)
}

right.onclick = function() {
    cat.style.width = "5%"
    dog.style.width = "95%"

    dog_img.style.width = "60%"

    Hide(cat_img)
    Show(dog_img)
}

function Hide(element) {
    element.style.display = "none"
}
function Show(element) {
    element.style.display = "block"
}