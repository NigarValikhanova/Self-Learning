var data = document.querySelector("input[type=text]");
var btnAdd = document.getElementById("btnAdd");
var list = document.getElementById("list");
var jsonArr = JSON.parse(localStorage.getItem("todolist"));
var todolistArr = jsonArr == null ? [] : jsonArr;

//console.log(JSON.parse(localStorage.getItem("todolist")));
/*local storageden parse etdiyimizi goturub
arraylistin ichinde dovr edirem. 
her defe dovr edende li yaradib. innerhtml-ne beraber edirem datanin valuesini
sonra da liste appendchild edirem
*/
todolistArr.forEach(element => {
    var li = document.createElement("li");
    li.innerHTML = element;
    list.appendChild(li);
})


btnAdd.addEventListener("click", function () {
    //alert(data.value)
    var li = document.createElement("li");
    if (data.value == "") {
        data.nextElementSibling.innerHTML = "Enter something";
        data.style.borderColor = "red";
    }
    else {
        data.nextElementSibling.innerHTML = "";
        data.style.borderColor = "";
        li.innerHTML = data.value;
        list.appendChild(li);
        todolistArr.push(data.value);
        var span = document.createElement("SPAN");
        var txt = document.createTextNode("\u00D7");
        span.className = "close";
        span.appendChild(txt);
        li.appendChild(span);
        for (i = 0; i < close.length; i++) {
            close[i].onclick = function () {
                var div = this.parentElement;
                div.style.display = "none";
            }
        }
    }

    /*
    Local storage iki element var getItem setItem
    */
    //localStorage.setItem("todolist", todolistArr);
    //bu halda string formada yigir sehifede
    localStorage.setItem("todolist", JSON.stringify(todolistArr));

    data.value = "";

})

var close = document.getElementsByClassName("close");
var i;
for (i = 0; i < close.length; i++) {
  close[i].onclick = function() {
    var div = this.parentElement;
    div.style.display = "none";
  }
}