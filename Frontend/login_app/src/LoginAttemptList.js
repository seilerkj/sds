import React, {useState} from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => <li {...props}>{props.children}</li>;

const LoginAttemptList = (props) => {
	const [filter, setFilter] = useState("");


	const updateFilter = (e) => {
		setFilter( e.target.value)
	}

	const renderList = (attempts) => {
		return attempts
		.filter(attempt => 
			{
			
			 	if (filter)
			 {
				return  attempt.login.includes(filter) || attempt.password.includes(filter)
			 }
			 return attempt;
		})
		.map((attempt, index) => { 
			return (
				<LoginAttempt  key={index} ><span> <b>username:</b> {attempt.login}</span> <b>password: </b>{attempt.password}</LoginAttempt> 
				)
		}) 
    
	  };

		 return (
			
		 	<div className="Attempt-List-Main">
		 		<p>Recent activity</p>
		 		<input type="input" placeholder="Filter..." value={filter} onChange={updateFilter} />
		 		<ul className="Attempt-List">
				 {renderList(props.attempts)}
		 		</ul>
		 	</div>
		 	);	
}


export default LoginAttemptList;