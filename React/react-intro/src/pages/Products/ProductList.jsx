import axios from 'axios';
import React, { useEffect, useState } from 'react'
import { Card,ListGroup, Button, Col, Row } from 'react-bootstrap'

const ProductList = () => {

	const [products, setProducts] = useState([]);

	useEffect(() => {
		axiosGet();
	}, []);

	const axiosGet = async () => {
		let response = await axios.get("https://dummyjson.com/products");
		setProducts(response.data.products);
	};

	return (
		<Row>
			{products.map(product => (
				<Col lg={3} md={4} sm={6} key={product.id}>
					<Card data-bs-theme="dark" className='mb-3'>
						<Card.Img className='card-image' variant="top" src={product.thumbnail} />
						<Card.Body>
							<Card.Title className='card-title'>{product.title}</Card.Title>
							<Card.Text className='card-text'>{product.description}</Card.Text>
						</Card.Body>
						<ListGroup className="list-group-flush">
							<ListGroup.Item>₺{product.price}</ListGroup.Item>
							{/* <ListGroup.Item>{product.rating}</ListGroup.Item> */}
						</ListGroup>
						<Card.Body>
							<Button variant="primary">Add to Cart</Button>
							{/* <Button variant="danger">Delete</Button> */}
						</Card.Body>
					</Card>
				</Col>
			))}
		</Row>
	)
}

export default ProductList