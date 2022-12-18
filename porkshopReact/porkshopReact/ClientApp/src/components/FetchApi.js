import React, { useState, useEffect } from "react";
import axios from "axios";

function FetchApi() {

const [posts, setPosts] = useState([])


useEffect(() => {
    fetchData(); 

}, [])

const fetchData =async() => {
const { data } = await axios.get("https://fakestoreapi.com/products")

    setPosts(data)
}
return (
    <div className="container row">
        {posts.map(product => (
            <div className="shadow-lg col-sm-3 align-items-stretch d-flex" key={product.id}>
            <div className="card">
                <div img="img.wrapper">
                <img className="card-img-top" src={product.image} key={product.image} alt="" />
                </div>
                <div className="card-body">
                <h6 key={product.title}>{product.title}</h6>
                <h4 key={product.price}>Price: ${product.price}</h4>
                <div className="btn-container">
                <button className="atc-btn"> Add To Cart</button>
                </div>
                </div>
            </div>
            </div>
        ))}
    </div>
    )
}
export default FetchApi;