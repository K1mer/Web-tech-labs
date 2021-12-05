let LightOn = false, AnimalInHat = true, RabbitNext = true

Curtain.onclick = function() {
    this.style.transform = "translate(-50%, -150%)"
    this.style.transition = "transform 1s linear"
}

Lamp.childNodes.forEach(element => {
    if (element != Light) {
        element.onmousedown = function() {
            L2.style.transform = "translate(0, 15px)"
            L3.style.transform = "translate(0, 15px)"
        }

        element.onmouseup = function() {
            L2.style.transform = "translate(0, 0px)"
            L3.style.transform = "translate(0, 0px)"
            
            if (LightOn) {
                Light.style.opacity = 0
                PerformanceElem.style.opacity = 0
                LightOn = false
            }
            else
            {
                Light.style.opacity = 0.45
                PerformanceElem.style.opacity = 1
                LightOn = true
            }
        }
    }
});

Hat.onclick = function() {
    if (AnimalInHat) {
        if (RabbitNext) {
            Rabbit.style.transform = "translate(0, -150%)"
        }
        else
        {
            Bird.style.transform = "translate(0, -150%)"
        }
        AnimalInHat = false
    }
}

Rabbit.onclick = function() {
    this.style.transform = "translate(0, 0)"
    AnimalInHat = true
    RabbitNext = false
}

Bird.onclick = function() {
    this.style.transform = "translate(0, 0)"
    AnimalInHat = true
    RabbitNext = true
}