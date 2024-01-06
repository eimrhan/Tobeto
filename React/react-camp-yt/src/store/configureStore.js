import { legacy_createStore as createStore } from 'redux'
import rootReducer from './rootReducer'
import { devToolsEnhancer } from 'redux-devtools-extension'

export function configureStore() {
	return createStore(rootReducer, devToolsEnhancer())
}

// import { configureStore } from '@reduxjs/toolkit'
// import cartReducer from './reducers/cartReducer'
// 
// export const store = configureStore({
// 	reducer: {
// 		cart: cartReducer
// 	}
// })