import React from 'react'
import { NavDropdown } from 'react-bootstrap'
import { Link } from 'react-router-dom'
import { useSelector } from 'react-redux'

const CartSummary = () => {

	const cartItems = useSelector(state => state.cart)

	return (
		<NavDropdown title="🛒 Cart" id="navbarScrollingDropdown">
			{cartItems?.map((item, index) => (
				<NavDropdown.Item key={index}>
					[{item.quantity}x] {item.product.productName}
				</NavDropdown.Item>
			))}
			{/* <NavDropdown.Divider /> */}
			{/* <NavDropdown.Item disabled>Toplam: </NavDropdown.Item> */}
			<NavDropdown.Divider />
			<Link className="nav-link ms-2" to="/cart_detail">Sepete Git</Link>
		</NavDropdown>
	)
}

export default CartSummary