
import React from 'react';
import '../css/navbar.css';
import SearchBar from './searchbar';
function Navbar() {
	function click(params) {
		console.log("hasclicked")
	}
	return (
		<nav className="navbar">
			<div className='icon'>

			</div>
			<div className='centerContainer'>
				<div className='searchbar'>
					<SearchBar size="lg" />
				</div>
				<div className='categories'>
					<a href='#' className='hover-underline-animation'>Informatique</a>
					<a href='#' className='hover-underline-animation'>Electroménager</a>
					<a href='#' className='hover-underline-animation'>Muguet</a>
					<a href='#' className='hover-underline-animation'>Sport</a>
					<a href='#' className='hover-underline-animation'>jardin</a>
				</div>
			</div>

			<div className='rightContainer'>
				<div className='cart' onClick={click}>

				</div>
				<div className='login'>

				</div>

			</div>
		</nav>
	);
}

export default Navbar;

