import React from 'react'
import { Button } from 'react-bootstrap'

const SignedOut = ({setIsAuthenticated}) => {

	const handleSignIn = () => {
		setIsAuthenticated(true)
	}

	return (
		<div>
			<Button variant="success" className='me-2 ms-2' onClick={handleSignIn}>Log In</Button>
			<Button variant="primary">Register</Button>
		</div>
	)
}

export default SignedOut