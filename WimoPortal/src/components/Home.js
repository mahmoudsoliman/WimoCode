import React, { Component } from 'react';
import { Col, Grid, Row } from 'react-bootstrap';
import { NavMenu } from './NavMenu';
import { ListOrders } from './ListOrders';

export class Home extends Component {
  displayName = Home.name
  constructor(props) {
    super(props);
    this.state = {redirect : false}
}

render() {
      let content = 
       (
       <Grid fluid>
            <Row>
                <Col sm={3}>
                    <NavMenu show={true}/>
                </Col>
                <Col sm={9}>
                        <ListOrders queryString="sortTypeId=1" />
                </Col>
            </Row>
        </Grid>
        )
      return (
          content
      );
  }
}