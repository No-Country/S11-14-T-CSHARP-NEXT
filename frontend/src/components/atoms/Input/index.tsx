import React from 'react';

interface InputProps {
  type: string;
  name: string;
  value?: string;
  className: string;
  placeholder?: string;
  onChange?: (event: React.ChangeEvent<HTMLInputElement>) => void;
}

const Input: React.FC<InputProps> = (props) => {
  return (
    <input
      type={props.type}
      name={props.name}
      value={props.value}
      placeholder={props.placeholder}
      className={props.className}
      onChange={props.onChange}
    />
  );
};

export default Input;
