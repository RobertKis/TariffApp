import axios from 'axios';
import https from 'https-agent';

export function addProduct(type, resource, consumption) {
    let productObj = {
        type: type,
        resource: resource,
        consumption: consumption
    }
    console.log(productObj)

    axios.post(`api/Tariffs/AddProduct/`, productObj), {
        headers: {
            Accept: 'application/json',
            'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8',
        },
        rejectUnauthorized: false
    }

    //axios.post(`api/Tariffs/AddProduct/`, productObj, {
    //    headers: {
    //        Accept: 'application/json',
    //        'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8',
    //    },
    //    rejectUnauthorized: false
    //})
}