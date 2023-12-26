import axios from 'axios';
import React, { useState } from 'react'
import { useNavigate } from 'react-router-dom';
import { Container, InputGroup, Form, Button } from 'react-bootstrap';

const AddProduct = () => {

	const [validated, setValidated] = useState(false)

	const [product, setProduct] = useState({
		title: '',
		description: '',
		price: '',
		files: []
	});

	const handleProductChange = (e) => {
		const { name, value } = e.target;
		setProduct((prevProduct) => ({
			...prevProduct,
			[name]: value
		}));
	};

	const navigate = useNavigate();

	const handleAddProduct = (event) => {
		event.preventDefault();

		const form = event.currentTarget;

    if (form.checkValidity()) {
			axios.post('https://dummyjson.com/products/add', {
				title: product.title,
				description: product.description,
				price: product.price,
				files: product.files
			})
				.then(response => console.log(response.data))
				.catch(error => console.error('Error:', error));
			navigate('/products');
    } 
		setValidated(true);
	};

	return (
		<Container data-bs-theme="dark" className='mt-5' style={{ width: "50%" }}>
			<Form noValidate validated={validated} onSubmit={handleAddProduct}>
				<Form.Label className="mb-5"><h1>Add Product</h1></Form.Label>

				<Form.Control required className="mb-3" type="text" placeholder="Product Name"
					name='title' value={product.title} onChange={handleProductChange} />

				<Form.Group className="mb-3" controlId="exampleForm.ControlTextarea1">
					<Form.Control required as="textarea" rows={3} placeholder="Description"
						name="description" value={product.description} onChange={handleProductChange} />
				</Form.Group>

				<InputGroup className="mb-3">
					<InputGroup.Text>₺</InputGroup.Text>
					<Form.Control required aria-label="Amount" placeholder="Price" type="number"
						name="price" value={product.price} onChange={handleProductChange} />
					<InputGroup.Text>.00</InputGroup.Text>
				</InputGroup>

				<Form.Group controlId="formFileMultiple" className="mb-3">
					<Form.Label>Upload Images</Form.Label>
					<Form.Control type="file" multiple
						name="images" value={product.images} onChange={handleProductChange} />
				</Form.Group>

				<Button variant="primary" type="submit">Submit</Button>
			</Form>
		</Container>
	)
}

export default AddProduct