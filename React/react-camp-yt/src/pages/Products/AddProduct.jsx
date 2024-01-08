import './AddProduct.css'
import { Formik, Form, Field } from 'formik'
import * as yup from 'yup'
import { Container, InputGroup, Button, FormLabel, FormGroup, FormControl } from 'react-bootstrap';

const AddProduct = () => {

	const initialValues = {
		title: '',
		description: '',
		price: '',
		files: []
	}

	const validationSchema = yup.object({
		title: yup.string().required(),
		price: yup.number().required().min(0).max(999999, "milyonluk ürün satamazsın burada")
	})

	//* Devam Edecek...

	return (
		<Container data-bs-theme="dark" className='mt-5' style={{ width: "50%" }}>
			<Formik
				initialValues={initialValues}
				validationSchema={validationSchema}
			>
				<Form className='form'>
					<FormLabel className="mb-5 mt-5"><h1>Add Product</h1></FormLabel>

					<FormControl required className="mb-3" type="text" placeholder="Product Name"
						name='title' />

					<FormGroup className="mb-3" controlId="exampleForm.ControlTextarea1">
						<FormControl as="textarea" rows={3} placeholder="Description"
							name="description" />
					</FormGroup>

					<InputGroup className="mb-3">
						<InputGroup.Text>₺</InputGroup.Text>
						<FormControl required aria-label="Amount" placeholder="Price" type="number"
							name="price" className='input-price' />
						<InputGroup.Text>.00</InputGroup.Text>
					</InputGroup>

					<FormGroup controlId="formFileMultiple" className="mb-3">
						<FormLabel>Upload Images</FormLabel>
						<FormControl type="file" multiple
							name="images" />
					</FormGroup>

					<Button variant="primary" type="submit">Submit</Button>
				</Form>
			</Formik>
		</Container>
	)
}

export default AddProduct