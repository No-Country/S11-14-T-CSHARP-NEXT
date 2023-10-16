import Input from '@components/atoms/Input';
import Label from '@components/atoms/Label';
import React from 'react';

interface InputFormProps {
  handleChange: Function;
  labelText: string;
  inputType: string;
  inputName: string;
  inputPlaceholder?: string;
  value: string;
}

const InputForm: React.FC<InputFormProps> = ({
  handleChange,
  labelText,
  inputName,
  inputType,
  inputPlaceholder,
  value,
}) => {


  return (
    <div className='flex flex-col'>
      <Label htmlFor='username' text={labelText} className='text-left text-[#232130] opacity-50' />
      <Input
        handleChange={handleChange}
        type={inputType}
        name={inputName}
        value={value}
        placeholder={inputPlaceholder}
        className='text-gray-700 px-4 py-2 rounded-[5px] bg-white border border-2 border-gray-300'
      />
    </div>
  );
};

export default InputForm;
