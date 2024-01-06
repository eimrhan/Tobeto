import React from 'react'
import { NavDropdown } from 'react-bootstrap'
import { Link } from 'react-router-dom'

const CartSummary = () => {
	return (
		<NavDropdown title="🛒 Cart" id="navbarScrollingDropdown">
			<NavDropdown.Item>Item 1</NavDropdown.Item>
			<NavDropdown.Item>Item 2</NavDropdown.Item>
			<NavDropdown.Divider />
			<NavDropdown.Item disabled>Toplam: </NavDropdown.Item>
			<NavDropdown.Divider />
			<Link className="nav-link ms-2" to="/cart_detail">Sepete Git</Link>
		</NavDropdown>
	)
}

export default CartSummary