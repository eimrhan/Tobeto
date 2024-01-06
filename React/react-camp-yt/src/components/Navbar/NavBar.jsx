import CartSummary from 'components/Cart/CartSummary'
import React, { useState } from 'react'
import { Nav, Navbar, NavDropdown, Container, Form, Button } from 'react-bootstrap'
import './Navbar.css'
import SignedIn from 'components/Logins/SignedIn'
import SignedOut from 'components/Logins/SignedOut'
import { Link } from 'react-router-dom'

const NavBar = () => {

	const [isAuthenticated, setIsAuthenticated] = useState(false)

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
              <NavDropdown.Item>Action</NavDropdown.Item>
              <NavDropdown.Item>Another action</NavDropdown.Item>
              <NavDropdown.Divider />
              <NavDropdown.Item>Something else here</NavDropdown.Item>
            </NavDropdown>
            <Nav.Link disabled>Link</Nav.Link>
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
					<Nav className="nav-link" to="/products">
						<CartSummary />
					</Nav>
					{ isAuthenticated ? <SignedIn setIsAuthenticated={setIsAuthenticated} /> : <SignedOut setIsAuthenticated={setIsAuthenticated} /> }
        </Navbar.Collapse>
      </Container>
    </Navbar>
	)
}

export default NavBar