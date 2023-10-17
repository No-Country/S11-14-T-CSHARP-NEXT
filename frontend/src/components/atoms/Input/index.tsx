import React from 'react';

interface InputProps {
  handleChange: Function;
  type: string;
  name: string;
  value?: string;
  className: string;
  placeholder?: string;
}

const Input: React.FC<InputProps> = ({ handleChange, type, name, value, placeholder, className }) => {

  const handleChangeInput = (event: React.ChangeEvent<HTMLInputElement>) => {
    handleChange(event);
  }


  return (
    <input
      type={type}
      name={name}
      value={value}
      placeholder={placeholder}
      className={className}
      onChange={handleChangeInput}
    />
  );
};

export default Input;
