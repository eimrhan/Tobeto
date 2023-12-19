var a = 3
let b = 3
const c = 3

var a = 4
// let b = 4  // yapamazsın.
// const c = 4 // yapamazsın.

a = 5
b = 5
// c = 5 // yapamazsın.

a = "beş" // => beş
// b = "beş" // yapamazsın.
// c = "beş" // yapamazsın.

{
	var a = "altı"
	let b = "altı"
	const c = "altı"
	console.log(a); // => altı
	console.log(b); // => altı
	console.log(c); // => altı
}

console.log(a); // => altı
console.log(b); // => 5
console.log(c); // => 3
{
	var x = 1;
}
console.log(x); // 1

{
	let y = 2;
}
console.log(y); // error