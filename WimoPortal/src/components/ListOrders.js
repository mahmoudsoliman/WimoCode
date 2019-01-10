import React, { Component } from 'react';
import {stringify} from 'querystring';
import { Redirect } from 'react-router';
import Constants from '../constants';

export class ListOrders extends Component {
    displayName = ListOrders.name
    
    constructor(props) {
        super(props);
        this.state = { orders: [], loading: true, redirect: false, payload: {}};
    }

    fetchDataWithQuery = queryString => {
        fetch(Constants.apiBaseUrl+`api/tasks?${queryString?queryString:''}`)
            .then(response => response.json())
            .then(data => {
                console.log(data);
                this.setState({ orders: data, loading: false });
            });
    }

    componentDidMount() {
        this.fetchDataWithQuery(this.props.queryString);
    }

    showDetails = oredrDetails => {
        console.log("1 : ");
        console.log(oredrDetails);
        this.setState({payload: {orderKey:oredrDetails.taskKey}, redirect: true});
    }

    redirectToDetailsPage(){        
        console.log("Should Redirect Now  " + this.state.payload.orderKey);
        console.log(this.state.payload);
        let payload = encodeURIComponent(JSON.stringify(this.state.payload));
        console.log(payload);
        return <Redirect to={`/task/${this.state.payload.orderKey}`}/>
    }

    renderOrdersTable(orders) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th> Order Key</th>
                        <th>Created On</th>
                        <th>Courier</th>
                        <th>Driver Name</th>
                        <th>Description</th>
                        <th>Status</th>
                    </tr>
                </thead>
                <tbody>
                    {orders.map(order =>
                        <tr key={order.taskId} onClick={() => this.showDetails(order)}>
                            <td>{order.taskKey}</td>
                            <td>{order.createdOn}</td>
                            <td>{order.courier}</td>
                            <td>{order.driverName}</td>
                            <td>{order.description}</td>
                            <td>{order.status}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : ((this.state.redirect && this.state.payload != undefined)? this.redirectToDetailsPage() : this.renderOrdersTable(this.state.orders));
        return (<div>
            {contents}
        </div>)
    }
}