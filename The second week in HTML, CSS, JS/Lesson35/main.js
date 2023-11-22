//console.log("Hello World!!!!")
//var ad = prompt("Zehmet olmasa ad daxil et")
//console.log(ad)

//var car = "Fiat"
//object de var ile yazilir
//var car = {type: "Fiat", model: "500", color: "white"}
//car.type
//car.model
//car.color
//var fin = 'AZE09876543'
//fin.substring(0,3) // AZE ni verir
//fin.substring(3) // AZE ni silir, qalanini verir

// slice, substring, substr eyni ishi gorur demek olar ki

//slice(start, end)
//substring(start, end)
//substr(start, length)

//substr de menfi de vermek olur. Menfi odu ki arxadan oxuyur her bir simvolu

//var text = 'Welcome to your Show'
//text.replace('Show', 'Home') 
//tekce ilk sozu deyishir

//var text2 = 'Welcome to your Show, Show, Show' 
//text2.replaceAll('Show', 'Home')
//Butun eyni sozleri deyishir

//var text1 = "Hello";
//var text2 = "World";
//var text3 = text1.concat(" ", text2);
//console.log(text3)

//var num1 = '3'
//num1.padStart(3, '0')
//num1 = '15'
//num1.padStart(3, '15')

//text.charCodeAt(5) // ASCII table yerini gosterir // 109 qaytarir

//var data = 'SaLaM'

//for (var i = 0; i < data.length; i++) {
     ////console.log(data[i].charCodeAt());
    //var charCodeAtChar = data[i].charCodeAt;

    //if(charCodeAtChar >= 65 && charCodeAtChar <= 90)
    //{
        //console.log(data[i] + 'boyukdur')
    //}
//}

//var arr = [1,6,9,7,3,2]

//arr.forEach(x=>{
    //console.log(x)
//});
//string de foreach olmur

////for of ve for in ferqi -- of datani cixarir, in indexi


//arr.toString()
// string e cevirdi
//arr.pop()
// pop sondan silir ve qaytarir
//arr.push('skjfskfjs')
// push elave edir ve arrayin neche datasi oldugunu gosterir

//arr.shift()
//evvelden silir ve qaytarir

//arr.unshift(18)
// evvele elave edir ve neche datasi oldugunu gosterir

//var fruits = ["Banana", "Orange", "Apple", "Mango"];
//fruits.splice(1,1, "Watermelon")
//silir yerine basqa data add edir
//fruits.splice(1, fruits.length-1, "Pineapple")

//fruits.slice(2)
//silmir sadece gosterir hansi datadi

//// ARRAY IN EN BOYUK ELEMENTI

//var array = [2,15,36,48,53,852,752,652,696,589,96,67,123,456,20,40,102,94,10,74,36,63,95,78,33,45,68,27,159,23,208,325,42,235,271,45,56,89,98,78,87,40,172]
//var maxNum = array[0]
//for (var item of array) {
    //if(item>maxNum){
        //maxNum=item
    //}
//}
//console.log(maxNum)


//Math.round(x)	Returns x rounded to its nearest integer
//Math.ceil(x)	Returns x rounded up to its nearest integer
//Math.floor(x)	Returns x rounded down to its nearest integer
//Math.trunc(x)	Returns the integer part of x


//// FUNCTION

//function GetLargeElement(arr){
    //var maxNum = arr[0]
    //for (var item of arr) {
        //if(item>maxNum){
            //maxNum=item
        //}
    //}
    //console.log(maxNum)
//}
//var xArr = [2,15,36,48,53,852,752,652,696,589,96,67,123,456,20,40,102,94,10,74,36,63,95,78,33,45,68,27,159,23,208,325,42,235,271,45,56,89,98,78,87,40,172]
//GetLargeElement(xArr)