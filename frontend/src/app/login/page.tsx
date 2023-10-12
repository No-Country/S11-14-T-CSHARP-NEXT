'use client';
import React, { useState } from 'react';
import Link from 'next/link';
import Label from '@components/atoms/Label';
import Input from '@components/atoms/Input';
import Button from '@components/atoms/Button';
import Form from '@components/organisms/Form';

interface LoginProps {}

const Login: React.FC<LoginProps> = (props) => {
  return (
    <div className='bg-bg-wiz flex flex-col justify-center pt-14 xl:pt-[180px] md:pt-[80px]'>
      <div className='block m-auto mb-16 font-montserrat'>
        <h1 className='text-[60px] text-black text-left font-medium'>HotelWiz</h1>
        <h5 className='text-primary text-xl text-right mr-[-20px] font-medium'>Admin</h5>
      </div>
      <div className='block m-auto '>
        <Form />
        <div className='flex justify-between items-center'>
          <div className='flex justify-start items-center text-[#232130] opacity-50'>
            <Input type='checkbox' name='remember' className='h-5 w-5 mr-[2px]' />
            <h5 className='text-xs'>Recordarme</h5>
          </div>
          <div className='text-right'>
            <Link href={'/recuperar-contraseña'} className='text-[#232130] opacity-50 text-xs'>
              ¿Olvidaste tu contraseña?
            </Link>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Login;
