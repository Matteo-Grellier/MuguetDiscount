
import React, { useState } from 'react';
import '../css/searchbar.css'
function SearchBar(props) {
	const [searchTerm, setSearchTerm] = useState('');

	const handleInputChange = (event) => {
		setSearchTerm(event.target.value);
	};

	const handleSubmit = (event) => {
		event.preventDefault();
		props.onSearch(searchTerm);
	};

	return (
		<form onSubmit={handleSubmit}>
			<input type="text" placeholder="Search..." value={searchTerm} onChange={handleInputChange} className='search-input' />
		</form>
	);
}

export default SearchBar;

