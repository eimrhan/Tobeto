import React from 'react'
import { Card, ListGroup, Button } from 'react-bootstrap'
import './ProductCard.css'

const ProductCard = (props) => {
	return (
		<Card data-bs-theme="dark" className='mb-3'>
			<Card.Img className='card-image' variant="top" src={props.product.thumbnail} />
			<Card.Body>
				<Card.Header className='card-title'>{props.product.title}</Card.Header>
				<Card.Text className='card-text'>{props.product.description}</Card.Text>
			</Card.Body>
			<ListGroup className="list-group-flush">
				<Card.Footer className='card-price'>₺{props.product.price}</Card.Footer>
				{/* <ListGroup.Item>{product.rating}</ListGroup.Item> */}
			</ListGroup>
			<Card.Body>
				<Button variant="primary">Add to Cart</Button>
				{/* <Button variant="danger">Delete</Button> */}
			</Card.Body>
		</Card>
	)
}

export default ProductCard