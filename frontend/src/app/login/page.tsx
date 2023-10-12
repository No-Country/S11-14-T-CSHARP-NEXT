'use client';
import { useRouter } from 'next/navigation';
import React, { useState } from 'react';
import httpClient from '@libs/httpClient';
import Link from 'next/link';
import { Session, User } from 'next-auth';
import { useSession } from 'next-auth/react';

interface LoginProps {}

const Login: React.FC<LoginProps> = (props) => {
  const [values, setValues] = useState({
    username: '',
    password: '',
  });
  const [isButtonDisabled, setIsButtonDisabled] = useState(true);
  const router = useRouter();
  const { data: session } = useSession();
  const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = event.target;
    setValues({ ...values, [name]: value });
    setIsButtonDisabled(values.username === '' || values.password === '');
  };

  const handleSubmit = async (event: React.MouseEvent<HTMLButtonElement, MouseEvent>) => {
    event.preventDefault();
    const { username, password } = values;

    // TODO: Add validations and errors messages before doing the request
    if (username === '' && password === '') {
      console.log('Missing username or password');
      return;
    }

    try {
      const response = await httpClient.post(`/Auth/Login`, {
        userName: username,
        password,
      });

      if (response.status === 200) {
        const data = await response.data;

        if (data.isValid) {
          // TODO: Handle token and user data
          const token = session?.user?.token;
          console.log('token', token);
          console.log('Login successful');
          // router.push('/');
        } else {
          // TODO: Show alerts as popups or toasts (Add react toast library ?)
          alert(data.message);
        }
      }
    } catch (error) {
      console.error('error', error);
    }
  };

  return (
    <div className='bg-bg-wiz flex flex-col justify-center pt-14 xl:pt-[180px] md:pt-[80px]'>
      <div className='block m-auto mb-16'>
        <h1 className='text-[60px] text-black text-left font-medium'>HotelWiz</h1>
        <h5 className='text-primary text-xl text-right mr-[-20px] font-medium'>Admin</h5>
      </div>
      <div className='block m-auto '>
        <form action='' className='font-Roboto w-[300px]'>
          <div className='flex flex-col mb-4'>
            <label htmlFor='username' className='text-left text-[#232130] opacity-50'>
              Usuario:
            </label>
            <input
              type='text'
              name='username'
              value={values.username}
              onChange={handleChange}
              placeholder='Correo electrónico*'
              className='text-[#232130] opacity-50 px-4 py-2 rounded-[5px]'
            />
          </div>
          <div className='flex flex-col'>
            <label htmlFor='password' className='text-left text-[#232130] opacity-50'>
              Contraseña:
            </label>
            <input
              type='password'
              name='password'
              value={values.password}
              onChange={handleChange}
              placeholder='Contraseña*'
              className='text-[#232130] opacity-50 px-4 py-2 rounded-[5px]'
            />
          </div>
          <div className='my-5'>
            <button
              type='submit'
              onClick={(event) => handleSubmit(event)}
              className={`px-6 py-2 bg-primary text-center w-full rounded-[5px] text-white text-base font-medium  ${
                isButtonDisabled ? 'cursor-not-allowed' : 'cursor-pointer'
              } `}
              disabled={isButtonDisabled}
            >
              Ingresar
            </button>
          </div>
        </form>
        <div>
          <div className='flex justify-between items-center'>
            <div className='flex justify-start items-center text-[#232130] opacity-50'>
              <input type='checkbox' name='remember' id='' className='h-5 w-5 mr-[2px]' />
              <h5 className='text-xs'>Recordarme</h5>
            </div>
            <div>
              <Link href={'/recuperar-contraseña'} className='text-[#232130] opacity-50 text-xs'>
                ¿Olvidaste tu contraseña?
              </Link>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Login;
