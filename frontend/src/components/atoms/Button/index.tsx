import React from 'react';

interface ButtonProps {
  type: 'button' | 'submit' | 'reset';
  text: string;
  className: string;
  onClick: (event: React.MouseEvent<HTMLButtonElement, MouseEvent>) => void;
}

const Button: React.FC<ButtonProps> = ({ type, text, onClick, className }) => {
  return (
    <button type={type} onClick={onClick} className={className}>
      {text}
    </button>
  );
};

export default Button;
