import React from 'react';

interface ButtonProps {
  type: 'button' | 'submit' | 'reset';
  text: string;
  icon?: JSX.Element;
  className: string;
  onClick?: (event: React.MouseEvent<HTMLButtonElement, MouseEvent>) => void;
}

const Button: React.FC<ButtonProps> = ({ type, text, onClick, className, icon }) => {
  return (
    <button type={type} onClick={onClick} className={className}>
      {icon}
      {text}
    </button>
  );
};

export default Button;
