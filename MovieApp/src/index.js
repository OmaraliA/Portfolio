import React from 'react';
import ReactDOM from 'react-dom';
import './css/index.css';
import Movie from './Movie';
import registerServiceWorker from './registerServiceWorker';

ReactDOM.render(<Movie />, document.getElementById('root'));
registerServiceWorker();
