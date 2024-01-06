import ProductCard from 'components/ProductCard/ProductCard';
import React, { useEffect, useState } from 'react'
import { Container, Col, Row } from 'react-bootstrap'
import ProductService from 'services/productService';

const ProductList = () => {

	const [products, setProducts] = useState([]);

	useEffect(() => {
		let productService = new ProductService()
		productService.getProducts().then(res => setProducts(res.data.products))
	}, []);

	return (
		<Container className='mt-5'>
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