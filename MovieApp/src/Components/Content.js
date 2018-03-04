import React, { Component } from 'react';
import ContentView from './ContentView';
import '../css/Content.css';


class Content extends Component {
    

  render() {
    return (
    	<div className="Content">
    	
    		<div className="Bottom">
    			<ContentView movies = {this.props.movies} filterText={this.props.filterText }/>
    		</div>
    	</div> 
    );
  }
}
export default Content;

