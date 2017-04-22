import React from 'react';
import ReactDOM from 'react-dom';
import Sidebarleft from './components/sidebar.jsx';
require("./css/style.css");


class Maincontainer extends React.Component {
    constructor(props) {
        super(props);
    }


  render() {
    return (
      <div>
        <nav>
        <div className="floatright">
          <ul className="user">
            <li>
              <a href="#"><h1><i className="icon-user"></i>UserName</h1></a>
            </li>
            <li className="expand_toggle">
              <a href="#"><h1>-</h1></a>
            </li>
          </ul>
          <ul className="notifications">
            <li >
              <a href="#"><h1><i className="icon-user"></i>NodeName</h1></a>
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
          <Sidebarleft />
      </div>

    );
  }
}


ReactDOM.render(
  <Maincontainer />,
  document.body.appendChild(document.createElement('div'))
);
