//var txtHead = document.getElementById("txtH1");
//var txtHead = document.querySelector(".txtHead");
var txtHead = document.querySelectorAll(".txtHead");


// QuerySelector
//ID kimi yazanda # isharesi qoyulur
// Chox eyni adda class olanda biz birini chagiranda o bize birincini verecek

//Query Selector All
// chagiran zaman bize node list array verir.
// For each dovru quracagiq

var btnClick = document.getElementById("btnClick");

btnClick.addEventListener("click", ChangeText)

//button ishleyib ishlemediyini yoxlamaq uchun birinci alert etmek lazimdi
// alert()

function ChangeText() {
    txtHead.forEach(element => {
        console.log(element)
        element.style.color = "red"
        element.style.border = "1px solid black"
        element.style.fontSize = "25px"
    })
}

var txtInput = document.getElementById("txtInput")
txtInput.addEventListener("keyup", function () {
    if (txtInput.value.length <= 6) {
        document.querySelector(".error").innerHTML = "pls length must above 6"
        txtInput.style.borderColor = "red"
    }
    else {
        document.querySelector(".error").innerHTML = ""
    }
})

// HTML-de inner HTML sozu verir. Yeni ichinde yazilani
//input da value olur. tag ichinin sozunun innerHTML ile goturursen

for (let index = 0; index < 100000; index++) {
    const element = index;
}
window.addEventListener("load", function () {
    alert()
})

var mySelect = document.getElementById("mySelect");
mySelect.addEventListener("change", function () {
    //alert(mySelect.value);
    if (mySelect.value == "BMW") {
        var img = document.createElement("img")
        img.setAttribute("src", "https://images.pexels.com/photos/2127012/pexels-photo-2127012.jpeg?auto=compress&cs=tinysrgb&w=600")
        img.style.width = "200px"
        document.body.appendChild(img)
    }
    else if (mySelect.value == "Mercedes") {
        var img = document.createElement("img")
        img.setAttribute("src", "https://images.pexels.com/photos/2365572/pexels-photo-2365572.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")
        img.style.width = "200px"
        document.body.appendChild(img)
    }

})