import React from 'react';
import { BrowserRouter, Routes, Route } from "react-router-dom"
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Dashboard } from 'components/Dashboard/Dashboard';

function App() {
  return (
    <div className="App">
			<BrowserRouter>
				<Routes>
					<Route path="/" element={<Dashboard />}></Route>
					<Route path="*" element={<div>Not found</div>}></Route>
				</Routes>
			</BrowserRouter>
    </div>
  );
}

export default App;
