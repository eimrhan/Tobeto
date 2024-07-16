import React, { useEffect, useState } from 'react'
import { ListGroup } from 'react-bootstrap'
import { Link } from 'react-router-dom'
import './Category.css'
import CategoryService from 'services/categoryService'

const Categories = () => {

	const [categories, setCategories] = useState([])

	useEffect(() => {
		let categoryService = new CategoryService()
		categoryService.getCategories().then(res => setCategories(res.data));
	}, [])

	return (
		<ListGroup data-bs-theme="dark" className='mt-5 mb-5'>
			<ListGroup.Item variant="primary">Categories</ListGroup.Item>
			{categories.map((category, id) => (
				<ListGroup.Item key={id}>
					<Link to={'/'} className='category-list'>{category.name}</Link>
				</ListGroup.Item>
			))}
		</ListGroup>
	)
}

export default Categories