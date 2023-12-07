
import React from 'react';
import Navbar from '../Components/navbar';
import Product from '../Components/product';


import '../css/product.css'

function Home() {
	return (
		<div >
			<div>
				<Navbar />
			</div>
			<div className='productsContainer'>
				<Product name="product" price="20€">

				</Product>
				<Product name="product" price="20€">

				</Product>
				<Product name="product" price="20€">

				</Product>
				<Product name="product" price="20€">

				</Product>
				<Product name="product" price="20€">

				</Product>
				<Product name="product" price="20€">

				</Product>
				<Product name="product" price="20€">

				</Product>
				<Product name="product" price="20€">

				</Product>
			</div>

		</div>
	);
}

export default Home;
