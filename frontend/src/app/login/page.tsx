'use client';
import React, { useState } from 'react';

interface LoginProps {}

const Login: React.FC<LoginProps> = (props) => {
  const [values, setValues] = useState({
    username: '',
    password: '',
  });
  const [isButtonDisabled, setIsButtonDisabled] = useState(true);

  const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = event.target;
    setValues({ ...values, [name]: value });
    setIsButtonDisabled(values.username === '' || values.password === '');
  };

  const handleSubmit = () => {
    // TODO: Add code to send information to the database
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
