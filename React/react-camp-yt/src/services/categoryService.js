import axios from "axios";

export default class CategoryService {
	getCategories() {
		return axios.get("https://dummyjson.com/products/categories")
	}
}