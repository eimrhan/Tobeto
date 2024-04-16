import React from 'react'
import { Button } from 'react-bootstrap'

const SignedOut = ({setIsAuthenticated}) => {

	const handleSignIn = () => {
		setIsAuthenticated(true)
	}

	return (
		<div className='d-flex align-items-center'>
			<Button variant="success" className='me-2 ms-2' onClick={handleSignIn}>Login</Button>
			<Button variant="primary">Register</Button>
		</div>
	)
}

export default SignedOut