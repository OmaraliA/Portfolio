

import React, { Component } from 'react';
import {
  BrowserRouter as 
 
  Route,
  NavLink,
  HashRouter,
 
} from 'react-router-dom';


import Header from './Header';
import Login from './Login';
import Register from './Register';
import Comedy from './Comedy';
import Thriller  from './Thriller';
import Romance   from './Romance';
import '../css/MenuItem.css';


class MenuItem extends Component {
    

  render() {
    return (
      
       <div>
        <HashRouter>
        <div className="menubar">
          <ul className="menuitems">
           <li><NavLink to="/Comedy">Comedy</NavLink></li>
            <li><NavLink to="/Romance"><h1>Romance</h1></NavLink></li>
           <li><NavLink to="/Thriller"><h1>Thriller</h1></NavLink></li>
         
          </ul>
</div>
  <div className="links">
      
            <Route path='/Comedy' component={Comedy} />
            <Route path='/Romance' component={Romance} />
            <Route path='/Thriller' component={Thriller} />
         </div>
        </HashRouter>
           </div>

    );
  }
}
export default MenuItem;









