import React, { useState } from "react";
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

const App = () => {
  const [loginAttempts, setLoginAttempts] = useState([]);

  const loginSubmit = async ({login, password}) => {
    await setLoginAttempts([...loginAttempts, {login, password}])
}

  return (
    <div className="App">
      <LoginForm onSubmit={loginSubmit} />
      <LoginAttemptList attempts={loginAttempts} />
    </div>
  );
};

export default App;
