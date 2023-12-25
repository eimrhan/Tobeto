import axios from 'axios';
import ProductCard from 'components/ProductCard/ProductCard';
import React, { useEffect, useState } from 'react'
import { Container, Col, Row } from 'react-bootstrap'

const ProductList = () => {

	const [products, setProducts] = useState([]);

	useEffect(() => {
		axios("https://dummyjson.com/products")
			.then(res => setProducts(res.data.products))
	}, []);

	return (
		<Container>
			<Row>
				{products.map(product => (
					<Col lg={3} md={4} sm={6} key={product.id}>
						<ProductCard product={product} />
					</Col>
				))}
			</Row>
		</Container>
	)
}

export default ProductList