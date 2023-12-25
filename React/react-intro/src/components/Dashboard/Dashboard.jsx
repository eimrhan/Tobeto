import React from 'react'
import Categories from '../CategoryList/Categories'
import NavBar from '../Navbar'
import ProductList from 'pages/Products/ProductList'
import { Container } from 'react-bootstrap'
import { Row } from 'react-bootstrap'
import { Col } from 'react-bootstrap'

export const Dashboard = () => {
	return (
		<>
			<NavBar />
			<Container >
				<Row className='mt-5'>
					<Col sm={3}>
						<Categories />
					</Col>
					<Col lg={9}>
						<ProductList />
					</Col>
				</Row>
			</Container>
		</>
	)
}
