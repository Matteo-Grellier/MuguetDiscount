import React from 'react';
function Product(props) {
	return (
		<div>
			<h2 style={{ fontSize: "20px", marginLeft: "20px", marginBottom: "-10px" }}>{props.name}</h2>
			<p style={{ fontSize: "20px", marginLeft: "20px" }}>{props.price}€</p>


			<img src={props.picture} alt='SUPER' />
		</div >
	);
}

export default Product;

