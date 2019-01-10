import React, { Component } from 'react';
import { Col, Grid, Panel, Button, DropdownButton, MenuItem} from 'react-bootstrap';
import { OrderCard } from './OrderCard';
import { NavMenu } from './NavMenu';
import './order-details.css';
import Constants from '../constants';

export class OrderDetails extends Component {

    constructor(props) {
        super(props);
        this.state = {loading: true, orderDetails: {}, statusList:[]};
    }

    componentDidMount() {
        let statusList = [];
        statusList["1"] = "pending";
        statusList["2"] = "started";
        statusList["3"] = "completed";
        statusList["4"] = "failed";
        let path = window.location.pathname.split('/');
        let orderKey = path[path.length-1];
        fetch(Constants.apiBaseUrl+`api/tasks/${orderKey}`)
            .then(response => response.json())
            .then(data => {
                this.setState({orderDetails: data, loading: false,statusList: statusList});
            });
    }

    onStatusChange = (eventKey, event) =>{
        this.setState(prevState => {
            const orderDetails = prevState.orderDetails;
            orderDetails.status = prevState.statusList[eventKey];
            return {orderDetails}
        });
    }

    updateOrder = () =>{
        var status = this.state.orderDetails.status;
        const requestOptions = {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(status)
        };
        fetch(Constants.apiBaseUrl + `api/tasks/${this.state.orderDetails.taskKey}`, requestOptions)
            .then(response => response.status == 200 || response.status == 201 || response.status == 204? alert("Success")
                : alert("Failed"));
    }

    render() {
        let content = this.state.loading? <p><em>Loading...</em></p>
        :(<div>
            
            <Grid className="details-grid">
                <Col sm={3}>
                    <NavMenu show={true} />
                </Col>
                <Col sm={9} style={{paddingLeft:0, paddingRight:60}}>
                    <Panel style = {{marginLeft:15, width:950}}>
                        <Panel.Body>
                            <DropdownButton id="status-menu" bsStyle="default" title={this.state.orderDetails.status} className="status-panel" onSelect={this.onStatusChange}>
                                <MenuItem eventKey="1" >pending</MenuItem>
                                <MenuItem eventKey="2" >started</MenuItem>
                                <MenuItem eventKey="3" >completed</MenuItem>
                                <MenuItem eventKey="4" >failed</MenuItem>
                            </DropdownButton>
                            <Button style={{marginLeft:100}} onClick={this.updateOrder}>Save Changes</Button>
                        </Panel.Body>
                    </Panel>
                    <Col sm={6}>
                        <OrderCard orderDetails={this.state.orderDetails}/>
                    </Col>
                </Col>
            </Grid>      
        </div>
          );

        return (
            content
        );
    }
}
