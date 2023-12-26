import axios from 'axios'
import React, { useEffect, useState } from 'react'
import { ListGroup } from 'react-bootstrap'
import { Link } from 'react-router-dom'
import './Category.css'

const Categories = () => {

	const [categories, setCategories] = useState([])

	useEffect(() => {
		axios("https://dummyjson.com/products/categories")
			.then(res => setCategories(res.data));
	}, [])

	return (
		<ListGroup data-bs-theme="dark" className='mt-5 mb-5'>
			<ListGroup.Item variant="primary">Categories</ListGroup.Item>
			{categories.map((category, id) => (
				<ListGroup.Item key={id}>
					<Link to={'/'} className='category-list'>{category}</Link>
				</ListGroup.Item>
			))}
		</ListGroup>
	)
}

export default Categories