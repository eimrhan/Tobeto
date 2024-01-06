import axios from "axios";

export default class ProductService {
	getProducts() {
		return axios.get("https://dummyjson.com/products")
	}
	getProductById(id) {
		return axios.get("https://dummyjson.com/products/" + id)
	}
}