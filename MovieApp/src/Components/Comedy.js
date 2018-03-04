import React, { Component } from 'react';

import img1 from '../img/aceventura.jpeg';
import img2 from '../img/bigdaddy.jpeg'
import Content from './Content';
import '../css/Comedy.css';
import '../css/CategoryItem.css';

class Comedy extends Component {
		constructor(props){
    super(props);
	    this.state = {
	      movies: [{id: 0, name: 'Ace Ventura: When Nature Calls', year: 1995, img: img1, description: 'Ace Ventura, Pet Detective, returns from a spiritual quest to investigate the disappearance of a rare white bat, the sacred animal of a tribe in Africa.'},
	               {id: 2, name: 'Big Daddy', year: 1999, img: img2, description: 'A lazy law school grad adopts a kid to impress his girlfriend, but everything doesnt go as planned and he becomes the unlikely foster father. '}]
	    }
  	}
  render() {

 
    return (
      <div className ="comedies">
          <h1 className="title">Comedy films</h1>   
        <p className="App-intro">
        
      <ul className="contacts">
                        { this.state.movies.map((contact,index) =>
                          <li key={index} className="chip" 
                            name={contact.name}
                            img={contact.img}
                           
                            >     
                           
                              {contact.name}   
                              <img className="images" src={contact.img}/>
                                 
                                 
                              </li>
                       
                        )}

                    </ul>
     
          
        </p>
      </div>
    );
  }
}
export default Comedy ;
