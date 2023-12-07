import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import reportWebVitals from './reportWebVitals';

import { RouterProvider, createBrowserRouter } from 'react-router-dom';
import Home from './pages/home';
import Cart from './pages/cart';
import { Auth0Provider } from '@auth0/auth0-react';
import LoginPage from './pages/loginPage';

const router = createBrowserRouter([
	{
		path: "/",
		element: <Home />,
	},
	{
		path: "/cart",
		element: <Cart />
	},
	{
		path: "/login",
		element: <LoginPage />
	}
]);

ReactDOM.createRoot(document.getElementById('root')).render(
	<React.StrictMode>
		<Auth0Provider
			domain='dev-nuuram1lnqh3b51m.us.auth0.com'
			clientId='AwEpNJLzoIG5TPsYEsmTYcs7b1dJe9zW'
			authorizationParams={{
				redirect_uri: window.location.origin
			}}
		>
			<RouterProvider router={router} />

		</Auth0Provider>

	</React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
