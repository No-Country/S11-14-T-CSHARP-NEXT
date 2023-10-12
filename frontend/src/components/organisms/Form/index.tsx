"use client";
import React from 'react';
import Button from '@components/atoms/Button';
import Input from '@components/atoms/Input';
import Label from '@components/atoms/Label';
import InputForm from '@components/molecules/InputForm';

interface FormProps {
  
}

const Form: React.FC<FormProps> = (props) => {
  const handleSubmit = () => {
    //TODO: handle form submit
  }

  return (
    <form action='' className='font-Roboto w-[300px]'>
      <div className='mb-4'>
        <InputForm labelText ="Usuario" inputType="text" inputName="username" inputPlaceholder="Correo electrónico*"/>
      </div>
      <div className=''>
        <InputForm labelText ="Contraseña" inputType="password" inputName="password" inputPlaceholder="Contraseña*"/>
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
