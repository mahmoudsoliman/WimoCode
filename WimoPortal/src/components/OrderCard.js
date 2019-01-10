import React, { Component } from 'react';
import { Grid, Row, Panel, Col } from 'react-bootstrap'
import './order-card.css';

export class OrderCard extends Component {
    constructor(props) {
        super(props);
        this.state = {loading: true, orderDetails: {}}
    }

    componentDidMount() {
        this.setState({orderDetails: this.props.orderDetails, loading: false})
    }

    render() {
        let content = this.state.loading? <p><em>Loading...</em></p>
        :(<Grid style={{marginTop:10, width:420}}>
            <Row>
                <Panel>
                    <Panel.Heading> OrderDetails</Panel.Heading>
                    <Panel.Body>
                        <table border="0">
                            <tbody>
                                <tr>
                                    <td style={{width:150}}>
                                    Order Key
                                    </td>
                                    <td style={{marginLeft:20}}>
                                    {this.state.orderDetails.taskKey}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    Created On
                                    </td>
                                    <td style={{marginLeft:20}}>
                                    {this.state.orderDetails.createdOn}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    Courier
                                    </td>
                                    <td style={{marginLeft:20}}>
                                    {this.state.orderDetails.courier}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    Driver Name
                                    </td>
                                    <td style={{marginLeft:20}}>
                                    {this.state.orderDetails.driverName}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    Description
                                    </td>
                                    <td style={{marginLeft:20}}>
                                    {this.state.orderDetails.description}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    Started At
                                    </td>
                                    <td style={{marginLeft:20}}>
                                    {this.state.orderDetails.startedAt}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    Finished At
                                    </td>
                                    <td style={{marginLeft:20}}>
                                    {this.state.orderDetails.finishedAt}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    Driver Comment
                                    </td>
                                    <td style={{marginLeft:20}}>
                                    {this.state.orderDetails.driverComment}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    Status
                                    </td>
                                    <td style={{marginLeft:20}}>
                                    {this.state.orderDetails.status}
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </Panel.Body>
                </Panel>
            </Row>
        </Grid>)
        return (
            content
        );
    }
}
