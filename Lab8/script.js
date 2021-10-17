const 
buttonAdd = document.getElementById("AddElement"),
buttonSave = document.getElementById("Save"),
divOutput = document.getElementsByClassName("Output")[0],
divPlaceholder = document.getElementsByClassName("ElementsField")[0]

buttonAdd.onclick = function() {
    let row = document.createElement("div")

    row.input1 = document.createElement("input")
    row.input2 = document.createElement("input")
    row.up = document.createElement("button")
    row.down = document.createElement("button")
    row.delete = document.createElement("button")

    row.up.innerText = "↑"
    row.down.innerText = "↓"
    row.delete.innerText = "✗"

    row.up.onclick = function() {
        let prev = row.previousElementSibling

        if (prev) divPlaceholder.insertBefore(row, prev)
    }
    row.down.onclick = function() {
        let next = row.nextElementSibling

        if (next) divPlaceholder.insertBefore(next, row)
    }
    row.delete.onclick = function() {
        row.remove()
    }

    row.appendChild(row.input1)
    row.appendChild(row.input2)
    row.appendChild(row.up)
    row.appendChild(row.down)
    row.appendChild(row.delete)
    divPlaceholder.appendChild(row)
}

buttonSave.onclick = function() {
    let elements = divPlaceholder.getElementsByTagName("div")
    let output = "{";

    for (let index = 0; index < elements.length; index++) {
        let element_inputs = elements[index].getElementsByTagName("input")

        output += '"' + element_inputs[0].value + '":"'
            + element_inputs[1].value + '",'
    }

    output = output.substring(0, output.length - 1) + "}";

    divOutput.innerText = output
}