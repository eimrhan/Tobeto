import { useDispatch } from 'react-redux';
import { Button } from 'react-bootstrap';
import { addToCart } from 'store/actions/cartActions';
import { toast } from 'react-toastify';

const AddToCart = (props) => {

	const dispatch = useDispatch()

	const handleAddToCart = (product) => {
		dispatch(addToCart(product))
		toast.success(`${product.title} added to Cart!`)
	}

	return (
		<Button variant="primary" onClick={() => handleAddToCart(props.product)}>Add To Cart</Button>
	)
}

export default AddToCart