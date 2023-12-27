import React from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Routes, Route } from "react-router-dom"
import { Homepage } from 'pages/Homepage/Homepage';
import ProductList from 'pages/Products/ProductList';
import ProductDetail from 'pages/Products/ProductDetail';
import NavBar from 'components/Navbar/NavBar';
import AddProduct from 'pages/Products/AddProduct';

function App() {
	return (
		<div className="App">
			<NavBar />
			<Routes>
				<Route path="/" element={<Homepage />}></Route>
				<Route path='/products' element={<ProductList />}></Route>
				<Route path='/products/:id' element={<ProductDetail />}></Route>
				<Route path='/products/add' element={<AddProduct />}></Route>
				<Route path="*" element={<div>404: Not Found</div>}></Route>
			</Routes>
		</div>
	);
}

export default App;
