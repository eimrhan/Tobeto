import React from 'react';
import { Routes, Route } from 'react-router-dom';
import Homepage from './pages/Homepage/Homepage';

function App() {
  return (
    <div className="App">
			<Routes>
				<Route path='/' element={<Homepage />}></Route>	
			</Routes>		
    </div>
  );
}

export default App;
