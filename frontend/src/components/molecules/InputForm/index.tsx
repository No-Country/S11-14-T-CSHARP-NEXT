import Input from '@components/atoms/Input';
import Label from '@components/atoms/Label';
import React from 'react';

interface InputFormProps {
  labelText: string;
  inputType: string;
  inputName: string;
  inputPlaceholder?: string;
  value: string;
  setValues: React.Dispatch<React.SetStateAction<{ username: string; password: string }>>;
}

const InputForm: React.FC<InputFormProps> = ({
  labelText,
  inputName,
  inputType,
  inputPlaceholder,
  value,
  setValues,
}) => {
  const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = event.target;
    setValues((prevValues) => ({
      ...prevValues,
      [name]: value,
    }));
    // setIsButtonDisabled(values.username === '' || values.password === '');
  };

  return (
    <div className='flex flex-col'>
      <Label htmlFor='username' text={labelText} className='text-left text-[#232130] opacity-50' />
      <Input
        type={inputType}
        name={inputName}
        value={value}
        onChange={handleChange}
        placeholder={inputPlaceholder}
        className='text-[#232130] opacity-50 px-4 py-2 rounded-[5px] bg-white border border-[#D9D9D9]'
      />
    </div>
  );
};

export default InputForm;
