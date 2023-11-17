import React from 'react';
function Product(props) {
  return (
    <div>
      <h2>{props.name}</h2>
	  <img alt='ImageNotFound'>{props.img}</img>
      <p>Price: {props.price}</p>
    </div>
  );
}

export default Product;

