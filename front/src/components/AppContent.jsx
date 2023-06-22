import * as React from 'react';
import jwt_decode from "jwt-decode";
import { request, setAuthHeader } from '../helpers/axios_helper';

import Buttons from './Buttons';
import AuthContent from './AuthContent';

import LoginForm from './LoginForm';
import WelcomeContent from './WelcomeContent'

export default class AppContent extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            componentToShow: "welcome",
            decodedToken: null,
            isLoggedIn: false 
        }
    };

    login = () => {
        this.setState({componentToShow: "login"})
    };

    logout = () => {
        this.setState({componentToShow: "welcome", decodedToken: null, isLoggedIn: false}) 
        setAuthHeader(null);
    };

    onLogin = (e, username, password) => {
        e.preventDefault();
        request(
            "POST",
            "/login",
            {
                login: username,
                password: password
            }).then(
            (response) => {
                const decodedToken = jwt_decode(response.data.token);
                console.log(decodedToken);
                setAuthHeader(response.data.token);
                this.setState({componentToShow: "messages", decodedToken, isLoggedIn: true}) 
            }).catch(
            (error) => {
                setAuthHeader(null);
                this.setState({componentToShow: "welcome", decodedToken: null, isLoggedIn: false}) 
            }
        );
    };


    onRegister = (event, firstName, lastName, username, password) => {
        event.preventDefault();
        request(
            "POST",
            "/register",
            {
                firstName: firstName,
                lastName: lastName,
                login: username,
                password: password
            }).then(
            (response) => {
                const decodedToken = jwt_decode(response.data.token);
                setAuthHeader(response.data.token);
                this.setState({componentToShow: "messages", decodedToken, isLoggedIn: true}) 
            }).catch(
            (error) => {
                setAuthHeader(null);
                this.setState({componentToShow: "welcome", decodedToken: null, isLoggedIn: false}) 
            }
        );
    };


    render() {
        const { componentToShow, decodedToken, isLoggedIn } = this.state;
        return (
          <>
          {componentToShow === "welcome" && <WelcomeContent /> }
            {!isLoggedIn && <Buttons login={this.login} />} 
            {isLoggedIn && <Buttons logout={this.logout} />} 
            {componentToShow === "login" && <LoginForm onLogin={this.onLogin} onRegister={this.onRegister} />}
            {componentToShow === "messages" && <AuthContent decodedToken={decodedToken} />}
          </>
        );
      };
}