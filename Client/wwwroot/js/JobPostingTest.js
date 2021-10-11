var id;
var data;
var container;

function initialize_() {
    container = document.getElementsByClassName("post-summaries");

    console.log("Hello");


    divs = []
    for (var i = 0; i < container.length; i++) {
        console.log(i)
        divs.push(container[i])

    }

    divs.forEach((item, index) => {
        item.addEventListener('click', function () {
            var t = item.querySelector("#child")
            id = t.innerText;
        });
    });

    console.log(id); 

}


function show_() {

    console.log(id);
    return id;

}


function tempAlert(msg, duration) {
    var el = document.createElement("div");
    el.setAttribute("style", "position:absolute;top:40%;left:20%;background-color:white;");
    el.innerHTML = msg;
    setTimeout(function () {
        el.parentNode.removeChild(el);
    }, duration);
    document.body.appendChild(el);
}

var d = document.getElementById('d');
