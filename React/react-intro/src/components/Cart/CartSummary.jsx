import React from 'react'
import { NavDropdown } from 'react-bootstrap'

const CartSummary = () => {
	return (
		<NavDropdown title="🛒 Cart" id="navbarScrollingDropdown">
			<NavDropdown.Item href="#action3">Item 1</NavDropdown.Item>
			<NavDropdown.Item href="#action4">Item 2</NavDropdown.Item>
			<NavDropdown.Divider />
			<NavDropdown.Item href="#action5">Toplam: </NavDropdown.Item>
		</NavDropdown>
	)
}

export default CartSummary