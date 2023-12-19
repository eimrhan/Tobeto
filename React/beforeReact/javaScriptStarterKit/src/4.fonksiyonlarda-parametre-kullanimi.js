//default değerli parametre verilecekse onları en sona yazman gerekir.
// o parametreye değer göndererek default değeri ezebilirsin.
function fonksiyon (var0, var1=3, var2=4) {
	return var0+var1-var2;
}
fonksiyon(5,1); // 5+1-4 => 2 yazar.

// ya da bu şekilde fonksiyonun içerisinde
function fonksiyon (var5) {
	if (typeof var5 === "undefined")
		var5 = "..."; // koşulu kullanılabilir.
}

// default değerli parametreyi sonda kullanmak istemiyorum dersen:
let student = {id:1, name:"Emir"};
function sinav (puan=50, ogrenci) {
	console.log(ogrenci.name + ": " + puan);
}
sinav(undefined,student); // Emir: 50


const yaz = (str) => {
	console.log(str);
}
yaz(); // undefined döner ama hata vermez.


const topla = (x,y) => x+y;console.log(topla()); // NaN
console.log(topla(5)); // NaN
console.log(topla(5,10)); // 15
console.log(topla(5,"4")); // 54
console.log(topla(5,4,3,2,1)); // 9
// ilk 2 değeri alır, diğerlerini görmezden gelir. hata dönmeden sonucu verir.