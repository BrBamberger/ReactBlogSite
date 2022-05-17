import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './Layout';
import { Home } from './Pages/Home';
import { Admin } from './Pages/Admin';
import { ViewBlog } from './Pages/ViewBlog';
import { MostRecent } from './Pages/MostRecent';



export default class App extends Component {
  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/Admin/:blogId' component={Admin} />
            <Route path='/ViewBlog/blogId' component={ViewBlog} />
            <Route path='/MostRecent/blogId' component={MostRecent}/>
      </Layout>
    );
  }
}


