import React from 'react'
import { NavDropdown } from 'react-bootstrap'
import { Link } from 'react-router-dom'
import { useSelector } from 'react-redux'
import { selectCartItems } from 'store/reducers/cartReducer'

const CartSummary = () => {

	const cartItems = useSelector(selectCartItems)

	return (
		<NavDropdown title="🛒 Cart" id="navbarScrollingDropdown">
			{cartItems?.map(item => (
				<NavDropdown.Item key={item.product.id}>
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