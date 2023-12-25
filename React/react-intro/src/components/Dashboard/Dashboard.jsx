import React from 'react'
import Categories from '../CategoryList/Categories'
import NavBar from '../Navbar'
import ProductList from 'pages/Products/ProductList'
import { Container, Row, Col } from 'react-bootstrap'

export const Dashboard = () => {
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
