'use client';
import React from 'react';
import Button from '@components/atoms/Button';
import InputForm from '@components/molecules/InputForm';
import { useRouter } from 'next/navigation';
import { signIn } from 'next-auth/react';
import { useState, useEffect } from 'react';
import { useSession, signOut } from "next-auth/react";

// validation library
import { validate } from '@utils/validator';

interface FormProps {}

const Form: React.FC<FormProps> = () => {

  const router = useRouter();
  const { data: session } = useSession();

  const [state, setState] = useState({
    username: '',
    password: '',
  });

  const [errors, setErrors] = useState({
    username: '',
    password: '',
    error: false,
    errorMsg: ''
  });

  const handleChange = (event:any) => {

    if(event.target.name !== 'password') {
      setErrors({
        ...errors,
        error: false,
        [event.target.name]: validate(event.target.name, event.target.value),
      });
    }

    setState({
      ...state,
      [event.target.name]: event.target.value,
    });
  }


  useEffect(() => {
    //if(session?.user.email) router.push('/dashboard'); 
    if(session?.user) console.log(session);
    
  }, [session]);


  const handleSubmit = async (event: React.MouseEvent<HTMLButtonElement, MouseEvent>) => {

    event.preventDefault();
    const { username, password } = state;

    if (username === '' && password === '') {
      setErrors({
        ...errors,
        error: true,
        errorMsg: 'Todos los campos son obligatorios'
      });
      return;
    }

    if(errors.username || errors.password) {
      setErrors({
        ...errors,
        error: true,
        errorMsg: 'Algunos campos son incorrectos'
      });
      return;
    }

    try {

      const result = await signIn("credentials", {
        username: state.username,
        password: state.password,
        redirect: false,
        callbackUrl: "/dashboard",
      }) as any;

      if(result.error) {
        setErrors({
          ...errors,
          error: true,
          errorMsg: result.error
        });
        return;
      }
    
      console.log('login result: ', result);
      
    } catch (error) {
      
      console.error('error', error);
    }
  };

  return (
    <form 
      method='post' 
      className='font-Roboto w-[300px]'
    >
      {
        errors.error &&
        <div
          className='error-msg'
        >
          {errors.errorMsg}
        </div>
      }
      
      <div className='mb-4'>
        <InputForm
          handleChange={handleChange}
          labelText='Usuario'
          inputType='text'
          inputName='username'
          inputPlaceholder='Correo electrónico*'
          value={state.username}
        />
        {
          errors.username &&
          <span className="lbl-error">{errors.username }</span>
        }
      </div>
      <div className=''>
        <InputForm
          handleChange={handleChange}
          labelText='Contraseña'
          inputType='password'
          inputName='password'
          inputPlaceholder='Contraseña*'
          value={state.password}
        />{

        }
        {
          errors.password &&
          <span className="lbl-error">{errors.password}</span>
        }
      </div>
      <div className='my-5'>
        <Button
          type='submit'
          text='Ingresar'
          onClick={handleSubmit}
          className='px-6 py-2 bg-primary text-center w-full rounded-[5px] text-white text-base font-medium'
        />
      </div>
      { 
        // boton para salir de la sesion en testing XD...
        /*
        session?.user &&
        <button onClick={ () => signOut({ callbackUrl: "/login" }) }> salir </button>
        */
      }
    </form>
  );
};

export default Form;
