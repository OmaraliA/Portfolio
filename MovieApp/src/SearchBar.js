
import React, { Component } from 'react';
import PropTypes from 'prop-types';
import CategoryItem from './CategoryItem';
import Content from './Content';
import ContentView from './ContentView';
import Login from './Login';
import Menu from './Menu';
import MenuItem from './MenuItem';
import Register from './Register';
import './SearchBar.css';



class SearchBar extends Component {

    

  render() {
    return (
    	<div> 
       		<div>
       			<input type="search" className="search"
     	            placeholder="                                                 search"/>
     	    </div> 
       
    	</div>
    );
  }
}


export default SearchBar;