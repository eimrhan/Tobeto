import React, { useEffect, useState } from 'react'
import { Container, Card, ListGroup, Carousel, Image } from 'react-bootstrap';
import { Link, useParams } from 'react-router-dom';
import './ProductDetail.css'
import ProductService from 'services/productService';

const ProductDetail = () => {

	let { id } = useParams();

	const [productDetail, setProductDetail] = useState({});

	useEffect(() => {
		let productService = new ProductService()
		productService.getProductById(id).then(res => setProductDetail(res.data))
	}, [id]);

	return (
		<Container className='mt-5' data-bs-theme="dark">
			<Card>
				<Card.Title>{productDetail.title}</Card.Title>
				<Card.Subtitle className="mb-2 text-muted">{productDetail.brand} </Card.Subtitle>
				<Carousel>
					{productDetail && productDetail.images && productDetail.images.map((image, index) => (
						<Carousel.Item key={index}>
							<Image src={image} fluid className='product-image'/>
						</Carousel.Item>
					))}
				</Carousel>      
				<Card.Body>
					<Card.Text>{productDetail.description}</Card.Text>
				</Card.Body>
				<ListGroup className="list-group-flush">
					<ListGroup.Item>₺{productDetail.price}</ListGroup.Item>
					<ListGroup.Item>★{productDetail.rating}</ListGroup.Item>
					<ListGroup.Item>Stock: {productDetail.stock}</ListGroup.Item>
				</ListGroup>
				<Card.Body>
					<Link className='link' to="/">Go Home</Link>
					<Link className='link' to="/products">Go Products</Link>
				</Card.Body>
			</Card>

		</Container>
	)
}

export default ProductDetail