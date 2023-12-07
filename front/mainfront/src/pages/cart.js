import React, { useState } from 'react';
import Navbar from '../Components/navbar';

const Cart = () => {
	const [cartItems, setCartItems] = useState([]);

	// Function to add an item to the cart
	const addToCart = (item) => {
		setCartItems([...cartItems, item]);
	};

	// Function to remove an item from the cart
	const removeFromCart = (item) => {
		const updatedCartItems = cartItems.filter((cartItem) => cartItem !== item);
		setCartItems(updatedCartItems);
	};

	return (
		<div style={{ display: 'flex', flexDirection: "column" }}>
			<title></title>
			<Navbar />
			<ul>
				{cartItems.map((item, index) => (
					<li key={index}>{item}</li>
				))}
			</ul>
			<div>
				<h1 style={{ justifyContent: 'center', display: 'flex' }}>
					Panier vide
				</h1>
			</div>

		</div>
	);
};

export default Cart;
