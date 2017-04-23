import React from 'react';
import Sidebar from 'react-sidebar';
require('./usersidebar.css');


export default class UserSidebar extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            sidebarOpen: true
        };

        this.onSetSidebarOpen = this.onSetSidebarOpen.bind(this);
    }

    onSetSidebarOpen (open) {
    this.setState({sidebarOpen: open});
    }

    render () {

    let sidebarContent =
        <h1>Sidebar</h1>;

    return (
        <div>
            <Sidebar sidebar={sidebarContent}
                     open={this.state.sidebarOpen}
                     onSetOpen={this.onSetSidebarOpen}>
                     <div> hello</div>
            </Sidebar>
        </div>
    );
}}
