import React from "react";
import { BoldLink, BoxContainer, FormContainer, Input, MutedLink, SubmitButton } from "./sharedToForms";
import { Marginer } from "../marginer"
import { useContext } from "react";
import { AccountContext } from "./accountContext";
import { useState } from "react";


export function SignUpForm(props) {
    const { switchToSignin } = useContext(AccountContext);
    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [confirmPassword, setConfirmPassword] = useState('');

    const submit = (e) => {
        e.preventDefault();

        console.log({
            firstName,
            lastName,
            email,
            password,
            confirmPassword
        })
    }

  return(
    <BoxContainer>
      <FormContainer>
        <Marginer direction="vertical" margin="3em"></Marginer>
        <Input type="text" placeholder="First Name" onChange={e => setFirstName(e.target.value)}/>
        <Input type="text" placeholder="Last Name" onChange={e => setLastName(e.target.value)}/>
        <Input type="email" placeholder="Email" onChange={e => setEmail(e.target.value)}/>
        <Input type="password" placeholder="Password" onChange={e => setPassword(e.target.value)}/>
        <Input type="password" placeholder="Confirm Password" onChange={e => setConfirmPassword(e.target.value)}/>
        

      </FormContainer>
      <Marginer direction="vertical" margin={10} />
        
        <Marginer direction="vertical" margin="1em" />
        <SubmitButton type="submit" href="#" onClick={submit}>Sign up.</SubmitButton>
        <Marginer direction="vertical" margin=".5em"></Marginer>;
        <MutedLink href="#">Have an account? <BoldLink href="#" onClick={switchToSignin}>Sign in</BoldLink></MutedLink>
    </BoxContainer>
  )
}
