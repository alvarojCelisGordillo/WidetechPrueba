//Pregunta 4

obj = {
    "menu": {
        "id": "file",
        "value": "File",
        "popup": {
            "menuitem": [{
                "value": "New",
                "onclick": "CreateNewDoc()"
            }, {
                "value": "Open",
                "onclick": "OpenDoc()"
            }, {
                "value": "Close",
                "onclick": "CloseDoc()"
            }]
        }
    }
}

// The following method iterated through the object and prints the values of what it finds... Jquery library is needed for this. 

function Iterate(data) {
    $.each(data, function (index, value) {
        if (typeof value == 'object') {
            console.log("Objeto: " + index);
            Iterate(value);
        }
        else {
            console.log(index + ": " + value);
        }
    });
}

Iterate(obj);

// respuesta:

//"Objeto: menu"
//"id: file"
//"value: File"
//"Objeto: popup"
//"Objeto: menuitem"
//"Objeto: 0"
//"value: New"
//"onclick: CreateNewDoc()"
//"Objeto: 1"
//"value: Open"
//"onclick: OpenDoc()"
//"Objeto: 2"
//"value: Close"
//"onclick: CloseDoc()"




// Pregunta 5

function process(a, b) {
    return add(a, b);
}

function add(a, b) {
    return a + b;
}

console.log(process(4, 2)); // respuesta 6 