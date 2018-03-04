import React, { Component } from 'react';
import CategoryItem from './CategoryItem';
import '../css/ContentView.css';
import { Link } from 'react-router-dom';
import img1 from '../img/interstellar.jpg'
import img2 from '../img/aliceinwonderland.png'
import img3 from '../img/thebackupplan.jpeg'

class ContentView extends Component {

    constructor(props){
        super(props);
    }
    render() {

        let filteredMovies = this.props.movies.filter(
        (movie) => {
          return movie.name.toLowerCase().indexOf(this.props.filterText.toLowerCase()) !== -1;
            }
        );

        var items = filteredMovies.map((movie) => {
          return <CategoryItem key = {movie.id}
          movie = {movie} showMore = {this.showMore}/>
        });
       

        return(
        <ul>
        {
          items
        }
        </ul>
        );

    }
}

export default ContentView;