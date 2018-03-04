
import React, { Component } from 'react';
import '../css/MovieInfo.css'

class MovieInfo extends Component {

  constructor(props){
    super(props);
    this.state = {
      commentText: '',
       comments: [{id: 0, text: 'best movie I have ever seen!'}],
      nextId: 0
    };
    this.handleInput = this.handleInput.bind(this);
     this.handleClick = this.handleClick.bind(this);
  }

  handleInput(e){
    this.setState({commentText: e.target.value});
    console.log(this.state.commentText);
  }

  handleClick(e){
     let comments = this.state.comments.slice();
    comments.push({id: this.state.nextId, text: this.state.commentText});
    this.setState({
      comments: comments,
      nextId: ++this.state.nextId,
      commentText: ''
    });
  }

  render() {
     var items = this.state.comments.map((comment, index) =>
      <li key={index}>
      <label> Guest: {comment.text}</label>
      </li>
    )
    console.log(items);
    return (

<div className="all">
<ul>
<div className="inside">
      <div className= "info">
      <div className="images">
       <img className="img" alt = "img" src={this.props.movie.img}/>
       </div>

      <div className="desk">
        <p className="names">{this.props.movie.name}</p>
       
        <p className="name">{this.props.movie.description}<br/>
 
        <a href="http://facebook.com"> <i id="icons" class="facebook square icon"></i></a>
       <a href="http://whatsapp.com">  <i id="icons" class="whatsapp icon"></i></a>
       <a href="http://twitter.com">  <i id="icons" class="twitter icon"></i></a><br/>

        </p>
<div id="scroll">
 <ul><p className="items">{items}</p>
        <p className="com">Leave comment here</p></ul>
      
       </div>

      </div>
   
        <textarea id="comments" value = {this.state.commentText} onChange = {this.handleInput}/>
        <input id="commentss"className="ui inverted blue button" type = "submit" value = "Comment" onClick = {this.handleClick}/>
      </div>
       </div>
      </ul>

      </div>
    );
  }
}

export default MovieInfo;
