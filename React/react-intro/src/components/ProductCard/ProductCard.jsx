import React from 'react'
import { Card, ListGroup, Button } from 'react-bootstrap'
import './ProductCard.css'
import { Link } from 'react-router-dom'
import DeleteProduct from 'services/DeleteProduct'

const ProductCard = (props) => {
	return (
		<Card data-bs-theme="dark" className='mb-3'>
			<Card.Img className='card-image' variant="top" src={props.product.thumbnail} />
			<Card.Body>
				<Link className='card-link' to={'/products/' + props.product.id}> {/* /products?id= */}
					<Card.Header className='card-title'>{props.product.title}</Card.Header>
				</Link>
				<Card.Text className='card-text'>{props.product.description}</Card.Text>
			</Card.Body>
			<ListGroup className="list-group-flush">
				<Card.Footer className='card-price'>₺{props.product.price}</Card.Footer>
				{/* <ListGroup.Item>{product.rating}</ListGroup.Item> */}
			</ListGroup>
			<Card.Body>
				<Link to={'/products/' + props.product.id}>
					<Button className='card-button' variant="primary">Details</Button>
				</Link> 
				<DeleteProduct product={props.product} />
			</Card.Body>
		</Card>
	)
}

export default ProductCard