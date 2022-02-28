const 
input = document.getElementsByName("amount")[0],
buttonSquare = document.getElementById("Square"),
buttonTriangle = document.getElementById("Triangle"),
buttonCircle = document.getElementById("Circle"),
drawPanel = document.getElementsByClassName("DrawPanel")[0]

buttonSquare.onclick = function() { CreateShapes("Square") }
buttonTriangle.onclick = function() { CreateShapes("Triangle") }
buttonCircle.onclick = function() { CreateShapes("Circle") }

let CurrentShape

function CreateShapes(shape)
{
    let amount = parseInt(input.value)
    for (let index = 0; index < amount; index++) {
        let s = document.createElement("div")

        s.setAttribute("class", shape)

        s.style.left = Rand(0, drawPanel.offsetWidth) + "px"
        s.style.top = Rand(0, drawPanel.offsetHeight) + "px"

        s.style.setProperty("--sizeMult", Rand(1, 50)) 

        s.onclick = function() {
            if (this == CurrentShape) {
                this.remove()
            }
            else {
                if (CurrentShape) {
                    CurrentShape.classList.remove("Chosen")
                }

                this.classList.add("Chosen")
                CurrentShape = this
            }
        }

        drawPanel.appendChild(s)
    }
}

function Rand(min, max) {
    return Math.random() * (max - min) + min;
}