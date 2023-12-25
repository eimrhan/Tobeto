import React from 'react'
import Categories from '../../components/CategoryList/Categories'
import NavBar from '../../components/Navbar/NavBar'
import ProductList from 'pages/Products/ProductList'
import { Container, Row, Col } from 'react-bootstrap'

export const Homepage = () => {
	return (
		<>
			<NavBar />
			<Container >
				<Row className='mt-5'>
					<Col lg={2} sm={3}>
						<Categories />
					</Col>
					<Col lg={10} sm={9}>
						<ProductList />
					</Col>
				</Row>
			</Container>
		</>
	)
}
