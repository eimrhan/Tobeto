import React from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { BrowserRouter, Routes, Route } from "react-router-dom"
import { Homepage } from 'pages/Homepage/Homepage';
import ProductList from 'pages/Products/ProductList';
import ProductDetail from 'pages/Products/ProductDetail';
import NavBar from 'components/Navbar/NavBar';

function App() {
	return (
		<div className="App">
			<BrowserRouter>
				<NavBar />
				<Routes>
					<Route path="/" element={<Homepage />}></Route>
					<Route path='/products' element={<ProductList />}></Route>
					<Route path='/products/:id' element={<ProductDetail />}></Route>
					<Route path="*" element={<div>404: Not Found</div>}></Route>
				</Routes>
			</BrowserRouter>
		</div>
	);
}

export default App;
