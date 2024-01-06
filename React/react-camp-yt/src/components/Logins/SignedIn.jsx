import React from 'react'
import { Dropdown, ButtonGroup, Image } from 'react-bootstrap'

const SignedIn = ({setIsAuthenticated}) => {

	const handleSignOut = () => {
		setIsAuthenticated(false)
	}

	return (
		<Dropdown as={ButtonGroup}>
			<div className="vr" />
			<Image roundedCircle src='https://img.icons8.com/fluency/48/person-male.png'></Image>
			<Dropdown.Item className='me-2'>emirhan</Dropdown.Item>
			<Dropdown.Toggle split variant="outline-secondary" id="dropdown-split-basic" />
			<Dropdown.Menu>
				<Dropdown.Item href="#/action-1">Settings</Dropdown.Item>
				<Dropdown.Divider />
				<Dropdown.Item href="#/action-3" onClick={handleSignOut}>Log Out</Dropdown.Item>
			</Dropdown.Menu>
		</Dropdown>
	)
}

export default SignedIn