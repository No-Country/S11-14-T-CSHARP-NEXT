import React from 'react';

interface LabelProps {
  htmlFor: string;
  text: string;
  className: string;
}

const Label: React.FC<LabelProps> = (props) => {
  return (
    <label htmlFor={props.htmlFor} className={props.className}>
      {props.text}
    </label>
  );
};

export default Label;
