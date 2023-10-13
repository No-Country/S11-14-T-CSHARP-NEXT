import React from 'react';

interface InputProps {
  type: string;
  name: string;
  value?: string;
  className: string;
  placeholder?: string;
  onChange?: (event: React.ChangeEvent<HTMLInputElement>) => void;
}

const Input: React.FC<InputProps> = ({ type, name, value, placeholder, className, onChange }) => {
  return (
    <input
      type={type}
      name={name}
      value={value}
      placeholder={placeholder}
      className={className}
      onChange={onChange}
    />
  );
};

export default Input;
