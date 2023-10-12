import React from 'react';

interface ButtonProps {
  type: 'button' | 'submit' | 'reset';
  text: string;
  className: string;
  onClick: () => void;
}

const Button: React.FC<ButtonProps> = (props) => {
  return (
    <button type={props.type} onClick={props.onClick} className={props.className}>
      {props.text}
    </button>
  );
};

export default Button;
