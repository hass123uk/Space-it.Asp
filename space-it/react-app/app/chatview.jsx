import React from 'react';
import ReactDOM from 'react-dom';


import Sidebarleft from './components/sidebar.jsx';
import UserSidebar from './components/usersidebar.jsx';
import ChatBox from './components/chat.jsx';
import Tabs from './components/tabs.jsx';
require("./css/style.css");

const nodecolor = {
  backgroundColor: '#8ebf64'
};

class Maincontainer extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            username: {},
            data: {}
        }
    }

    // loadData () {
    //     fetch(`/api/`)
    //         .then(result =>{
    //             this.setState({data: data})
    //         });
    // }
    //
    // componentDidMount () {
    //     this.loadData();
    //     // setInterval(this.loadData, 60000)
    // }


  render() {
    if(!this.state.data){
    }
    let username = 'user';// this.state.username;
    return (
      <div>
      {/*Main Nav bar*********************************************************/}
        <nav>
          <div className="floatright">
            <ul className="user">
              <li>
                <a href="#"><h2><i className="icon-user"></i>UserName</h2></a>
              </li>
              <li className="expand_toggle">
                <a href="#"><h1>-</h1></a>
              </li>
            </ul>
            <ul className="notifications">
              <li >
                <a href="#"><h2><i className="icon-user"></i>NodeName</h2></a>
              </li>
            </ul>
          </div>
          <ul>
            <li>
              <img src="./img/spaceit_logo.svg"  alt="spaceit"/>
            </li>
            <li>
              <a className="nav_logo" href="#"><h1><i className="icon-spaceit_logo"></i>SPACE<b>IT</b></h1></a>
            </li>
          </ul>
        </nav>
        <div className="navpush"></div>
        {/*Sidebarleft*********************************************************/}
        <div className="sidebar">
          <div className="head" style={nodecolor}>
            <div className="node_op">
              <div className="img_con"></div><p>Node Creator:</p>
              <h3>NameOfCreator_OP</h3>
            </div>
            <ul className="node_stats">
              <li>O* 4</li>
              <li>O* 42</li>
              <li>O* 22/04/17</li>
            </ul>
          </div>
          <div className="node_info">
            <h1>Name of Node</h1>
            <p>
              NodeDescription Gravida in tincidunt. Lectus neque donec consectetuer.
              Hac wisi, quis nam, nulla lacinia vel, nisl sit, lorem platea dui massa arcu litora doloribus.
            </p>
          </div>
          <ul className="node_activity">
            <h2>
              Latest activity:
            </h2>
            <li>
            <div className="counter" style={nodecolor}>4</div>
              <h3>New messages in chat</h3>
              <h4>Hans bo says:</h4>
              <p>Awesome! - i’ll join that right away</p>
            </li>
            <li>
              <h3>USERNAME CREATE A NEW SUPNODE</h3>
              <h4>NameOfSubNode</h4>
              <div className="subnode_act">
              <a href="#" className="btt tiny" style={nodecolor}>GO TO NODE</a>
                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit...</p>

              </div>
            </li>
            <li>
              <h3>NEW USER JOINED NODE</h3>
              <div className="userblock">
                <div className="img_con"></div><h4>Users Name</h4>
              </div>
            </li>
          </ul>
          <a href="#" className="btt fill">Back to space</a>
        </div>
        {/*User side panel*********************************************************/}
        <div className="chatview">

          <div className="usersidepanel">
            <ul>
              <li className="head">
                <div className="inner">
                  MEMBERS
                </div>
              </li>
              <li>
                <div className="inner">
                  <div className="img_con"></div><h3>UserName_1</h3>
                </div>
              </li>
              <li>
                <div className="inner">
                  <div className="img_con"></div><h3>UserName_2</h3>
                </div>
              </li>
              <li>
                <div className="inner">
                  <div className="img_con"></div><h3>UserName_3</h3>
                </div>
              </li>
              <li>
                <div className="inner">
                  <div className="img_con"></div><h3>UserName_4</h3>
                </div>
              </li>
            </ul>
          </div>

          <ChatBox/>

        </div>
      </div>

    );
  }
}


ReactDOM.render(
  <Maincontainer />,
  document.body.appendChild(document.createElement('div'))
);
