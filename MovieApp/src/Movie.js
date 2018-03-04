import React, { Component } from 'react';
import ContentView from './Components/ContentView';
import Menu from './Components/Menu';
import Content from './Components/Content';
import Comedy from './Components/Comedy';
import Header from './Components/Header';
import Thriller  from './Components/Thriller';
import Romance   from './Components/Romance';
import Horror   from './Components/Horror';
import './css/Movie.css';
import './css/SearchBar.css'
import './css/MenuItem.css';
import Login from './Components/Login';
import Register from './Components/Register';
import img1 from './img/interstellar.jpg'
import img2 from './img/aliceinwonderland.png'
import img3 from './img/thebackupplan.jpeg'
import img4 from './img/aceventura.jpeg';
import img5 from './img/bigdaddy.jpeg';
import img6 from './img/titanic.jpeg';
import img7 from './img/notebook.jpeg';
import img8 from './img/knight.jpeg';
import img9 from './img/inception.jpeg';
import img10 from './img/mirrors.jpeg';
import img11 from './img/saw1.jpeg';

class Movie extends Component {

  constructor(props){
    super(props);
    this.state = {
    /*  movies: [{}],*/
      movies: [{id: 0, name: 'Interstellar', year: 2014, img: img1, description: 'A team of explorers travel through a wormhole in space in an attempt to ensure humanity survival.'},
               {id: 1, name: 'Alice in WonderLand', year: 2010, img: img2, description:'Nineteen-yand learns of her true destiny: to end the Red Queens reign of terror.'},
               {id: 2, name: 'The back-up plan', year: 2010, img: img3, description: 'A woman conceives twins through artificial insemination, only to meet the man of her dreams on the very same day.'}],
        newmovies: [{id: 0, name: 'Interstellar', year: 2014, img: img1, description: 'A team of explorers travel through a wormhole in space in an attempt to ensure humanity survival.'},
               {id: 1, name: 'Alice in WonderLand', year: 2010, img: img2, description:'Nineteen-year-old Alice returns er old friends and learns of her true destiny: to end the Red Queens reign of terror.'},
               {id: 2, name: 'The back-up plan', year: 2010, img: img3, description: 'A woman conceives twins through artificial insemination, only to meet the man of her dreams on the very same day.'}],



      comedies: [{id: 0, name: 'Ace Ventura: When Nature Calls', year: 1995, img: img4, description: 'A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S.'},
                 {id: 1, name: 'Big Daddy', year: 1999, img: img5, description: 'A lazy law school grad adopts a kid to impress his girlfriend, but everything doesnt go as planned and he becomes the unlikely foster father. '}],
      romances: [{id: 0, name: 'Titanic', year: 1997, img: img6, description: 'Ace Ventura, Pet Detective, returns from a spiritual quest to investigate the disappearance of a rare white bat, the sacred animal of a tribe in Africa.'},
                 {id: 1, name: 'The Notebook', year: 2004, img: img7, description: ' A poor yet passionate young man falls in love with a rich young woman, giving her a sense of freedom, but they are soon separated because of their social differences.'}],
      thrillers: [{id: 0, name: 'The Dark Knight', year: 2008, img: img8, description: 'When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham, the Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.'},
                 {id: 1, name: 'Inception', year: 2010, img: img9, description: 'A thief, who steals corporate secrets through the use of dream-sharing technology, is given the inverse task of planting an idea into the mind of a CEO.'}],
      horrors: [{id: 0, name: 'Mirrors', year: 2008, img: img10, description: 'An ex-cop and his family are the target of an evil force that is using mirrors as a gateway into their home. '},
                 {id: 1, name: 'Saw 1', year: 2004, img: img11, description: 'Two strangers, who awaken in a room with no recollection of how they got there, soon discover theyre pawns in a deadly game perpetrated by a notorious serial killer.'}],
      filterText: ''
    }
    this.handleChange = this.handleChange.bind(this);
    this.handleClickComedy = this.handleClickComedy.bind(this);
    this.handleClickRomance = this.handleClickRomance.bind(this);
    this.handleClickThriller = this.handleClickThriller.bind(this);
    this.handleClickHorror = this.handleClickHorror.bind(this);
    this.handleClickHome= this.handleClickHome.bind(this);
  }

  handleChange(e){
    this.setState({filterText: e.target.value});
  }

  handleClickHome(){
    this.setState({
      movies: this.state.newmovies
    })
    console.log("clicked");
  }

  handleClickComedy(){
    this.setState({
      movies: this.state.comedies
    })
    console.log("clicked");
  }

  handleClickRomance(){
    this.setState({
      movies: this.state.romances
    })
    console.log("clicked");
  }

  handleClickThriller(){
    this.setState({
      movies: this.state.thrillers
    })
    console.log("clicked");
  }

  handleClickHorror(){
    this.setState({
      movies: this.state.horrors
    })
    console.log("clicked");
  }

  render() {
    return (
     <div className="main"> 
        <div className="Left">
          <div className="menubar">
            <ul className="menuitems">
              <li onClick = {this.handleClickHome}><h1>Home</h1></li>
              <li onClick = {this.handleClickComedy}><h1>Comedy</h1></li>
              <li onClick = {this.handleClickRomance}><h1>Romance</h1></li>
              <li onClick = {this.handleClickThriller}><h1>Thriller</h1></li>
              <li onClick = {this.handleClickHorror}><h1>Horror</h1></li>
            </ul>
          </div>
        </div>

      <div className="Right">
      <div className="head">
        <div class="ui action left icon input" id="search">
          <input type="text" placeholder="Search..." value={this.state.filterText} onChange = {this.handleChange}/>
          <i className="search link icon"></i>
         
        </div>
        <div className="login">
          <Login/>
        </div>

        <div className="register">
          <Register/>
        </div>
        </div>
          <Content movies = {this.state.movies} filterText = {this.state.filterText}/>
      </div>
    </div>
    );
  }
}

export default Movie;