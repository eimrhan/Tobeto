const list = [1,2,3,4,5];

// Map

const newList = list.map(e => e*2);
console.log(newList); // 2 4 6 8 10


// Filter

const filteredList = list.filter(e => e<=3);
console.log(filteredList); // 1 2 3


// Reduce

const reducer = (accumulator, currentValue) => accumulator + currentValue;

// 1 + 2 + 3 + 4 + 5
console.log(list.reduce(reducer));
// 15

// 5 + 1 + 2 + 3 + 4 + 5
console.log(list.reduce(reducer, 5));
// 20
