
import React, { Component } from 'react';
import PropTypes from 'prop-types';
import CategoryItem from './CategoryItem';
import Content from './Content';
import ContentView from './ContentView';
import Login from './Login';
import Menu from './Menu';
import MenuItem from './MenuItem';
import Register from './Register';

import '../css/Header.css';



class Header extends Component {

  constructor(){
    super();
    this.state = { filterText: ''};
  }
   handleUserInput(searchTerm){
    this.setState({filterText:searchTerm})
  }

  render() {
    return (
    	<div className="header"> 
          <div className ="searching">
          

          </div>

          <div className="login">
            <Login/>
          </div>

          <div className="register">
           	<Register/>
          </div>

      </div>
    );
  }
}





export default Header;