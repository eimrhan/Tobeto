
// dışarıdan erişmek istediğin classı export etmen gerekli,
// şu an aynı dosya içerisinde çalıştığımız için gerek duymadık.
// export class Customer {...}

class Customer {
	constructor(id, customerNumber) {

	}
}

let customer = new Customer(1, "12345"); // bu şekilde kullanılamıyor.
console.log(customer.id, customer.customerNumber); // undefined

// Prototyping
customer.name = "Emirhan";
console.log(customer.name); // Emirhan
// bu şekilde ekleme yapılabilir.

Customer.surname = "Çelebi";
console.log(customer.surname); // undefined
// burada değişikliği instance üzerinde yapmadığımız için ona işlemez.
console.log(Customer.surname); // Çelebi


// Prototyping işlemini class içerisinde tanımlayarak bunları aşabiliriz:
class Customer2 {
	constructor(id, customerNumber) {
		this.id = id;
		this.customerNumber = customerNumber;
	}
}

let customer2 = new Customer2(2, "23456"); // artık erişebiliriz.
console.log(customer2.id, customer2.customerNumber); // 2 '23456'


// Kalıtım:
// extends ile inherit edilebilir
class IndividualCustomer extends Customer2 {
	constructor (firstName, id, customerNumber) {
		super(id, customerNumber); // super = base (yani Customer2 class'ı)
		this.firstName = firstName;
	}
}
class CorporateCustomer extends Customer2 {
	constructor (companyName, id, customerNumber) {
		super(id, customerNumber);
		this.companyName = companyName;
	}
}

const list = [1,2,3,4,5];
const newList = list.map(e => e*2);
console.log(newList);