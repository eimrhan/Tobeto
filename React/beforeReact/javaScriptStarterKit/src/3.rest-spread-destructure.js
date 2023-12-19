//Spread

console.log(..."ABC", "D", ..."EFG", "H") // A B C D E F G H

const numbers1 = [1,2,3];
const numbers2 = [...numbers1,4,5,6]; // 1,2,3,4,5,6

const [a,b,...numbers3] = numbers2;
// numbers2 dizisi 6 eleman içerdiği için a=1,b=2 atandıktan sonra kalanları numbers3 dizisine atar.

const sumNumber = (a,b,c) => a+b+c;
sumNumber(...numbers1); // 1+2+3 = 6 hesaplandı.


// Rest

const currentDate = new Date();
const currentYear = currentDate.getFullYear();

function isDriver(age,...birthyears) {
	birthyears.forEach(birthyear => console.log(currentYear - birthyear >= age));
}

isDriver(18, 2015, 1986, 2000); // true false false


// Destructing

// Dizilerle Kullanımı:

let arr=[1,2,3,4,[5,6]];
const [num1,num2] = arr; // num1=1, num2=2 atanır.
// eğer atamada atlama yapmak / boş bırakmak istersen:
const [,,num3,num4,[num5,num6]] = arr;
// iç içe Destructing kullanımı da bu şekilde.
console.log(num1,num2,num3,num4,num5,num6); // 1 2 3 4 5 6

// Nesnelerle Kullanımı:

const objConfig = {
	server : 'localhost',
	port : '8080',
	timeout : 900
}
const {server:s, port:p, timeout:t, und:u=500} = objConfig;console.log(s,p,t,u); // localhost 8080 900 500

// Fonksiyonlarla Kullanımı:

function myFunction([num1], num2) {
	console.log(num1); // 1
	console.log(num2); // undefined
}
myFunction(arr);
