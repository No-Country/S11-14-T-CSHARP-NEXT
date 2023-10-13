'use client';
import React from 'react';
import Button from '@components/atoms/Button';
import InputForm from '@components/molecules/InputForm';
import { useRouter } from 'next/navigation';
import { signIn } from 'next-auth/react';
import { useState } from 'react';

interface FormProps {}

const Form: React.FC<FormProps> = () => {
  const [values, setValues] = useState({
    username: '',
    password: '',
  });

  const router = useRouter();
  const handleSubmit = async (event: React.MouseEvent<HTMLButtonElement, MouseEvent>) => {
    event.preventDefault();
    const { username, password } = values;
    // TODO: Add validations and errors messages before doing the request
    if (username === '' && password === '') {
      console.log('Missing username or password');
      return;
    }

    try {
      const response = await signIn('credentials', {
        username,
        password,
      });

      if (response?.ok) {
        console.log('Authentication successful');
        router.push('/dashboard');
      } else {
        console.log('Authentication failed');
      }
    } catch (error) {
      console.error('error', error);
    }
  };

  return (
    <form action='' className='font-Roboto w-[300px]'>
      <div className='mb-4'>
        <InputForm
          labelText='Usuario'
          inputType='text'
          inputName='username'
          inputPlaceholder='Correo electrónico*'
          value={values.username}
          setValues={setValues}
        />
      </div>
      <div className=''>
        <InputForm
          labelText='Contraseña'
          inputType='password'
          inputName='password'
          inputPlaceholder='Contraseña*'
          value={values.password}
          setValues={setValues}
        />
      </div>
      <div className='my-5'>
        <Button
          type='submit'
          text='Ingresar'
          onClick={handleSubmit}
          className='px-6 py-2 bg-primary text-center w-full rounded-[5px] text-white text-base font-medium'
        />
      </div>
    </form>
  );
};

export default Form;
