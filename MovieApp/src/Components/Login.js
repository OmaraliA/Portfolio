  



import React, { Component } from 'react';
import '../css/Login.css';




class Login extends Component {
    
  constructor(props){
  super(props);

  this.state={
    username:'',
    password:'',
    priv:"Login",
    name:'',
  
  }



  this.handleClick = this.handleClick.bind(this);
  this.handleOutsideClick = this.handleOutsideClick.bind(this);
  this.handleLogin = this.handleLogin.bind(this);
   this.handleClickLogin = this.handleClick.bind(this);
  this.state = {
      popupVisible: false,
     isToggleOn: true,
     isLogin:false
    };

  
  }

    handleClickLogin() {
    this.setState(function(prevState) {
      return {isToggleOn: !prevState.isToggleOn};
    });
  }

  handleLogin(){
    this.setState(function(prevState){
      return {
        isToggleOn: !prevState.isToggleOn,
       popupVisible: !prevState.popupVisible
     };
    });

  }

  handleClick() {
    if (!this.state.popupVisible) {
      // attach/remove event handler
      //document.addEventListener('click', this.handleOutsideClick, false);
    } else {
      //document.removeEventListener('click', this.handleOutsideClick, false);
    }

    this.setState(prevState => ({
       popupVisible: !prevState.popupVisible,
          isToggleOn: prevState.isToggleOn,
          isLogin:true

    }));
  }
  
  handleOutsideClick(e) {
    // ignore clicks on the component itself
    if (this.node.contains(e.target)) {
      return;
    }
    
    this.handleClick();
  }

  handleChangesName(e){
      this.setState({
        username: e.target.value
      })
    }


    handleChangesPassword(e){
      this.setState({
        password : e.target.value
      })
    }


  render() {
    console.log(this.state.priv)
    return (
      <div className="container" >
        
        <button className= "ui inverted white button" id="btnlog" 
          onClick ={this.handleClick.bind(this)} 
          title='Login here!'

          >
     {this.state.isToggleOn ? 'Login' : 'Logout'}
        </button>
        {this.state.popupVisible && this.state.isLogin && (
          <div
            className="popover"
          >
           <div class="ui middle aligned center aligned grid">
  <div class="column">
   

    <form action="" method="get" class="ui large form">
      <div class="ui stacked secondary  segment">
        <div class="field">
          <div class="ui left icon input">
            <i class="user icon"></i>
            <input type="text" name="email" value={this.state.username} onChange = {this.handleChangesName.bind(this)} placeholder="E-mail address"/>
          </div>
        </div>
        <div class="field">
          <div class="ui left icon input">
            <i class="lock icon"></i>
            <input type="password" name="password" value={this.state.password}  onChange = {this.handleChangesPassword.bind(this)} placeholder="Password"/>
          </div>
        </div>
        <div class="ui fluid large inverted blue submit button" onClick ={this.handleLogin.bind(this)}> Login</div>
      </div>

    </form>
  
  </div>
</div>
          </div>
         )}

                {!this.state.isLogin &&  (
              console.log("fg")
         
         )}
      </div>
    );
  }
}



export default Login;

