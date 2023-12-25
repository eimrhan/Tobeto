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
		<ListGroup data-bs-theme="dark" className='mb-5'>
			{categories.map((category, id) => (
				<ListGroup.Item key={id}>
					<Link to={'/'} className='category-list'>{category}</Link>
				</ListGroup.Item>
			))}
		</ListGroup>
	)
}

export default Categories