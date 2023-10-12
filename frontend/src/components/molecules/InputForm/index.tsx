import Input from '@components/atoms/Input';
import Label from '@components/atoms/Label';
import React from 'react';

interface InputFormProps {
  labelText: string;
  inputType: string;
  inputName: string;
  inputPlaceholder?: string;
}

const InputForm: React.FC<InputFormProps> = (props) => {
  const values = '';

  const handleChange = () => {};

  return (
    <div className='flex flex-col'>
      <Label
        htmlFor='username'
        text={props.labelText}
        className='text-left text-[#232130] opacity-50'
      />
      <Input
        type={props.inputType}
        name={props.inputName}
        value={values}
        onChange={handleChange}
        placeholder={props.inputPlaceholder}
        className='text-[#232130] opacity-50 px-4 py-2 rounded-[5px] bg-white border border-[#D9D9D9]'
      />
    </div>
  );
};

export default InputForm;
