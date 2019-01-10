import React, { Component } from 'react';
import { Col, Grid, Row } from 'react-bootstrap';
import { NavMenu } from './NavMenu';
import { ListOrders } from './ListOrders';
import Cookies from 'universal-cookie'
import { Redirect } from 'react-router';

export class NewOrders extends Component {
    constructor(props) {
        super(props);
        this.state = {redirect : false}
    }

    componentDidMount() {
        const cookies = new Cookies();
        if(cookies.get("user") == undefined)
            this.setState({redirect: true})
    }

    render() {
        let content = this.state.redirect? (<Redirect to="/login" />)
        :(<Grid fluid>
            <Row>
                <Col sm={3}>
                    <NavMenu show={true}/>
                </Col>
                <Col sm={9}>
                        <ListOrders queryString="statusKey=ordst9kiz6biche&page=1" />
                </Col>
            </Row>
        </Grid>)
        return(
            content
       );
    }
}