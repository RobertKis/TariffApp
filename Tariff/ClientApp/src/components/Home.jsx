import React, {Component, useState, useEffect } from 'react';
import { addProduct } from './utils';

const Home = (props) => {
    const [type, setType] = useState('BasicTariff');
    const [prodType, setprodType] = useState('Electricity');
    const [consumption, setConsumption] = useState('');

    const submitProd = (e) => {
        e.preventDefault(); 
        console.log("type")
        console.log(type)
        addProduct(type, prodType, consumption);        
    }

    return (
        <form onSubmit={submitProd} >
            <p>
                <label htmlFor="TariffType">Tariff Type</label>
                <select id="Type" onChange={(e) => setType(e.target.value)} value={type}>
                    <option value="BasicTariff">Basic Tarriff</option>
                    <option value="PackagedTariff">Packaged Tariff</option>
                </select>
            </p>
            <p>
                <label htmlFor="productType">Product Type</label>
                <select id="Resource" onChange={(e) => setprodType(e.target.value)} value={prodType}>
                    <option value="Electricity">Electricity</option>
                    <option value="Gas">Gas</option>
                    <option value="Water">Water</option>
                </select>
            </p>
            <p>
                <label htmlFor="consumption">Consumption</label>
                <input type="text" id="consumption" onChange={(e) => setConsumption(e.target.value)} />
            </p>
            <input type="submit" value="Submit" />
        </form>
    )
};

export default Home;