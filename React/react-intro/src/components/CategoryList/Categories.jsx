import React from 'react'
import { ListGroup } from 'react-bootstrap'

const Categories = () => {
	return (
		<div>
			<ListGroup data-bs-theme="dark">
				<ListGroup.Item>Categories</ListGroup.Item>
				<ListGroup.Item>Dapibus ac facilisis in</ListGroup.Item>
				<ListGroup.Item>Cras justo odio</ListGroup.Item>
				<ListGroup.Item>Morbi leo risus</ListGroup.Item>
				<ListGroup.Item>Vestibulum at eros</ListGroup.Item>
			</ListGroup>
		</div>
	)
}

export default Categories