import React from 'react'
import { Button } from 'react-bootstrap'
import axios from 'axios'

const DeleteProduct = (props) => {

	const handleDeleteClick = (id) => {
		axios.delete('https://dummyjson.com/products/' + id)
			.then(response => console.log(response.data))
			.catch(error => console.error(error));
	}

	return (
		<Button variant="danger" onClick={() => handleDeleteClick(props.product.id)}>Delete</Button>
	)
}

export default DeleteProduct