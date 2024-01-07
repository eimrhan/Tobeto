import Categories from '../../components/CategoryList/Categories'
import ProductList from 'pages/Products/ProductList'
import { Container, Row, Col } from 'react-bootstrap'
import { ToastContainer } from 'react-toastify'

export const Homepage = () => {
	return (
		<>
			<ToastContainer position="bottom-right" />
			<Container>
				<Row>
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
