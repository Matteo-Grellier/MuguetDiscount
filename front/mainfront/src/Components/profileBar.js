import React from "react";
import '../css/profileBar.css'
import { useNavigate } from "react-router-dom"
import { useAuth0 } from "@auth0/auth0-react";

function ProfileBar(params) {
	const { isAuthenticated } = useAuth0();

	let navigate = useNavigate();
	const { loginWithRedirect, logout } = useAuth0();
	function redirectToLoginPage() {
		let path = "/login";
		navigate(path);
	}
	function handleLogin() {
		loginWithRedirect();
	};
	function handleLogout() {
		logout();
	}

	return (
		<div className="ProfileBarContainer">
			<div className="Profile" onClick={redirectToLoginPage}>
				profile
			</div>
			{isAuthenticated ?
				<div className="Login" onClick={handleLogout}>
					Logout
				</div>
				:

				<div className="Login" onClick={handleLogin}>
					Login
				</div>}

		</div>
	);
}

export default ProfileBar;
