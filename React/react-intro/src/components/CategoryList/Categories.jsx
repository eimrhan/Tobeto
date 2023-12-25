import axios from 'axios'
import React, { useEffect, useState } from 'react'
import { ListGroup } from 'react-bootstrap'

const Categories = () => {

	const [categories, setCategories] = useState([])

	useEffect(() => {
		axiosGet();
	}, [])

	const axiosGet = async () => {
		let response = await axios.get("https://dummyjson.com/products/categories");
		setCategories(response.data);
	}
	
	return (
		<div>
			<ListGroup data-bs-theme="dark" className='mb-5'>
				{categories.map((category, id) => (
				<ListGroup.Item key={id}>{category}</ListGroup.Item>
				))}
			</ListGroup>
		</div>
	)
}

export default Categories