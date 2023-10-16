import Input from '@components/atoms/Input';
import Label from '@components/atoms/Label';
import ErrorSpan from '@components/atoms/ErrorSpan';
import React from 'react';

interface InputFormProps {
  handleChange: Function;
  labelText: string;
  inputType: string;
  inputName: string;
  inputPlaceholder?: string;
  value: string;
  error: string;
}

const InputForm: React.FC<InputFormProps> = ({
  handleChange,
  labelText,
  inputName,
  inputType,
  inputPlaceholder,
  value,
  error,
}) => {


  return (
    <div className='flex flex-col'>
      <Label htmlFor='username' text={labelText} className='text-left text-graywiz-500' />
      <Input
        handleChange={handleChange}
        type={inputType}
        name={inputName}
        value={value}
        placeholder={inputPlaceholder}
        className='text-graywiz-500 px-4 py-2 rounded-[5px] bg-white border-2 border-graywiz-200 focus:border-primary hover:border-graywiz-300 focus:outline-none transition-all duration-200 ease-in-out'
      />
      {
        error &&
        <ErrorSpan className="span-error" text={error } />
      }
    </div>
  );
};

export default InputForm;
