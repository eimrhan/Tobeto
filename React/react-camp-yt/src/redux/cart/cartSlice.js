import { createSlice } from '@reduxjs/toolkit'

export const cartSlice = createSlice({
	name: 'cart',
	initialState: {
		items: [
			{
				quantity: 1,
				product: {
					productName: 'Çubuk Kraker'
				}
			}
		]
	},
	reducers: {
		addToCart: {
			reducer: (state, action) => {
				state.items.push(action.payload)
			},
			prepare: (product) => {
				return {
					payload: {
						quantity: 1,
						product: product
					}
				}
			}
		},
		deleteFromCart: (state, action) => {
      const id = action.payload
      state.items = state.items.filter((item) => item.id !== id)
		}
	},
	extraReducers: {
		
	}
})

export default cartSlice.reducer;