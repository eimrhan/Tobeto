import CartSummary from 'components/Cart/CartSummary'
import React from 'react'
import { Nav, Navbar, NavDropdown, Container, Form, Button } from 'react-bootstrap'
import './Navbar.css'
import { Link } from 'react-router-dom'

const NavBar = () => {
	return (
		<Navbar expand="lg" className="navbar bg-body-tertiary" data-bs-theme="dark" sticky="top">
			<Container /* fluid */>
				<Navbar.Brand href="#">Tobeto</Navbar.Brand>
				<Navbar.Toggle aria-controls="navbarScroll" />
				<Navbar.Collapse id="navbarScroll">
					<Nav
						className="me-auto my-2 my-lg-0"
						style={{ maxHeight: '100px' }}
						navbarScroll
					>
						<Link className="nav-link" to='/'>Home</Link>
						<Link className="nav-link" to="/products">Products</Link>
						<NavDropdown title="Link" id="navbarScrollingDropdown">
							<NavDropdown.Item href="#action3">Action</NavDropdown.Item>
							<NavDropdown.Item href="#action4">Another action</NavDropdown.Item>
							<NavDropdown.Divider />
							<NavDropdown.Item href="#action5">Something else here</NavDropdown.Item>
						</NavDropdown>
						<Nav.Link href="#" disabled>Link</Nav.Link>
					</Nav>
					<Form className="d-flex">
						<Form.Control
							type="search"
							placeholder="Search"
							className="me-2"
							aria-label="Search"
						/>
						<Button variant="outline-success">Search</Button>
					</Form>
					<Nav>
						<CartSummary />
					</Nav>
				</Navbar.Collapse>
			</Container>
		</Navbar>
	)
}

export default NavBar