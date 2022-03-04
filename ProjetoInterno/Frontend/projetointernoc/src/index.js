import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import reportWebVitals from './reportWebVitals';

import Home from './pages/App';
import Login from './pages/login';
import Cadastro from './pages/cadastro'

const routing = (
  <Router>
    <div>
      <Routes>
      <Route exact path="/" element= {<Home/>} />
      <Route path="/login" element= {<Login/>} />
      </Routes>
    </div>
  </Router>
)
ReactDOM.render(routing, document.getElementById('root'));

reportWebVitals();
