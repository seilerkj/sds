import React, { useState } from "react";
import './LoginForm.css';

const LoginForm = (props) => {

	const [username,setUsername] = useState('');
	const [password,setPassword] = useState('');
	const [errorMessage, setErrorMessage] = useState("");
	
	const updateUsername = (e) => {
		
		setUsername( e.target.value )
	}

	const updatePassword = (e) => {
		
		setPassword( e.target.value)
	}

	const handleSubmit = (event) => {
		event.preventDefault();
        setErrorMessage("");
        if (username  && password) {

			
		props.onSubmit({
			login: username,
			password: password,
		});
        
         
        } else {
          setErrorMessage(" User and password required. ");
        }
   
      }



	return (
		<form className="form">
			<h1>Login</h1>
			<label htmlFor="name">Name</label>
			<input type="text" id="name"  value={username} onChange={updateUsername} />
			<label htmlFor="password">Password</label>
			<input type="password" id="password"  value={password} onChange={updatePassword}/>
			<button type="submit" onClick={handleSubmit}>Continue</button>
			{errorMessage && (
            <p>{errorMessage}</p>
          )}
		</form>
	)
}

export default LoginForm;