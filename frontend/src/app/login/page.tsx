'use client';
import { useRouter } from 'next/navigation';
import React, { useState } from 'react';
import axios from 'axios';
import httpClient from '@libs/httpClient';

interface LoginProps {}

const Login: React.FC<LoginProps> = (props) => {
  const [values, setValues] = useState({
    username: '',
    password: '',
  });
  const [isButtonDisabled, setIsButtonDisabled] = useState(true);
  const router = useRouter();

  const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = event.target;
    setValues({ ...values, [name]: value });
    setIsButtonDisabled(values.username === '' || values.password === '');
  };

  const handleSubmit = async () => {
    const { username, password } = values;

    // TODO: Add validations and errors messages before doing the request
    if (username === '' && password === '') {
      console.log('Missing username or password');
      return;
    }

    try {
      const response = await httpClient.post(`/auth/login`, {
        username,
        password,
      });

      // TODO: Show alerts as popups or toasts (Add react toast library ?)
      if (response.status === 200) {
        // TODO: Type data if its needed
        const data = await response.data;
        console.log(data);
        // TODO: Handle token and user data
        console.log('Login successful');
        router.push('/');
      } else if (response.status === 401) {
        console.log('Invalid username or password');
      } else if (response.status === 404) {
        console.log('User not found');
      } else {
        console.log('Error:', response.status);
      }
    } catch (error) {
      console.error(error);
    }
  };

  return (
    <div>
      <div className=''>
        <form action='' className=''>
          <div className=''>
            <label htmlFor='username' className=''>
              Nombre de usuario:
            </label>
            <input
              type='text'
              name='username'
              value={values.username}
              onChange={handleChange}
              placeholder='Ingresa tu nombre de usuario'
              className='text-black'
            />
          </div>
          <div className=''>
            <label htmlFor='password' className=''>
              Contraseña:
            </label>
            <input
              type='password'
              name='password'
              value={values.password}
              onChange={handleChange}
              placeholder='Ingresa tu contraseña'
              className='text-black'
            />
          </div>
          <div>
            <button
              type='submit'
              onClick={handleSubmit}
              className={`${isButtonDisabled ? 'cursor-not-allowed' : 'cursor-pointer'}`}
              disabled={isButtonDisabled}
            >
              Ingresar
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};

export default Login;
