// reducer: "gönderdiğin aksiyona göre state'in son halini tuttuğun yer."

import { ADD_TO_CART, REMOVE_FROM_CART } from "store/actions/cartActions";
import { cartItems } from "store/initialValues/cartItems";

const initialState = {
	cartItems: cartItems
}

export default function cartReducer(state = initialState, { type, payload }) {
	switch (type) {
		case ADD_TO_CART:
			let product = state.cartItems.find(c => c.product.id === payload.id)
			if (product) {
				product.quantity++
				return {
					...state,
					cartItems: [...state.cartItems]
				}
			}
			else {
				return {
					...state,
					cartItems: [...state.cartItems, { quantity: 1, product: payload }]
				}
			}
		case REMOVE_FROM_CART:
			return {
				...state,
				cartItems: state.cartItems.filter(c => (c.product.id === payload.id))
			}
		default:
			return state
	}
}

export const selectCartItems = state => state.cart.cartItems;
