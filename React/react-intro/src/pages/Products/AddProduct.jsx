import React from 'react'
import { Container, InputGroup, Form } from 'react-bootstrap';

const AddProduct = () => {
	return (
		<Container data-bs-theme="dark" className='mt-5' style={{ width: "50%" }}>
			<Form.Label className="mb-5"><h1>Add Product</h1></Form.Label>
			<Form.Control className="mb-3" type="text" placeholder="Product Name" />
			<Form.Group className="mb-3" controlId="exampleForm.ControlTextarea1">
				<Form.Control as="textarea" rows={3} placeholder="Description" />
			</Form.Group>
			<InputGroup className="mb-3">
				<InputGroup.Text>₺</InputGroup.Text>
				<Form.Control aria-label="Amount" placeholder="Price" />
				<InputGroup.Text>.00</InputGroup.Text>
			</InputGroup>
			<Form.Group controlId="formFileMultiple" className="mb-3">
        <Form.Label>Upload Images</Form.Label>
        <Form.Control type="file" multiple />
      </Form.Group>
		</Container>
	)
}

export default AddProduct