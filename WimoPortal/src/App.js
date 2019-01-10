import React, { Component } from 'react';
import { BrowserRouter, Route, Switch, Redirect  } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { OrderDetails } from './components/OrderDetails';

export default class App extends Component {
  displayName = App.name

  render() {
      return (
        <Layout>
            <BrowserRouter>
                <Switch>
                    <Route exact path='/dashboard' component={Home} />
                    <Route path='/task/:id' component={OrderDetails} />
                    <Redirect to='/dashboard' />
                </Switch>
            </BrowserRouter>
      </Layout>
    );
  }
}
