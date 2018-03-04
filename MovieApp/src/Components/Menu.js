import React, { Component } from 'react';
import PropTypes from 'prop-types';
import CategoryItem from './CategoryItem';
import Content from './Content';
import ContentView from './ContentView';
import Header from './Header';
import Login from './Login';
import MenuItem from './MenuItem';
import Register from './Register';

import '../css/Menu.css';


class Menu extends Component {
    

  render() {
    return (
        <div className="menubar">
          <MenuItem/>
        </div>
    );
  }
}
export default Menu;









