import React, { Component } from 'react';
import { NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import piggy from './piggygif2.gif';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
        <div className="wrapper">
            <img className="gif-logo" src={piggy} alt=""></img>
            <h1>Welcome To PorkShop</h1>
            <h6>Clothing, Electronics and Accessories!</h6>
            
            <NavLink tag={Link} className="text-dark" to="/product">
                <button className="shop-btn">Shop Now!</button>
            </NavLink>
        </div >
    );
  }
}
