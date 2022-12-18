import { Component } from 'react';
import emptycart from "./empty_cart.gif";
import btnClick from './FetchApi';

class Cart extends Component {

    
render() {
    
return (
    <div className="container">
        <div className="card">
            <h5 className="card-title">My Cart</h5>
            <div className="center">
                <img className="gif-logo" src={emptycart} alt=""></img>
                <h4>Your cart is empty!</h4>
                {btnClick}
                <h6>Add item to it now</h6>
                <div className="btn-container">
                    <button class="btn btn-primary">Shop Now</button>
                </div>
            </div>
        </div>
    </div>
); 
}
}
export default Cart;