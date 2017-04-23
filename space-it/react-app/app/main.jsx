import React from 'react';
import ReactDOM from 'react-dom';


import Sidebarleft from './components/sidebar.jsx';
import UserSidebar from './components/usersidebar.jsx';
import ChatBox from './components/chat.jsx';
import Tabs from './components/tabs.jsx';
require("./css/style.css");

const nodecolor = {
  backgroundColor: '#86b559'
};
const nodebordercolor = {
  borderColor: '#86b559'
};
const node_pos1 = {
  marginLeft: '700px',
  marginTop: '600px'
};
const node_size1 = {
  width: '90%',
  height: '90%'
};
const subnode_pos1 = {
  marginLeft: '30px',
  marginTop: '70%'
};
const subnode_size1 = {
  width: '90%',
  height: '90%'
};

const nodecolorred = {
  backgroundColor: '#f25353'
};
const nodebordercolorred = {
  borderColor: '#f25353'
};
const node_posred = {
  marginLeft: '700px',
  marginTop: '20px'
};
const node_sizered = {
  width: '60%',
  height: '60%'
};

const nodecolorblue = {
  backgroundColor: '#2497dd'
};
const nodebordercolorblue = {
  borderColor: '#2497dd'
};
const node_posblue = {
  marginLeft: '60px',
  marginTop: '200px'
};
const node_sizeblue = {
  width: '80%',
  height: '80%'
};
const subnode_posblue = {
  marginLeft: '63%',
  marginTop: '50%'
};
const subnode_sizeblue = {
  width: '90%',
  height: '90%'
};

const nodecolororan = {
  backgroundColor: '#f7a152'
};
const nodebordercolororan = {
  borderColor: '#f7a152'
};
const node_posoran = {
  marginLeft: '1300px',
  marginTop: '200px'
};
const node_sizeoran = {
  width: '100%',
  height: '100%'
};
const subnode_posoran = {
  marginLeft: '68%',
  marginTop: '-2%'
};
const subnode_sizeoran = {
  width: '90%',
  height: '90%'
};
const subnode_posoran2 = {
  marginLeft: '33%',
  marginTop: '76%'
};
const subnode_sizeoran2 = {
  width: '90%',
  height: '90%'
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
              <a className="nav_logo" href="#"><h1>SPACE<b>IT</b></h1></a>
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
              <a href="#" className="btt tiny themecolor" style={nodecolor}>GO TO NODE</a>
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
          <a href="#" className="btt fill themecolor" style={nodecolor}>Enter node</a>
        </div>
        {/*Space canvas*********************************************************/}
        <div className="spacecanvas">
          <div className="node_con" style={node_pos1}>
            <div className="node_outer" style={node_size1}>
              <div className="node_atmosphere" style={nodecolor}>
              </div>
              <div className="node_core" style={nodecolor}>
              &#9772;
              </div>
              <div className="subnode_con" style={subnode_pos1}>
                <div className="node_outer" style={subnode_size1}>
                  <div className="node_atmosphere" style={nodecolor}>
                  </div>
                  <div className="subnode_core" style={nodecolor}>
                  &#9775;
                  </div>
                </div>
              </div>
              <div className="addsubnode" style={nodebordercolor}>
              +
              </div>
            </div>
          </div>

          <div className="node_con" style={node_posred}>
            <div className="node_outer" style={node_sizered}>
              <div className="node_atmosphere" style={nodecolorred}>
              </div>
              <div className="node_core" style={nodecolorred}>
              &#9729;
              </div>
              <div className="addsubnode" style={nodebordercolorred}>
              +
              </div>
            </div>
          </div>

          <div className="node_con" style={node_posblue}>
            <div className="node_outer" style={node_sizeblue}>
              <div className="node_atmosphere" style={nodecolorblue}>
              </div>
              <div className="node_core" style={nodecolorblue}>
              &#9742;
              </div>
              <div className="subnode_con" style={subnode_posblue}>
                <div className="node_outer" style={subnode_sizeblue}>
                  <div className="node_atmosphere" style={nodecolorblue}>
                  </div>
                  <div className="subnode_core" style={nodecolorblue}>
                  &#10070;
                  </div>
                </div>
              </div>
              <div className="addsubnode" style={nodebordercolorblue}>
              +
              </div>
            </div>
          </div>

          <div className="node_con" style={node_posoran}>
            <div className="node_outer" style={node_sizeoran}>
              <div className="node_atmosphere" style={nodecolororan}>
              </div>
              <div className="node_core" style={nodecolororan}>
              &#9788;
              </div>
              <div className="subnode_con" style={subnode_posoran}>
                <div className="node_outer" style={subnode_sizeoran}>
                  <div className="node_atmosphere" style={nodecolororan}>
                  </div>
                  <div className="subnode_core" style={nodecolororan}>
                  &#9789;
                  </div>
                </div>
              </div>
              <div className="subnode_con" style={subnode_posoran2}>
                <div className="node_outer" style={subnode_sizeoran2}>
                  <div className="node_atmosphere" style={nodecolororan}>
                  </div>
                  <div className="subnode_core" style={nodecolororan}>
                  &#9820;
                  </div>
                </div>
              </div>
              <div className="addsubnode" style={nodebordercolororan}>
              +
              </div>
            </div>
          </div>

        </div>
              {/*User panel*********************************************************/}
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
