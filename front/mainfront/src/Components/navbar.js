
import React from 'react';
import '../css/navbar.css';
import SearchBar from './searchbar';
import { useNavigate } from "react-router-dom"
import { useAuth0 } from "@auth0/auth0-react";
import ProfileBar from './profileBar';

function Navbar() {
	const { user, isAuthenticated } = useAuth0();

	let userIcon;
	let navigate = useNavigate();
	function click(params) {
		let path = "/cart";
		navigate(path);
	}
	function redirectToHome() {
		let path = "/";
		navigate(path);
	}

	if (isAuthenticated) {
		userIcon = user.picture;
	}

	return (
		<nav className="navbar">
			<div className='icon' onClick={redirectToHome}>
				<img alt='Logo' src='logo_4.png' />
			</div>
			<div className='centerContainer'>
				<div className='searchbar'>
					<SearchBar size="lg" />
				</div>
			</div>

			<div className='rightContainer'>
				<div className='cart' onClick={click}>

				</div>
				<div className='login' >
					{isAuthenticated ?
						< img src={userIcon} alt='' style={{ objectFit: 'cover', borderRadius: '40px', overflow: 'hidden' }} />
						:
						< img alt='no icon' style={{ color: 'black' }} />
					}

				</div>
				<ProfileBar />

			</div>

		</nav >
	);
}

export default Navbar;

